using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysAccessRights
    {
        public int? Arview { get; set; }
        public int? Arlist { get; set; }
        public int? Aradd { get; set; }
        public int? Arupdate { get; set; }
        public int? Ardelete { get; set; }
        public Guid Crby { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Aruuid { get; set; }
        public Guid? Roleuuid { get; set; }
        public Guid? Functionuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysRoles Functionuu { get; set; }
        public virtual SysRoles Roleuu { get; set; }
    }
}
