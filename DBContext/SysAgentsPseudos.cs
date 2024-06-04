using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysAgentsPseudos
    {
        public Guid Agentuuid { get; set; }
        public string Pseudoagentcode { get; set; }
        public string Pseudocitycode { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid Agentpseudouuid { get; set; }

        public virtual SysAgents Agentuu { get; set; }
        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
