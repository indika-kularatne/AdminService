using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitMap
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public Guid PlanBenefitGroupId { get; set; }
        public int SequenceNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public virtual PlanSetting Plan { get; set; }
        public virtual PlanBenefitGroup PlanBenefitGroup { get; set; }
    }
}
