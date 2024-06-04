using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysMenuGroup
    {
        public SysMenuGroup()
        {
            SysMenu = new HashSet<SysMenu>();
            SysRolesMenu = new HashSet<SysRolesMenu>();
        }

        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public short SortNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public string GroupClaims { get; set; }

        public virtual ICollection<SysMenu> SysMenu { get; set; }
        public virtual ICollection<SysRolesMenu> SysRolesMenu { get; set; }
    }
}
