using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysVirtualsetting
    {
        public SysVirtualsetting()
        {
            SysAgentsVirtualsettings = new HashSet<SysAgentsVirtualsettings>();
        }

        public Guid Crby { get; set; }
        public DateTime Crdt { get; set; }
        public Guid? Upby { get; set; }
        public Guid Vsuuid { get; set; }
        public string Vsname { get; set; }
        public DateTime? Updt { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual ICollection<SysAgentsVirtualsettings> SysAgentsVirtualsettings { get; set; }
    }
}
