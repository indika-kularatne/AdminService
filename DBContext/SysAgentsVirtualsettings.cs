using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysAgentsVirtualsettings
    {
        public Guid Agentuuid { get; set; }
        public string Vsname { get; set; }
        public string Vsvalue { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid Agentvsuuid { get; set; }
        public Guid? Vsuuid { get; set; }

        public virtual SysAgents Agentuu { get; set; }
        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual SysVirtualsetting Vsuu { get; set; }
    }
}
