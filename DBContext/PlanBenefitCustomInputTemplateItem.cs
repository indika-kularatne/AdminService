using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitCustomInputTemplateItem
    {
        public Guid Id { get; set; }
        public Guid PlanBenefitCustomInputTemplateId { get; set; }
        public Guid PlanBenefitCustomInputId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanBenefitCustomInput PlanBenefitCustomInput { get; set; }
        public virtual PlanBenefitCustomInputTemplate PlanBenefitCustomInputTemplate { get; set; }
    }
}
