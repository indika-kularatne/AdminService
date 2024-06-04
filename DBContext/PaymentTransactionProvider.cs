using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PaymentTransactionProvider
    {
        public Guid Id { get; set; }
        public Guid PaymentProviderId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string TransactionReference { get; set; }
        public Guid? PolicyId { get; set; }
        public Guid? PaymentRecurringId { get; set; }

        public virtual PaymentProviders PaymentProvider { get; set; }
        public virtual Policy Policy { get; set; }
    }
}
