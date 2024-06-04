using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitConfig
    {
        public Guid Id { get; set; }
        public Guid PlanBenefitId { get; set; }
        public short LimitTypeId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Amount { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? MaxAmount { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual PlanBenefit PlanBenefit { get; set; }
    }
}
