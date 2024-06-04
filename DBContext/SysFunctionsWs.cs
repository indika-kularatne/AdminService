using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysFunctionsWs
    {
        public SysFunctionsWs()
        {
            SysAgentsFunctionsWs = new HashSet<SysAgentsFunctionsWs>();
        }

        public string Functiontitle { get; set; }
        public string Functiondesc { get; set; }
        public string Functionlink { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid Functionwsuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual ICollection<SysAgentsFunctionsWs> SysAgentsFunctionsWs { get; set; }
    }
}
