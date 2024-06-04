using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitGroup
    {
        public PlanBenefitGroup()
        {
            PlanBenefitGroupConfig = new HashSet<PlanBenefitGroupConfig>();
            PlanBenefitGroupMap = new HashSet<PlanBenefitGroupMap>();
            PlanBenefitMap = new HashSet<PlanBenefitMap>();
        }

        public Guid Id { get; set; }
        public short PlanClaimTypeId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PlanClaimGroupName { get; set; }
        public string PlanClaimGroupDesc { get; set; }
        public short StatusId { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public Guid? ClaimCode { get; set; }
        public decimal MaxSumInsured { get; set; }
        public string CurrencyCode { get; set; }
        public short? SumInsuredRelation { get; set; }

        public virtual ICollection<PlanBenefitGroupConfig> PlanBenefitGroupConfig { get; set; }
        public virtual ICollection<PlanBenefitGroupMap> PlanBenefitGroupMap { get; set; }
        public virtual ICollection<PlanBenefitMap> PlanBenefitMap { get; set; }
    }
}
