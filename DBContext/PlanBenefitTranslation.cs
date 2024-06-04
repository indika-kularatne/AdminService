using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitTranslation
    {
        public Guid Id { get; set; }
        public string Locale { get; set; }
        public string Description { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid PlanBenefitId { get; set; }

        public virtual PlanBenefit PlanBenefit { get; set; }
    }
}
