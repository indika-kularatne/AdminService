using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSettingMap
    {
        public Guid Id { get; set; }
        public Guid ParentPlanId { get; set; }
        public Guid ChildPlanId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanSetting ChildPlan { get; set; }
        public virtual PlanSetting ParentPlan { get; set; }
    }
}
