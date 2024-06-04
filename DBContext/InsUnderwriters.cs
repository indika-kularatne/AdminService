using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsUnderwriters
    {
        public InsUnderwriters()
        {
            InsPartnerKeys = new HashSet<InsPartnerKeys>();
            InsPlans = new HashSet<InsPlans>();
            InsPolicyDetailZeus = new HashSet<InsPolicyDetailZeus>();
            InsPolicySerialRange = new HashSet<InsPolicySerialRange>();
            InsUnderwritersReports = new HashSet<InsUnderwritersReports>();
            PolicyCompanyWitness = new HashSet<PolicyCompanyWitness>();
            ReinsuranceCommission = new HashSet<ReinsuranceCommission>();
            SysUsersUnderwriters = new HashSet<SysUsersUnderwriters>();
        }

        public string Underwritercode { get; set; }
        public string Underwriterdesc { get; set; }
        public string Countrycode { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public string Underwriterlogo { get; set; }
        public Guid Underwriteruuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<InsPartnerKeys> InsPartnerKeys { get; set; }
        public virtual ICollection<InsPlans> InsPlans { get; set; }
        public virtual ICollection<InsPolicyDetailZeus> InsPolicyDetailZeus { get; set; }
        public virtual ICollection<InsPolicySerialRange> InsPolicySerialRange { get; set; }
        public virtual ICollection<InsUnderwritersReports> InsUnderwritersReports { get; set; }
        public virtual ICollection<PolicyCompanyWitness> PolicyCompanyWitness { get; set; }
        public virtual ICollection<ReinsuranceCommission> ReinsuranceCommission { get; set; }
        public virtual ICollection<SysUsersUnderwriters> SysUsersUnderwriters { get; set; }
    }
}
