using AdminService.DBContext;
using System;

namespace AdminService.Models.PermissionModel.Request
{
    public class CreatePermissionModel
    {
        public Guid RoleId { get; set; }
        public Guid MenuId { get; set; }
        public string Permission { get; set; }
        public SysRolePermission ToEntity()
        {
            return new SysRolePermission
            {
                RoleId = RoleId,
                MenuId = MenuId,
                Permission = Permission,
                IsGranted = true
            };
        }
    }
}
