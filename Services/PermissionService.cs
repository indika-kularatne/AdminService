using AdminService.DBContext;
using AdminService.Models.PermissionModel.Request;
using AdminService.Models.PermissionModel.Response;
using AdminService.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Services
{
    public class PermissionService : BaseService, IPermissionService
    {
        public PermissionService(IConfiguration configuration, IWebHostEnvironment env) :
            base(configuration, "", env)
        { }

        public async Task<bool> CreateAsync(IList<CreatePermissionModel> model)
        {
            try
            {
                using (pgzeusContext context = new pgzeusContext(_options.Options))
                {
                    var entities = model.Select(x => x.ToEntity());

                    await context.SysRolePermission.AddRangeAsync(entities);
                    await context.SaveChangesAsync();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<IList<RolePermissionResponseModel>> GetListPermissionByRoleIdAsync(Guid roleId)
        {
            using (pgzeusContext context = new pgzeusContext(_options.Options))
            {
                var results = await context.SysRolePermission.Where(x => x.RoleId == roleId && x.IsGranted).Select(s => new RolePermissionResponseModel()
                {
                    RoleId = roleId,
                    IsGranted = s.IsGranted,
                    Id = s.Id,
                    MenuId = s.MenuId,
                    Permission = s.Permission

                }).ToListAsync();

                return results;
            }
        }
        public async Task<bool> UpdateRolePermissionsAsync(IList<UpdateRolePermissionModel> models)
        {
            try
            {
                using (pgzeusContext context = new pgzeusContext(_options.Options))
                {
                    var ids = models.Select(x => x.Id).ToList();
                    var entities = await context.SysRolePermission.Where(x => ids.Contains(x.Id)).ToListAsync();

                    foreach (var entity in entities)
                    {
                        var model = models.First(x => x.Id == entity.Id);
                        entity.Permission = model.Permission;
                    }
                    context.SysRolePermission.UpdateRange(entities);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteRolePermissionAsync(Guid id)
        {
            try
            {
                using (pgzeusContext context = new pgzeusContext(_options.Options))
                {
                    var entity = await context.SysRolePermission.FirstOrDefaultAsync(s => s.Id == id);
                    context.SysRolePermission.Remove(entity);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
