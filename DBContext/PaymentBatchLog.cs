using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PaymentBatchLog
    {
        public PaymentBatchLog()
        {
            PolicyPaymentStatus = new HashSet<PolicyPaymentStatus>();
        }

        public Guid Id { get; set; }
        public string Prefix { get; set; }
        public string Filename { get; set; }
        public DateTime CreatedDate { get; set; }
        public int StatusId { get; set; }
        public short? PreOutStatus { get; set; }
        public short? PostOutStatus { get; set; }
        public Guid? PaymentOptionId { get; set; }
        public Guid? PaymentProviderId { get; set; }

        public virtual ICollection<PolicyPaymentStatus> PolicyPaymentStatus { get; set; }
    }
}
