using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysAgentsFunctionsWs
    {
        public Guid Agentuuid { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public Guid Functionwsuuid { get; set; }
        public Guid Afwsuuid { get; set; }

        public virtual SysAgents Agentuu { get; set; }
        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysFunctionsWs Functionwsuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
