using AdminService.DBContext;
using AdminService.Helpers;
using AdminService.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace AdminService.Services
{
    public interface IAdminService
    {
        Task<List<AdminModel>> GetAdmins();


        Task<AdminModel> GetAdmin(Guid ID);

        Task<ResponseModel> CreateAdmin(AdminModel model);

        Task<ResponseModel> UpdateAdmin(AdminModel model);

        Task<ResponseModel> DeleteAdmin(Guid ID, Guid ModifiedBy);

        Task<AdminModel> ValidateAccess(string username, string password);

        Task<bool> ResetPassword(Guid ID);

        Task<bool> ChangePassword(string username, string oldPassword, string newPassword);

        Task<List<SysMenuGroup>> GetMenuByUser(Guid ID);

        Task<List<SysMenuGroup>> GetAllMenu();

        Task<List<RoleModel>> GetRoles();

        Task<RoleModel> GetRole(Guid ID);

        Task<GenericResponse> CreateRole(RoleModel model);

        Task<GenericResponse> EditRole(RoleModel model);

        Task<GenericResponse> DeleteRole(Guid ID, Guid ModifiedBy);

        Task<GenericResponse> SaveMenuGroupSort(List<MenuGroupModel> model);

        Task<GenericResponse> DeleteMenuGroup(Guid ID, Guid ModifiedBy);

        Task<GenericResponse> CreateMenuGroup(MenuGroupModel model);

        Task<GenericResponse> EditMenuGroup(MenuGroupModel model);

        Task<MenuGroupModel> GetMenuGroup(Guid ID);

        Task<SysMenuGroup> GetMenuByGroup(Guid MenuGroupID);

        Task<SysMenu> GetMenu(Guid ID);

        Task<GenericResponse> CreateMenu(MenuModel model);

        Task<GenericResponse> EditMenu(MenuModel model);

        Task<GenericResponse> UpdateMenuSort(List<MenuModel> model);

        Task<GenericResponse> DeleteMenu(Guid ID, Guid ModifiedBy);
        Task<List<RolePermissionModel>> GetUserPermissions(Guid userId);
        Task<List<RoleControllerPermissionModel>> GetRoleControllerPermissionByUserId(Guid userID);
        Task<bool> UnlockUserAsync(Guid userId, Guid actionUserId);
    }

    public class AdminService : BaseService, IAdminService
    {
        private readonly PasswordSetting _passwordSetting;

        public AdminService(IConfiguration configuration,
            IWebHostEnvironment env,
            IOptions<PasswordSetting> passwordSetting) :
            base(configuration, "", env)
        {
            _passwordSetting = passwordSetting.Value;
        }

        public async Task<ResponseModel> CreateAdmin(AdminModel model)
        {
            ResponseModel resultModel = new ResponseModel();

            string pwd = this.GeneratePassword();
            string hPwd = BCrypt.Net.BCrypt.HashPassword(pwd, BCrypt.Net.BCrypt.GenerateSalt());

            try
            {
                if (IsDuplicate(model.Username, model.Email))
                {
                    resultModel.ErrorCode = 70001;
                    resultModel.ErrorMessage = "User record duplicated";
                }
                else
                {
                    using (pgzeusContext context = new pgzeusContext(_options.Options))
                    {
                        var data =
                            new SysAdmin
                            {
                                Username = model.Username,
                                Password = hPwd,
                                Fullname = model.FullName,
                                Email = model.Email,
                                Mobile = model.Mobile,
                                Roleuuid = model.RoleUUID,
                                Efffromdate = model.StartDate,
                                Efftodate = model.EndDate,
                                Crby = model.CreatedBy,
                                StatusId = 1
                            };

                        await context.SysAdmin.AddAsync(data);
                        await context.SaveChangesAsync();

                        await context.SysAdminPasswordHistory.AddAsync(new SysAdminPasswordHistory
                        {
                            Userid = data.Adminuuid,
                            Password = hPwd,
                            CreatedDate = DateTime.UtcNow,
                            MinPasswordAgeDays = 0      // Allow to immediate change password for new created account
                        });
                        await context.SaveChangesAsync();

                        model.ID = data.Adminuuid;
                        model.CreatedDate = data.Crdt;
                    }

                    try
                    {
                        string subject = _configuration.GetSection("EmailConfig:CreateSubject").Value;
                        string content = _configuration.GetSection("EmailConfig:CreateContent").Value;

                        subject = subject.Replace("{Username}", model.Username);
                        content = content.Replace("{Username}", model.Username);
                        content = content.Replace("{Password}", pwd);

                        SendEmail(subject, content, model.Email);
                    }
                    catch (Exception eEx)
                    {
                        resultModel.ErrorCode = 90001;
                        resultModel.ErrorMessage = eEx.Message;
                        throw eEx;
                    }
                }

                model.Password = null;
                resultModel.Admin = model;
            }
            catch (Exception ex)
            {
                resultModel.ErrorCode = 90000;
                resultModel.ErrorMessage = ex.Message;

                throw ex;
            }

            return resultModel;
        }

        public async Task<ResponseModel> DeleteAdmin(Guid ID, Guid ModifiedBy)
        {
            ResponseModel result = new ResponseModel();

            try
            {
                using (pgzeusContext context = new pgzeusContext(_options.Options))
                {

                    SysAdmin sysAdmin =
                        await (from ir in context.SysAdmin select ir)
                        .Where(i => i.Adminuuid == ID).SingleOrDefaultAsync();

                    if (sysAdmin != null && sysAdmin.Adminuuid != Guid.Empty)
                    {
                        result.Admin = JsonConvert.DeserializeObject<AdminModel>(JsonConvert.SerializeObject(await this.GetAdmin(ID)));

                        sysAdmin.Upby = ModifiedBy;
                        sysAdmin.Updt = DateTime.UtcNow;
                        sysAdmin.StatusId = 0;
                        sysAdmin.Efftodate = DateTime.UtcNow;

                        await context.SaveChangesAsync();
                    }
                    else
                    {
                        result.ErrorCode = 80000;
                        result.ErrorMessage = "Record not found.";
                    }

                }
            }
            catch (Exception ex)
            {
                result.ErrorCode = 90000;
                result.ErrorMessage = ex.Message;
            }


            return result;
        }

        public async Task<AdminModel> GetAdmin(Guid ID)
        {
            AdminModel result = new AdminModel();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var dbResult =
                    await (from ir in context.SysAdmin
                           where (ir.StatusId == 1)
                           select new
                           {
                               ID = ir.Adminuuid,
                               Username = ir.Username,
                               FullName = ir.Fullname,
                               Email = ir.Email,
                               Mobile = ir.Mobile,
                               RoleUUID = ir.Roleuuid,
                               StartDate = ir.Efffromdate,
                               EndDate = ir.Efftodate,
                               CreatedBy = ir.Crby,
                               CreatedDate = ir.Crdt == null ? DateTime.MinValue : ir.Crdt,
                               ModifiedBy = ir.Upby == null ? Guid.Empty : ir.Upby,
                               ModifiedDate = ir.Updt == null ? DateTime.MinValue : ir.Updt,
                               IsRequiredChangePassword = ir.PasswordExpiryDate.HasValue
                                   && DateTime.UtcNow > ir.PasswordExpiryDate,
                               PasswordExpiryDate = ir.PasswordExpiryDate,
                               IsLocked = ir.Lockedstatus == 1
                           }).Where(i => i.ID == ID).SingleOrDefaultAsync();

                if (dbResult != null)
                {
                    result = JsonConvert.DeserializeObject<AdminModel>(JsonConvert.SerializeObject(dbResult));
                }
            }

            return result;
        }

        public async Task<List<AdminModel>> GetAdmins()
        {
            List<AdminModel> result = new List<AdminModel>();

            try
            {
                using (pgzeusContext context = new pgzeusContext(_options.Options))
                {
                    var dbResult =
                        await (from ir in context.SysAdmin
                               where (ir.StatusId == 1)
                               select new
                               {
                                   ID = ir.Adminuuid,
                                   Username = ir.Username,
                                   FullName = ir.Fullname,
                                   Email = ir.Email,
                                   Mobile = ir.Mobile,
                                   StartDate = ir.Efffromdate,
                                   EndDate = ir.Efftodate,
                                   CreatedBy = ir.Crby,
                                   CreatedDate = ir.Crdt == null ? DateTime.MinValue : ir.Crdt,
                                   ModifiedBy = ir.Upby == null ? Guid.Empty : ir.Upby,
                                   ModifiedDate = ir.Updt == null ? DateTime.MinValue : ir.Updt,
                                   StatusId = ir.StatusId,
                                   IsLocked = ir.Lockedstatus == 1
                               }).ToListAsync();

                    if (dbResult != null)
                    {
                        result = JsonConvert.DeserializeObject<List<AdminModel>>(JsonConvert.SerializeObject(dbResult));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public async Task<ResponseModel> UpdateAdmin(AdminModel model)
        {
            ResponseModel result = new ResponseModel();

            try
            {
                using (pgzeusContext context = new pgzeusContext(_options.Options))
                {
                    var data =
                            await (from ir in context.SysAdmin
                                   select ir).Where(i => i.Adminuuid == model.ID).SingleOrDefaultAsync();

                    if (data != null && data.Adminuuid != Guid.Empty)
                    {
                        data.Fullname = model.FullName;
                        data.Email = model.Email;
                        data.Mobile = model.Mobile;
                        data.Efffromdate = model.StartDate;
                        data.Efftodate = model.EndDate;
                        data.Roleuuid = model.RoleUUID;
                        data.Upby = model.ModifiedBy;
                        data.Updt = DateTime.UtcNow;

                        await context.SaveChangesAsync();

                        result.Admin = JsonConvert.DeserializeObject<AdminModel>(JsonConvert.SerializeObject(await this.GetAdmin(model.ID)));
                    }
                    else
                    {
                        result.ErrorCode = 80000;
                        result.ErrorMessage = "Record not found.";
                    }
                }
            }
            catch (Exception ex)
            {
                result.ErrorCode = 90000;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<bool> ResetPassword(Guid ID)
        {
            ResponseModel result = new ResponseModel();

            string username = "", email = "";
            string pwd = this.GeneratePassword();
            string hPwd = BCrypt.Net.BCrypt.HashPassword(pwd, BCrypt.Net.BCrypt.GenerateSalt());

            try
            {
                using (pgzeusContext context = new pgzeusContext(_options.Options))
                {
                    var data =
                            await (from ir in context.SysAdmin
                                   select ir).Where(i => i.Adminuuid == ID).SingleOrDefaultAsync();

                    if (data != null && data.Adminuuid != Guid.Empty)
                    {
                        data.Password = hPwd;
                        data.Updt = DateTime.UtcNow;
                        username = data.Username;
                        email = data.Email;
                        data.PasswordExpiryDate = DateTime.UtcNow.AddDays(_passwordSetting.MaxPasswordAge);

                        await context.SysAdminPasswordHistory.AddAsync(new SysAdminPasswordHistory
                        {
                            Userid = data.Adminuuid,
                            Password = hPwd,
                            CreatedDate = DateTime.UtcNow,
                            MinPasswordAgeDays = 0      // Allow to immediate change password after reset
                        });

                        await context.SaveChangesAsync();

                        result.Admin = JsonConvert.DeserializeObject<AdminModel>(JsonConvert.SerializeObject(await this.GetAdmin(ID)));
                    }
                    else
                    {
                        result.ErrorCode = 80000;
                        result.ErrorMessage = "Record not found.";
                    }
                }

                try
                {
                    string subject = _configuration.GetSection("EmailConfig:ResetSubject").Value;
                    string content = _configuration.GetSection("EmailConfig:ResetContent").Value;

                    subject = subject.Replace("{Username}", username);
                    content = content.Replace("{Username}", username);
                    content = content.Replace("{Password}", pwd);

                    SendEmail(subject, content, email);
                }
                catch (Exception eEx)
                {
                    throw eEx;
                    //using (pgzeusContext context = new pgzeusContext(_options.Options))
                    //{
                    //    context.GenericApplicationLog.Add(new GenericApplicationLog()
                    //    {
                    //        ApplicationModule = "Forget Password",
                    //        ApplicationName = "Admin Services",
                    //        IsError = true,
                    //        LogMessage = eEx.ToString()
                    //    });

                    //    await context.SaveChangesAsync();

                    //}
                    //result.ErrorCode = 90001;
                    //result.ErrorMessage = eEx.Message;
                }
            }
            catch (Exception ex)
            {
                throw ex;
                result.ErrorCode = 90000;
                result.ErrorMessage = ex.Message;
            }

            return result.Admin.ID != Guid.Empty;
        }

        public async Task<AdminModel> ValidateAccess(string username, string password)
        {
            AdminModel model = new AdminModel();
            bool result = false;

            try
            {
                using (pgzeusContext context = new pgzeusContext(_options.Options))
                {
                    var data = await
                        (from ir in context.SysAdmin
                         select ir)
                            .Where(i => i.Username.ToLower() == username.ToLower()
                                && i.Efffromdate < DateTime.UtcNow && i.Efftodate > DateTime.UtcNow)
                            .SingleOrDefaultAsync();

                    if (data != null && data.Adminuuid != Guid.Empty)
                    {
                        result = BCrypt.Net.BCrypt.Verify(password, data.Password);

                        if (result)
                        {
                            var isLocked = data.Lockedstatus == 1;
                            if (isLocked)
                            {
                                throw new ApplicationException(ErrorMessages.ACCOUNT_IS_LOCKED);
                            }

                            data.Retrycount = 0;

                            await context.SaveChangesAsync();

                            model = await this.GetAdmin(data.Adminuuid);
                        }
                        else
                        {
                            data.Retrycount ??= 0;
                            data.Retrycount++;
                            data.Lockedstatus = data.Retrycount >= _passwordSetting.AccountLockoutAttempt ? 1 : 0;

                            await context.SaveChangesAsync();

                            if (data.Lockedstatus == 1)
                            {
                                throw new ApplicationException(ErrorMessages.ACCOUNT_IS_LOCKED);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return model;
        }

        public async Task<bool> ChangePassword(string username, string oldPassword, string newPassword)
        {
            bool result = false;

            try
            {
                using (pgzeusContext context = new pgzeusContext(_options.Options))
                {
                    var data = await
                        (from ir in context.SysAdmin
                         select ir)
                            .Where(i => i.Username.ToLower() == username.ToLower()
                                && i.Efffromdate < DateTime.UtcNow && i.Efftodate > DateTime.UtcNow)
                            .SingleOrDefaultAsync();

                    if (data != null && data.Adminuuid != Guid.Empty)
                    {
                        result = BCrypt.Net.BCrypt.Verify(oldPassword, data.Password);

                        if (result)
                        {
                            #region Min Password Age validation
                            var lastChangePasswordHistory = await context.SysAdminPasswordHistory
                                .Where(x => x.Userid == data.Adminuuid)
                                .OrderByDescending(x => x.CreatedDate)
                                .FirstOrDefaultAsync();

                            if (lastChangePasswordHistory != null)
                            {
                                DateTime allowChangePasswordDate = DateTime.SpecifyKind(
                                    lastChangePasswordHistory.CreatedDate.AddDays(lastChangePasswordHistory.MinPasswordAgeDays),
                                    DateTimeKind.Utc);

                                if (allowChangePasswordDate > DateTime.UtcNow)
                                {
                                    throw new ApplicationException(String.Concat(
                                        ErrorMessages.FAILED_MIN_PASSWORD_AGE,
                                        Environment.NewLine,
                                        String.Format(ErrorMessages.FAILED_MIN_PASSWORD_AGE_2, allowChangePasswordDate.ToLocalTime())));
                                }
                            }
                            #endregion

                            var previousPasswords = await GetPreviousNthPasswords(data.Adminuuid);
                            if (previousPasswords.Any(x => BCrypt.Net.BCrypt.Verify(newPassword, x)))
                            {
                                throw new ApplicationException(String.Format(
                                    ErrorMessages.NOT_ALLOWED_PREVIOUS_PASSWORD + ErrorMessages.NOT_ALLOWED_PREVIOUS_PASSWORD_2, 
                                    _passwordSetting.EnforcePasswordHistory));
                            }

                            data.Password = BCrypt.Net.BCrypt.HashPassword(newPassword, BCrypt.Net.BCrypt.GenerateSalt());
                            data.PasswordExpiryDate = DateTime.UtcNow.AddDays(_passwordSetting.MaxPasswordAge);
                            data.Updt = DateTime.UtcNow;
                            data.Upby = data.Adminuuid;

                            await context.SysAdminPasswordHistory.AddAsync(new SysAdminPasswordHistory
                            {
                                Userid = data.Adminuuid,
                                Password = data.Password,
                                CreatedDate = DateTime.UtcNow,
                                MinPasswordAgeDays = _passwordSetting.MinPasswordAge
                            });
                            await context.SaveChangesAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return result;
        }

        private string GeneratePassword()
        {
            Random random = new Random();

            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz!@#$%^&*-_";
            return new string(Enumerable.Repeat(chars, Convert.ToInt32(_configuration.GetSection("PasswordSetting:DefaultLength").Value))
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void SendEmail(string subject, string content, string recipient)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient sClient = new SmtpClient();
                sClient.Port = int.Parse(_configuration.GetSection("EmailConfig:Port").Value);
                sClient.Host = _configuration.GetSection("EmailConfig:Server").Value;

                mail.Subject = subject;
                mail.From = new MailAddress(_configuration.GetSection("EmailConfig:From").Value);
                mail.To.Add(recipient);
                mail.IsBodyHtml = true;
                mail.Body = content;

                sClient.Send(mail);
            }
            catch (Exception ex)
            {
                using (pgzeusContext context = new pgzeusContext(_options.Options))
                {
                    context.GenericApplicationLog.Add(new GenericApplicationLog()
                    {
                        ApplicationModule = "SendEmail",
                        ApplicationName = "Admin Services",
                        IsError = true,
                        LogMessage = ex.ToString()
                    });

                    context.SaveChangesAsync();

                }

                throw ex;
            }
        }

        private bool IsDuplicate(string username, string email)
        {
            bool result = true;

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var admin = (from ir in context.SysAdmin
                             select ir).Where(i => i.Username.ToLower() == username.ToLower() || i.Email.ToLower() == email.ToLower()).FirstOrDefault();

                result = admin != null;
            }

            return result;
        }

        public async Task<List<SysMenuGroup>> GetMenuByUser(Guid ID)
        {
            List<SysMenuGroup> result = new List<SysMenuGroup>();
            List<Guid> listMenuGroup = new List<Guid>();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var d =
                    await (from a in context.SysAdmin.Include(b => b.Roleuu)
                           .ThenInclude(c => c.SysRolesMenu)
                           .ThenInclude(d => d.MenuGroup)
                           select a)
                        .Where(a => a.Adminuuid == ID).FirstOrDefaultAsync();

                if (d != null)
                {
                    foreach (var row in d.Roleuu.SysRolesMenu)
                    {
                        listMenuGroup.Add(row.MenuGroupId);
                    }
                }
            }

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var dbResult =
                    await (from a in context.SysMenuGroup
                           .Include(x => x.SysMenu)
                           .ThenInclude(b => b.InverseParent)
                           .ThenInclude(c => c.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .OrderBy(v => v.SortNo)
                           select a
                    ).Where(a => listMenuGroup.Contains(a.Id))
                    .OrderBy(a => a.SortNo).ToListAsync();

                if (dbResult != null)
                {
                    result = dbResult;

                    foreach (var rowGroup in result)
                    {
                        rowGroup.SysMenu = OrderItems(rowGroup.SysMenu.ToList());
                    }
                }
            }

            return result;
        }


        public async Task<List<SysMenuGroup>> GetAllMenu()
        {
            List<SysMenuGroup> result = new List<SysMenuGroup>();
            List<Guid> listMenuGroup = new List<Guid>();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var dbResult =
                    await (from a in context.SysMenuGroup
                           .Include(x => x.SysMenu)
                           .ThenInclude(b => b.InverseParent)
                           .ThenInclude(c => c.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .OrderBy(v => v.SortNo)
                           select a
                    ).OrderBy(a => a.SortNo).ToListAsync();

                if (dbResult != null)
                {
                    result = dbResult;

                    foreach (var rowGroup in result)
                    {
                        rowGroup.SysMenu = OrderItems(rowGroup.SysMenu.ToList());
                    }
                }
            }

            return result;
        }

        private List<SysMenu> OrderItems(List<SysMenu> items)
        {
            List<SysMenu> result = items.OrderBy(a => a.SortNo).ToList();

            foreach (var item in result)
            {
                if (item.InverseParent.Count > 0)
                    item.InverseParent = OrderItems(item.InverseParent.ToList());
            }
            return result;
        }

        public async Task<List<RoleModel>> GetRoles()
        {
            List<RoleModel> result = new List<RoleModel>();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var dbResult = await (from a in context.SysRoles select a).ToListAsync();
                result = JsonConvert.DeserializeObject<List<RoleModel>>(JsonConvert.SerializeObject(dbResult));
            }

            return result;
        }

        private async Task<List<SysMenu>> GetMenuRecursiveAsync(List<Guid> menuGroupId)
        {
            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var rawSql = "WITH RECURSIVE subordinates AS ( SELECT m.* FROM sys_menu m LEFT JOIN sys_menu_group g ON m.menu_group_id = g.id WHERE {0} LIKE CONCAT('%',g.id,'%') UNION SELECT e.* FROM sys_menu e INNER JOIN subordinates s ON s.id = e.parent_id ) SELECT * FROM subordinates";
                var dbResult = await context.SysMenu.FromSqlRaw(rawSql, string.Join(",", menuGroupId)).ToListAsync();
                return dbResult;
            }
        }

        private static List<ChildMenuModel> GetMenuWithControllerName(Guid menuGroupId, List<SysMenu> sysMenus)
        {
            var menus = sysMenus.Where(w => w.MenuGroupId == menuGroupId);
            // Local recursive function
            IEnumerable<SysMenu> MenuHavingControllerName(string name, SysMenu sysMenu)
            {
                string displayName = string.IsNullOrEmpty(name) ? sysMenu.DisplayName : name + "/" + sysMenu.DisplayName;
                if (!string.IsNullOrWhiteSpace(sysMenu.ControllerName))
                {
                    sysMenu.DisplayName = displayName;
                    return new List<SysMenu>() { sysMenu };
                }
                else
                {
                    var child = sysMenus.Where(w => w.ParentId == sysMenu.Id);
                    return child.SelectMany(s => MenuHavingControllerName(displayName, s));
                }
            }
            // Start
            menus = menus.SelectMany(s => MenuHavingControllerName(null, s));
            return menus.Select(s => new ChildMenuModel
            {
                MenuId = s.Id,
                MenuName = s.DisplayName,
                ControllerName = s.ControllerName
            }).ToList();
        }

        public async Task<RoleModel> GetRole(Guid ID)
        {
            RoleModel result = new RoleModel();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var dbResult = await (
                    from a in context.SysRoles
                    select a)
                    .Where(a => a.Roleuuid == ID).FirstOrDefaultAsync();
                result = JsonConvert.DeserializeObject<RoleModel>(JsonConvert.SerializeObject(dbResult));

                var dbMap = await (
                    from a in context.SysRolesMenu
                    select a).Where(a => a.RoleUuid == ID).ToListAsync();

                var dbPermissionMap = await (
                    from a in context.SysRoleClaimPermission
                    select a).Where(a => a.RoleId == ID).ToListAsync();
                result.SysRolesPermissionMapping = await (
                    from a in context.SysRolePermission
                    select a).Where(a => a.RoleId == ID).Select(s => new PermissionMappingModel()
                    {
                        Id = s.Id,
                        IsGranted = s.IsGranted,
                        MenuId = s.MenuId,
                        Permission = s.Permission,
                        RoleId = s.RoleId
                    }).ToListAsync();
                result.SysRolesMenu = new List<RoleMenuModel>();
                result.SysRolesPermission = new List<RolePermissionModel>();

                if (dbPermissionMap != null)
                {
                    foreach (var item in dbPermissionMap)
                    {
                        result.SysRolesPermission.Add(new RolePermissionModel()
                        {
                            Id = item.Id,
                            PermissionId = item.PermissionId,
                            RoleId = item.RoleId,
                            MaxClaimAmount = item.MaxClaimAmount
                        });
                    }
                }

                if (dbMap != null)
                {
                    var menuGroupId = dbMap.Select(a => a.MenuGroupId).ToList();
                    var dbMenus = await GetMenuRecursiveAsync(menuGroupId);
                    foreach (var item in dbMap)
                    {
                        result.SysRolesMenu.Add(new RoleMenuModel()
                        {
                            id = item.Id,
                            menuGroupId = item.MenuGroupId,
                            roleUUID = item.RoleUuid,
                            Menus = GetMenuWithControllerName(item.MenuGroupId, dbMenus)
                        });
                    }
                }

                if (result != null)
                {
                    var dbMenu = await (
                        from a in context.SysMenuGroup
                        select a).ToListAsync();

                    if (dbMenu != null)
                    {
                        var menuGroupId = dbMenu.Select(a => a.Id).ToList();
                        var dbChildMenus = await GetMenuRecursiveAsync(menuGroupId);
                        foreach (var item in dbMenu)
                        {
                            var menuMap = result.SysRolesMenu.Find(a => a.menuGroupId == item.Id);

                            if (menuMap != null)
                            {
                                menuMap.groupName = item.GroupName;
                            }
                            else
                            {
                                result.SysRolesMenu.Add(new RoleMenuModel()
                                {
                                    groupName = item.GroupName,
                                    roleUUID = ID,
                                    menuGroupId = item.Id,
                                    id = Guid.Empty,
                                    Menus = GetMenuWithControllerName(item.Id, dbChildMenus)
                                });
                            }
                        }
                    }


                    var dbPermission = await (
                        from a in context.SysClaimPermission
                        select a).ToListAsync();

                    if (dbMenu != null)
                    {
                        foreach (var item in dbPermission)
                        {
                            var permissionMap = result.SysRolesPermission.Find(a => a.PermissionId == item.Id);

                            if (permissionMap != null)
                            {
                                permissionMap.PermissionName = item.Permission;
                                permissionMap.IsActive = true;
                            }
                            else
                            {
                                result.SysRolesPermission.Add(new RolePermissionModel()
                                {
                                    PermissionName = item.Permission,
                                    RoleId = ID,
                                    PermissionId = item.Id,
                                    Id = Guid.Empty
                                });
                            }
                        }
                    }
                }
            }

            return result;
        }

        public async Task<GenericResponse> CreateRole(RoleModel model)
        {
            GenericResponse result = new GenericResponse();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var dbResult = await
                    (from a in context.SysRoles
                     select a).Where(c => c.Role.ToLower() == model.Role.ToLower()).FirstOrDefaultAsync();

                if (dbResult != null)
                {
                    result.ErrorCode = 70001;
                    result.ErrorMessage = "Role record duplicated.";
                }
                else
                {
                    context.SysRoles.Add(
                        new SysRoles
                        {
                            Role = model.Role,
                            Roledesc = model.RoleDesc,
                            Versionno = 0,
                            Crby = model.Crby
                        });

                    await context.SaveChangesAsync();

                    result.ErrorCode = 0;
                    result.ErrorMessage = "Success";
                }
            }

            return result;
        }

        public async Task<GenericResponse> DeleteRole(Guid ID, Guid ModifiedBy)
        {
            GenericResponse result = new GenericResponse();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var dbResult = await
                    (from a in context.SysAdmin
                     select a).Where(a => a.Roleuuid == ID).FirstOrDefaultAsync();

                if (dbResult != null)
                {
                    result.ErrorCode = 80001;
                    result.ErrorMessage = "Role in used. Delete failed.";
                }
                else
                {
                    var dbRole = await
                    (from a in context.SysRoles
                     select a).Where(a => a.Roleuuid == ID).FirstOrDefaultAsync();

                    context.SysRoles.Remove(dbRole);
                    await context.SaveChangesAsync();

                    result.ErrorCode = 0;
                    result.ErrorMessage = "Success";
                }

            }

            return result;
        }

        public async Task<GenericResponse> EditRole(RoleModel model)
        {
            GenericResponse result = new GenericResponse();
            try
            {
                using (pgzeusContext context = new pgzeusContext(_options.Options))
                {
                    var dbResult = await
                        (from a in context.SysRoles
                         select a).Where(c => c.Role.ToLower() == model.Role.ToLower() && c.Roleuuid != model.RoleUUID).FirstOrDefaultAsync();

                    if (dbResult != null)
                    {
                        result.ErrorCode = 70001;
                        result.ErrorMessage = "Role record duplicated.";
                    }
                    else
                    {
                        var data = await
                        (from a in context.SysRoles
                         select a).Where(c => c.Roleuuid == model.RoleUUID).FirstOrDefaultAsync();

                        if (data != null)
                        {
                            data.Role = model.Role;
                            data.Roledesc = model.RoleDesc;
                            data.Upby = model.Upby;
                            data.Updt = DateTime.UtcNow;
                        }
                        await context.SaveChangesAsync();

                        var permisionMapData = await (
                            from a in context.SysRoleClaimPermission
                            select a)
                            .Where(a => a.RoleId == model.RoleUUID)
                            .ToListAsync();

                        if (model.SysRolesPermission != null)
                        {
                            if (permisionMapData != null && permisionMapData.Count > 0)
                            {
                                foreach (var item in model.SysRolesPermission)
                                {
                                    var rowMap = permisionMapData.Find(a => a.PermissionId == item.PermissionId);

                                    if (rowMap == null && item.Id != Guid.Empty)
                                    {
                                        context.SysRoleClaimPermission.Add(new SysRoleClaimPermission()
                                        {
                                            PermissionId = item.PermissionId,
                                            RoleId = model.RoleUUID,
                                            MaxClaimAmount = item.MaxClaimAmount,
                                        });
                                    }
                                    else if (rowMap != null && item.Id != Guid.Empty)
                                    {
                                        rowMap.MaxClaimAmount = item.MaxClaimAmount;
                                    }
                                    else if (item.Id == Guid.Empty && rowMap != null)
                                    {
                                        context.SysRoleClaimPermission.Remove(rowMap);
                                    }
                                }
                            }
                            else
                            {
                                foreach (var item in model.SysRolesPermission)
                                {
                                    if (item.Id != Guid.Empty)
                                    {
                                        context.SysRoleClaimPermission.Add(new SysRoleClaimPermission()
                                        {
                                            PermissionId = item.PermissionId,
                                            RoleId = model.RoleUUID,
                                            MaxClaimAmount = item.MaxClaimAmount,

                                        });
                                    }
                                }
                            }
                        }

                        // Add mapping role, permission, and menu
                        var entityRolePermissionToCreate = model.SysRolesPermissionMapping.Where(w => w.Id == null || w.Id == Guid.Empty).Select(s => new SysRolePermission
                        {
                            IsGranted = s.IsGranted,
                            MenuId = s.MenuId,
                            Id = Guid.NewGuid(),
                            Permission = s.Permission,
                            RoleId = s.RoleId
                        });

                        await context.SysRolePermission.AddRangeAsync(entityRolePermissionToCreate);

                        // Update mapping role, permission, and menu
                        var rolePermissionToUpdateIds = model.SysRolesPermissionMapping.Where(s => s.Id != null && s.Id != Guid.Empty).Select(s => s.Id);
                        var entityRolePermissionToUpdate = await context.SysRolePermission.Where(s => rolePermissionToUpdateIds.Contains(s.Id)).ToListAsync();
                        foreach (var entity in entityRolePermissionToUpdate)
                        {
                            var inputModel = model.SysRolesPermissionMapping.First(f => f.Id == entity.Id);
                            entity.IsGranted = inputModel.IsGranted;
                        }

                        context.SysRolePermission.UpdateRange(entityRolePermissionToUpdate);

                        await context.SaveChangesAsync();

                        var mapData = await (
                            from a in context.SysRolesMenu
                            select a)
                            .Where(a => a.RoleUuid == model.RoleUUID)
                            .ToListAsync();

                        if (mapData != null && mapData.Count > 0)
                        {
                            foreach (var item in model.SysRolesMenu)
                            {
                                var rowMap = mapData.Find(a => a.MenuGroupId == item.menuGroupId);

                                if (rowMap == null && item.id != Guid.Empty)
                                {
                                    context.SysRolesMenu.Add(new SysRolesMenu()
                                    {
                                        MenuGroupId = item.menuGroupId,
                                        RoleUuid = model.RoleUUID,
                                        CreatedBy = model.Upby.Value
                                    });
                                }
                                else if (item.id == Guid.Empty && rowMap != null)
                                {
                                    context.SysRolesMenu.Remove(rowMap);
                                }
                            }
                        }
                        else
                        {
                            foreach (var item in model.SysRolesMenu)
                            {
                                if (item.id != Guid.Empty)
                                {
                                    context.SysRolesMenu.Add(new SysRolesMenu()
                                    {
                                        MenuGroupId = item.menuGroupId,
                                        RoleUuid = model.RoleUUID,
                                        CreatedBy = model.Upby.Value
                                    });
                                }
                            }
                        }


                        await context.SaveChangesAsync();

                        result.ErrorCode = 0;
                        result.ErrorMessage = "Success";
                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public async Task<GenericResponse> SaveMenuGroupSort(List<MenuGroupModel> model)
        {
            GenericResponse result = new GenericResponse();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                foreach (var item in model)
                {
                    var dbResult = await (from a in context.SysMenuGroup select a).Where(a => a.Id == item.id).FirstOrDefaultAsync();

                    if (dbResult != null)
                    {
                        dbResult.SortNo = item.sortNo;
                        await context.SaveChangesAsync();
                    }
                }

                result.ErrorCode = 0;
                result.ErrorMessage = "Success";
            }

            return result;
        }

        public async Task<GenericResponse> DeleteMenuGroup(Guid ID, Guid ModifiedBy)
        {
            GenericResponse result = new GenericResponse();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var dbResult = await (from a in context.SysMenuGroup select a).Where(a => a.Id == ID).FirstOrDefaultAsync();

                if (dbResult != null)
                {
                    var dbRole = await (from a in context.SysRolesMenu select a).Where(a => a.MenuGroupId == ID).ToListAsync();
                    if (dbRole != null)
                        context.SysRolesMenu.RemoveRange(dbRole);

                    var dbMenu = await (from a in context.SysMenu select a).Where(a => a.MenuGroupId == ID).ToListAsync();
                    if (dbMenu != null)
                        context.SysMenu.RemoveRange(dbMenu);

                    context.SysMenuGroup.Remove(dbResult);
                    await context.SaveChangesAsync();
                }
                result.ErrorCode = 0;
                result.ErrorMessage = "Success";
            }

            return result;
        }

        public async Task<GenericResponse> CreateMenuGroup(MenuGroupModel model)
        {
            GenericResponse result = new GenericResponse();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                context.SysMenuGroup.Add(
                    new SysMenuGroup()
                    {
                        GroupName = model.groupName,
                        SortNo = 1000,
                        CreatedBy = model.createdBy
                    });

                await context.SaveChangesAsync();

                result.ErrorCode = 0;
                result.ErrorMessage = "Success";
            }

            return result;
        }

        public async Task<GenericResponse> EditMenuGroup(MenuGroupModel model)
        {
            GenericResponse result = new GenericResponse();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var dbResult = await (from a in context.SysMenuGroup select a).Where(a => a.Id == model.id).FirstOrDefaultAsync();

                if (dbResult != null)
                {
                    dbResult.GroupName = model.groupName;
                    dbResult.ModifiedBy = model.modifiedBy;
                    dbResult.ModifiedDate = DateTime.UtcNow;
                    dbResult.GroupClaims = model.groupClaims;

                    await context.SaveChangesAsync();
                }

                result.ErrorCode = 0;
                result.ErrorMessage = "Success";
            }

            return result;
        }

        public async Task<MenuGroupModel> GetMenuGroup(Guid ID)
        {
            MenuGroupModel model = new MenuGroupModel();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var dbResult = await (from a in context.SysMenuGroup select a).Where(a => a.Id == ID).FirstOrDefaultAsync();

                if (dbResult != null)
                {
                    dbResult.SysMenu = OrderItems(dbResult.SysMenu.ToList());
                    model = JsonConvert.DeserializeObject<MenuGroupModel>(JsonConvert.SerializeObject(dbResult));
                }

            }

            return model;
        }

        public async Task<SysMenuGroup> GetMenuByGroup(Guid MenuGroupID)
        {
            SysMenuGroup model = new SysMenuGroup();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                model =
                    await (from a in context.SysMenuGroup
                           .Include(x => x.SysMenu)
                           .ThenInclude(b => b.InverseParent)
                           .ThenInclude(c => c.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .ThenInclude(d => d.InverseParent)
                           .OrderBy(v => v.SortNo)
                           select a
                    ).Where(a => a.Id == MenuGroupID)
                    .OrderBy(a => a.SortNo).FirstOrDefaultAsync();

                if (model != null)
                {
                    model.SysMenu = OrderItems(model.SysMenu.ToList());
                }
            }

            return model;
        }

        public async Task<SysMenu> GetMenu(Guid ID)
        {
            SysMenu model = new SysMenu();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                model =
                    await (from a in context.SysMenu select a
                    ).Where(a => a.Id == ID)
                    .FirstOrDefaultAsync();
            }

            return model;
        }

        public async Task<GenericResponse> CreateMenu(MenuModel model)
        {
            GenericResponse result = new GenericResponse();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    var newSysMenu = new SysMenu
                    {
                        DisplayName = model.displayName,
                        ControllerName = model.controllerName,
                        ControllerAction = model.controllerAction,
                        CreatedBy = model.createdBy,
                        ParentId = model.parentId == Guid.Empty ? null : model.parentId,
                        SortNo = 1000,
                        MenuGroupId = model.menuGroupId == Guid.Empty ? null : model.menuGroupId
                    };
                    context.SysMenu.Add(newSysMenu);
                    await context.SaveChangesAsync();

                    var roleList = await context.SysRoles.ToListAsync();
                    var rolePermissionList = new List<SysRolePermission>();
                    foreach (var role in roleList)
                    {
                        rolePermissionList.AddRange(new List<SysRolePermission>(){
                    new SysRolePermission {
                        RoleId = role.Roleuuid,
                        IsGranted = false,
                        MenuId = newSysMenu.Id,
                        Permission = "Create"
                    },
                    new SysRolePermission {
                        RoleId = role.Roleuuid,
                        IsGranted = false,
                        MenuId = newSysMenu.Id,
                        Permission = "Read"
                    },
                    new SysRolePermission {
                        RoleId = role.Roleuuid,
                        IsGranted = false,
                        MenuId = newSysMenu.Id,
                        Permission = "Delete"
                    },
                    new SysRolePermission {
                        RoleId = role.Roleuuid,
                        IsGranted = false,
                        MenuId = newSysMenu.Id,
                        Permission = "Update"
                    },
                  });
                    };

                    context.SysRolePermission.AddRange(rolePermissionList);
                    await context.SaveChangesAsync();
                    transaction.Commit();
                    result.ErrorCode = 0;
                    result.ErrorMessage = "Success";
                }
            }

            return result;
        }

        public async Task<GenericResponse> EditMenu(MenuModel model)
        {
            GenericResponse result = new GenericResponse();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var dbResult = await
                    (from a in context.SysMenu
                     select a).Where(c => c.Id == model.id).FirstOrDefaultAsync();

                if (dbResult != null)
                {
                    //dbResult.ParentId = model.parentId;
                    dbResult.DisplayName = model.displayName;
                    dbResult.ControllerAction = model.controllerAction;
                    dbResult.ControllerName = model.controllerName;
                    //dbResult.SortNo = model.sortNo;

                    await context.SaveChangesAsync();

                    result.ErrorCode = 0;
                    result.ErrorMessage = "Success";
                }
            }

            return result;
        }

        public async Task<GenericResponse> UpdateMenuSort(List<MenuModel> model)
        {
            GenericResponse result = new GenericResponse();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                foreach (var item in model)
                {
                    var dbResult = await
                    (from a in context.SysMenu
                     select a).Where(c => c.Id == item.id).FirstOrDefaultAsync();

                    if (dbResult != null)
                    {
                        dbResult.ParentId = item.parentId == Guid.Empty ? null : item.parentId;
                        dbResult.SortNo = item.sortNo;
                        dbResult.ModifiedDate = DateTime.UtcNow;

                        if (dbResult.ParentId == null)
                            dbResult.MenuGroupId = item.menuGroupId;
                        else
                            dbResult.MenuGroupId = null;

                        await context.SaveChangesAsync();

                        result.ErrorCode = 0;
                        result.ErrorMessage = "Success";
                    }
                }
            }

            return result;
        }

        public async Task<GenericResponse> DeleteMenu(Guid ID, Guid ModifiedBy)
        {
            GenericResponse result = new GenericResponse();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var dbResult = await
                    (from a in context.SysMenu
                     select a).Where(a => a.ParentId == ID).FirstOrDefaultAsync();

                if (dbResult != null)
                {
                    result.ErrorCode = 80001;
                    result.ErrorMessage = "Menu in used. Delete failed.";
                }
                else
                {
                    var dbMenu = await
                    (from a in context.SysMenu
                     select a).Where(a => a.Id == ID).FirstOrDefaultAsync();

                    context.SysMenu.Remove(dbMenu);
                    await context.SaveChangesAsync();

                    result.ErrorCode = 0;
                    result.ErrorMessage = "Success";
                }

            }

            return result;
        }

        public async Task<List<RolePermissionModel>> GetUserPermissions(Guid userId)
        {
            var result = new List<RolePermissionModel>();

            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                result = await
                    (from users in context.SysAdmin
                     join rolePermissions in context.SysRoleClaimPermission on users.Roleuuid equals rolePermissions.RoleId
                     join permissions in context.SysClaimPermission on rolePermissions.PermissionId equals permissions.Id
                     where users.Adminuuid == userId
                     select new RolePermissionModel
                     {
                         Id = rolePermissions.Id,
                         RoleId = rolePermissions.RoleId,
                         IsActive = true,
                         PermissionId = rolePermissions.PermissionId,
                         PermissionCode = permissions.Code,
                         PermissionName = permissions.Permission,
                         MaxClaimAmount = rolePermissions.MaxClaimAmount,
                         ClaimStatusValue = permissions.ClaimStatusValue

                     }).ToListAsync();

            }
            return result;
        }

        public async Task<List<RoleControllerPermissionModel>> GetRoleControllerPermissionByUserId(Guid userID)
        {
            var result = new List<RoleControllerPermissionModel>();
            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var userRoleId = await
                    (from users in context.SysAdmin
                     where users.Adminuuid == userID
                     select new
                     {
                         RoleId = users.Roleuuid

                     }).FirstOrDefaultAsync();

                result = await (from menus in context.SysMenu
                                join rolepermissions in context.SysRolePermission on menus.Id equals rolepermissions.MenuId
                                where rolepermissions.RoleId == userRoleId.RoleId && rolepermissions.IsGranted == true
                                select new RoleControllerPermissionModel
                                {
                                    ControllerName = menus.ControllerName,
                                    Permission = rolepermissions.Permission,
                                    PageName = menus.DisplayName
                                }).ToListAsync();
            }
            return result;
        }

        public async Task<bool> UnlockUserAsync(Guid userId, Guid actionUserId)
        {
            try
            {
                using pgzeusContext context = new pgzeusContext(_options.Options);
                var user = await context.SysAdmin
                    .SingleAsync(x => x.Adminuuid == userId
                        && x.Lockedstatus == 1);

                user.Lockedstatus = 0;
                user.Retrycount = 0;
                user.Upby = actionUserId;
                user.Updt = DateTime.UtcNow;

                await context.SysAdminUnlockHistory.AddAsync(new SysAdminUnlockHistory
                {
                    Userid = userId,
                    CreatedBy = actionUserId,
                    CreatedDate = DateTime.UtcNow
                });

                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private async Task<List<string>> GetPreviousNthPasswords(Guid userId)
        {
            using pgzeusContext context = new pgzeusContext(_options.Options);

            return await context.SysAdminPasswordHistory
                .AsNoTracking()
                .Where(x => x.Userid == userId)
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => x.Password)
                .Take(_passwordSetting.EnforcePasswordHistory)
                .ToListAsync();
        }
    }
}