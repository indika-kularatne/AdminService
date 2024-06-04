using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitCustomInputTemplateMap
    {
        public Guid Id { get; set; }
        public Guid PlanBenefitId { get; set; }
        public Guid PlanBenefitCustomInputTemplateId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public TimeSpan? UpdatedDate { get; set; }

        public virtual PlanBenefit PlanBenefit { get; set; }
        public virtual PlanBenefitCustomInputTemplate PlanBenefitCustomInputTemplate { get; set; }
    }
}
