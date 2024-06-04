using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanClaimBenefit
    {
        public Guid Id { get; set; }
        public string BenefitName { get; set; }
        public string BenefitDescription { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CoverageAmount { get; set; }
        public bool IsMedical { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public decimal CoverageAmountMin { get; set; }
        public string BenefitCode { get; set; }
        public bool IsBasedOnSuminsured { get; set; }
        public decimal MultiplierSuminsured { get; set; }
        public int ClaimCountMax { get; set; }
        public string PayoutType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Weightage { get; set; }
    }
}
