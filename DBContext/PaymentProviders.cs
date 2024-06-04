using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PaymentProviders
    {
        public PaymentProviders()
        {
            PaymentProcess = new HashSet<PaymentProcess>();
            PaymentTransactionProvider = new HashSet<PaymentTransactionProvider>();
            PlanSettingPaymentOptions = new HashSet<PlanSettingPaymentOptions>();
            PolicyPaymentStatus = new HashSet<PolicyPaymentStatus>();
            PolicyPaymentToken = new HashSet<PolicyPaymentToken>();
        }

        public Guid Id { get; set; }
        public string PayproviderCode { get; set; }
        public string PayproviderName { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<PaymentProcess> PaymentProcess { get; set; }
        public virtual ICollection<PaymentTransactionProvider> PaymentTransactionProvider { get; set; }
        public virtual ICollection<PlanSettingPaymentOptions> PlanSettingPaymentOptions { get; set; }
        public virtual ICollection<PolicyPaymentStatus> PolicyPaymentStatus { get; set; }
        public virtual ICollection<PolicyPaymentToken> PolicyPaymentToken { get; set; }
    }
}
