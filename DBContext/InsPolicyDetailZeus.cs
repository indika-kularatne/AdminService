using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPolicyDetailZeus
    {
        public InsPolicyDetailZeus()
        {
            AuditPolicyCancellations = new HashSet<AuditPolicyCancellations>();
            AuditPolicyRefund = new HashSet<AuditPolicyRefund>();
            InsPolicyContactPersonZeus = new HashSet<InsPolicyContactPersonZeus>();
            InsPolicyCoveragePersonZeus = new HashSet<InsPolicyCoveragePersonZeus>();
            InsPolicyDetailActionsZeus = new HashSet<InsPolicyDetailActionsZeus>();
            InsPolicyUnsentZeus = new HashSet<InsPolicyUnsentZeus>();
        }

        public string Pnr { get; set; }
        public string Channel { get; set; }
        public string Pseudoagentcode { get; set; }
        public string Pseudocitycode { get; set; }
        public string Countrycode { get; set; }
        public string Culturecode { get; set; }
        public DateTime? Transactiondate { get; set; }
        public string Policyno { get; set; }
        public int? Itinerarystate { get; set; }
        public string Plancode { get; set; }
        public string Aafeecode { get; set; }
        public string Currencycode { get; set; }
        public decimal? Totalpremiumamount { get; set; }
        public int? Totalpaxes { get; set; }
        public int? Totalinfants { get; set; }
        public int? Totalchild { get; set; }
        public int? Totaladults { get; set; }
        public DateTime Crdt { get; set; }
        public string Departurecountrycode { get; set; }
        public string Departurestationcode { get; set; }
        public string Arrivalcountrycode { get; set; }
        public string Arrivalstationcode { get; set; }
        public string Departureairlinecode { get; set; }
        public string Departureflightno { get; set; }
        public DateTime? Departuredatetime { get; set; }
        public string Returnairlinecode { get; set; }
        public string Returnflightno { get; set; }
        public DateTime? Returndatetime { get; set; }
        public int? Tripdurationdays { get; set; }
        public int? Isflightconnecting { get; set; }
        public int? Isflight1way { get; set; }
        public int? Isflight2way { get; set; }
        public Guid Crby { get; set; }
        public Guid Policydetailuuid { get; set; }
        public Guid? Planuuid { get; set; }
        public Guid? Underwriteruuid { get; set; }

        public virtual InsPlans Planuu { get; set; }
        public virtual InsUnderwriters Underwriteruu { get; set; }
        public virtual ICollection<AuditPolicyCancellations> AuditPolicyCancellations { get; set; }
        public virtual ICollection<AuditPolicyRefund> AuditPolicyRefund { get; set; }
        public virtual ICollection<InsPolicyContactPersonZeus> InsPolicyContactPersonZeus { get; set; }
        public virtual ICollection<InsPolicyCoveragePersonZeus> InsPolicyCoveragePersonZeus { get; set; }
        public virtual ICollection<InsPolicyDetailActionsZeus> InsPolicyDetailActionsZeus { get; set; }
        public virtual ICollection<InsPolicyUnsentZeus> InsPolicyUnsentZeus { get; set; }
    }
}
