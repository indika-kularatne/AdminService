using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PaymentOptions
    {
        public PaymentOptions()
        {
            PlanSettingPaymentOptions = new HashSet<PlanSettingPaymentOptions>();
            PolicyPaymentStatus = new HashSet<PolicyPaymentStatus>();
            PolicyPaymentToken = new HashSet<PolicyPaymentToken>();
        }

        public Guid Id { get; set; }
        public string PayoptionCode { get; set; }
        public string PayoptionName { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<PlanSettingPaymentOptions> PlanSettingPaymentOptions { get; set; }
        public virtual ICollection<PolicyPaymentStatus> PolicyPaymentStatus { get; set; }
        public virtual ICollection<PolicyPaymentToken> PolicyPaymentToken { get; set; }
    }
}
