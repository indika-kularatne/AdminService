using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSettingPaymentOptions
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public decimal? MinMonthlyPremiumAmount { get; set; }
        public decimal? MaxMonthlyPremiumAmount { get; set; }
        public Guid PayoptionId { get; set; }
        public Guid PayproviderId { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int? TokenTypeId { get; set; }
        public string TokenJson { get; set; }

        public virtual PaymentOptions Payoption { get; set; }
        public virtual PaymentProviders Payprovider { get; set; }
        public virtual PlanSetting Plan { get; set; }
    }
}
