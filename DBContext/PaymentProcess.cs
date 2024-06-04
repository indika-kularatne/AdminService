using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PaymentProcess
    {
        public PaymentProcess()
        {
            PaymentProcessItem = new HashSet<PaymentProcessItem>();
        }

        public Guid Id { get; set; }
        public Guid PaymentProviderId { get; set; }
        public string TransactionType { get; set; }
        public string GatewayUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public string Channel { get; set; }
        public bool? IsPost { get; set; }

        public virtual PaymentProviders PaymentProvider { get; set; }
        public virtual ICollection<PaymentProcessItem> PaymentProcessItem { get; set; }
    }
}
