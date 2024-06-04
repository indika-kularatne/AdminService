using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Models
{
    public class RoleModel
    {
        public Guid RoleUUID { get; set; }

        public string Role { get; set; }

        public string RoleDesc { get; set; }

        public Guid Crby { get; set; }

        public DateTime Crdt { get; set; }

        public Guid? Upby { get; set; }

        public DateTime? Updt { get; set; }

        public List<RoleMenuModel> SysRolesMenu { get; set; }
        public List<RolePermissionModel> SysRolesPermission { get; set; }
        public List<PermissionMappingModel> SysRolesPermissionMapping { get; set;}
    }

    public class RoleMenuModel
    {
        public Guid id { get; set; }

        public Guid menuGroupId { get; set; }

        public string groupName { get; set; }

        public Guid roleUUID { get; set; }

        public DateTime createdDate { get; set; }
        public List<ChildMenuModel> Menus { get; set; }
    }
    public class ChildMenuModel
    {
        public Guid MenuId { get; set; }
        public string MenuName { get; set; }
        public string ControllerName { get; set; }

    }
    public class RolePermissionModel
    {
        public Guid Id { get; set; }
        public string PermissionCode { get; set; }
        public string PermissionName { get; set; }
        public Guid RoleId { get; set; }
        public Guid PermissionId { get; set; }
        public bool IsActive { get; set; }
        public double MaxClaimAmount { get; set; }
        public int ClaimStatusValue { get; set; }

    }

    public class PermissionMappingModel
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid MenuId { get; set; }
        public string Permission { get; set; }
        public bool IsGranted { get; set; }
    }

    public class RoleControllerPermissionModel
	{
        public string ControllerName { get; set; }
        public string Permission { get; set; }
        public string PageName { get; set; }
    }
}
