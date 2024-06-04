using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanClaimBenefitRates
    {
        public Guid Id { get; set; }
        public string BenefitRateName { get; set; }
        public string BenefitRateDesc { get; set; }
        public string CurrencyCode { get; set; }
        public decimal RateAmount { get; set; }
        public bool IsFixedAmount { get; set; }
        public bool IsBasedOnSuminsured { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Guid PlanClaimBenefitId { get; set; }
    }
}
