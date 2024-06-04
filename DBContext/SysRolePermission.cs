using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysRolePermission
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid MenuId { get; set; }
        public string Permission { get; set; }
        public bool IsGranted { get; set; }

        public virtual SysMenu Menu { get; set; }
    }
}
