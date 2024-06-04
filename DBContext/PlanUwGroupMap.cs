using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanUwGroupMap
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public Guid PlanUwGroupId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanSetting Plan { get; set; }
        public virtual PlanUwGroup PlanUwGroup { get; set; }
    }
}
