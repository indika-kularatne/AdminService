using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyPaymentProjection
    {
        public PolicyPaymentProjection()
        {
            PolicyJournal = new HashSet<PolicyJournal>();
            PolicyPaymentStatus = new HashSet<PolicyPaymentStatus>();
        }

        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public string PremiumPlan { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Policy Policy { get; set; }
        public virtual ICollection<PolicyJournal> PolicyJournal { get; set; }
        public virtual ICollection<PolicyPaymentStatus> PolicyPaymentStatus { get; set; }
    }
}
