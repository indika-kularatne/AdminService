using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysAgents
    {
        public SysAgents()
        {
            SysAgentsFunctionsWs = new HashSet<SysAgentsFunctionsWs>();
            SysAgentsIpaddresses = new HashSet<SysAgentsIpaddresses>();
            SysAgentsPlans = new HashSet<SysAgentsPlans>();
            SysAgentsPseudos = new HashSet<SysAgentsPseudos>();
            SysAgentsVirtualsettings = new HashSet<SysAgentsVirtualsettings>();
        }

        public Guid Agentuuid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Channelcode { get; set; }
        public string Pseudoagentcode { get; set; }
        public string Pseudocitycode { get; set; }
        public int? Agentstatus { get; set; }
        public DateTime? Efffromdate { get; set; }
        public DateTime? Efftodate { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public string Agentlogo { get; set; }
        public Guid? Gatewayaccountuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysGatewayAccount Gatewayaccountuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<SysAgentsFunctionsWs> SysAgentsFunctionsWs { get; set; }
        public virtual ICollection<SysAgentsIpaddresses> SysAgentsIpaddresses { get; set; }
        public virtual ICollection<SysAgentsPlans> SysAgentsPlans { get; set; }
        public virtual ICollection<SysAgentsPseudos> SysAgentsPseudos { get; set; }
        public virtual ICollection<SysAgentsVirtualsettings> SysAgentsVirtualsettings { get; set; }
    }
}
