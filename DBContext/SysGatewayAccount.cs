using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysGatewayAccount
    {
        public SysGatewayAccount()
        {
            SysAgents = new HashSet<SysAgents>();
        }

        public Guid Gatewayaccountuuid { get; set; }
        public string Gatewayusername { get; set; }
        public Guid Crby { get; set; }
        public DateTime Crdt { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Orguuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysOrganizations Orguu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<SysAgents> SysAgents { get; set; }
    }
}
