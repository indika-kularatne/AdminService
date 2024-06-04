using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanMarketingMap
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public Guid PlanMarketingId { get; set; }
        public DateTime? StartDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual PlanSetting Plan { get; set; }
        public virtual PlanMarketing PlanMarketing { get; set; }
    }
}
