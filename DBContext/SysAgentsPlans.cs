using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysAgentsPlans
    {
        public Guid Agentuuid { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public Guid Agentplanuuid { get; set; }
        public Guid? Planuuid { get; set; }

        public virtual SysAgents Agentuu { get; set; }
        public virtual SysAdmin CrbyNavigation { get; set; }
    }
}
