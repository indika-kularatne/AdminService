using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysRoleClaimPermission
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid PermissionId { get; set; }
        public double MaxClaimAmount { get; set; }
    }
}
