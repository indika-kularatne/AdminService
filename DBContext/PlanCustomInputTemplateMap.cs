using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCustomInputTemplateMap
    {
        public Guid Id { get; set; }
        public Guid Planid { get; set; }
        public Guid PlanCustomInputTemplateId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanSetting Plan { get; set; }
        public virtual PlanCustomInputTemplate PlanCustomInputTemplate { get; set; }
    }
}
