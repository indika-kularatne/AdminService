using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysAgentsIpaddresses
    {
        public Guid Agentuuid { get; set; }
        public string Ipaddress { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public Guid Agentipuuid { get; set; }

        public virtual SysAgents Agentuu { get; set; }
        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
