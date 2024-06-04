using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class AuditPolicyCancellations
    {
        public string Policyno { get; set; }
        public string Pnr { get; set; }
        public int? Processedflag { get; set; }
        public DateTime? Processeddt { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Auditpolicycanceluuid { get; set; }
        public Guid? Policydetailuuid { get; set; }

        public virtual InsPolicyDetailZeus Policydetailuu { get; set; }
    }
}
