using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitRate
    {
        public Guid Id { get; set; }
        public Guid PlanBenefitId { get; set; }
        public short LimitType { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual PlanBenefit PlanBenefit { get; set; }
    }
}
