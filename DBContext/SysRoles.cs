using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysRoles
    {
        public SysRoles()
        {
            SysAccessRightsFunctionuu = new HashSet<SysAccessRights>();
            SysAccessRightsRoleuu = new HashSet<SysAccessRights>();
            SysAdmin = new HashSet<SysAdmin>();
            SysRolesMenu = new HashSet<SysRolesMenu>();
        }

        public string Role { get; set; }
        public string Roledesc { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public int? Versionno { get; set; }
        public Guid Crby { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Roleuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<SysAccessRights> SysAccessRightsFunctionuu { get; set; }
        public virtual ICollection<SysAccessRights> SysAccessRightsRoleuu { get; set; }
        public virtual ICollection<SysAdmin> SysAdmin { get; set; }
        public virtual ICollection<SysRolesMenu> SysRolesMenu { get; set; }
    }
}
