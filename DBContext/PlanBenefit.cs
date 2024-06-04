using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefit
    {
        public PlanBenefit()
        {
            ClaimMessageMap = new HashSet<ClaimMessageMap>();
            PlanBenefitConfig = new HashSet<PlanBenefitConfig>();
            PlanBenefitCustomInputTemplateMap = new HashSet<PlanBenefitCustomInputTemplateMap>();
            PlanBenefitGroupMap = new HashSet<PlanBenefitGroupMap>();
            PlanBenefitRate = new HashSet<PlanBenefitRate>();
            PlanBenefitSupportingDocumentsMap = new HashSet<PlanBenefitSupportingDocumentsMap>();
            PlanBenefitTranslation = new HashSet<PlanBenefitTranslation>();
        }

        public Guid Id { get; set; }
        public string CurrencyCode { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string Description { get; set; }
        public short StatusId { get; set; }
        public int Category { get; set; }
        public string Code { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public decimal MaxSumInsured { get; set; }
        public short? SumInsuredRelation { get; set; }
        public int? GracePeriod { get; set; }
        public string Claimtpasetting { get; set; }
        public bool? IsAmountorpercentage { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? MinPercentage { get; set; }
        public decimal? MaxPercentage { get; set; }

        public virtual ICollection<ClaimMessageMap> ClaimMessageMap { get; set; }
        public virtual ICollection<PlanBenefitConfig> PlanBenefitConfig { get; set; }
        public virtual ICollection<PlanBenefitCustomInputTemplateMap> PlanBenefitCustomInputTemplateMap { get; set; }
        public virtual ICollection<PlanBenefitGroupMap> PlanBenefitGroupMap { get; set; }
        public virtual ICollection<PlanBenefitRate> PlanBenefitRate { get; set; }
        public virtual ICollection<PlanBenefitSupportingDocumentsMap> PlanBenefitSupportingDocumentsMap { get; set; }
        public virtual ICollection<PlanBenefitTranslation> PlanBenefitTranslation { get; set; }
    }
}
