using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyJournal
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public short StatusId { get; set; }
        public decimal PremiumAmount { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? PaymentProjectionId { get; set; }
        public string ReferenceRemark { get; set; }
        public string PremiumBreakdown { get; set; }

        public virtual PolicyPaymentProjection PaymentProjection { get; set; }
        public virtual Policy Policy { get; set; }
    }
}
