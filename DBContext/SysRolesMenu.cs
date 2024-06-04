using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysRolesMenu
    {
        public Guid Id { get; set; }
        public Guid MenuGroupId { get; set; }
        public Guid RoleUuid { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }

        public virtual SysMenuGroup MenuGroup { get; set; }
        public virtual SysRoles RoleUu { get; set; }
    }
}
