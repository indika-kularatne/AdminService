using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyPaymentToken
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public Guid PaymentProviderId { get; set; }
        public string TokenId { get; set; }
        public DateTime CreateDate { get; set; }
        public short StatusId { get; set; }
        public Guid PaymentOptionId { get; set; }
        public string PaymentTransactionRef { get; set; }
        public string PaymentBankApprovalCode { get; set; }

        public virtual PaymentOptions PaymentOption { get; set; }
        public virtual PaymentProviders PaymentProvider { get; set; }
        public virtual Policy Policy { get; set; }
    }
}
