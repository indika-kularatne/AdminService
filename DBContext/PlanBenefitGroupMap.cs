using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitGroupMap
    {
        public Guid Id { get; set; }
        public Guid PlanBenefitGroupId { get; set; }
        public Guid PlanBenefitId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanBenefit PlanBenefit { get; set; }
        public virtual PlanBenefitGroup PlanBenefitGroup { get; set; }
    }
}
