using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCustomInputTemplateItem
    {
        public Guid Id { get; set; }
        public Guid PlanCustomInputTemplateId { get; set; }
        public Guid PlanCustomInputId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanCustomInput PlanCustomInput { get; set; }
        public virtual PlanCustomInputTemplate PlanCustomInputTemplate { get; set; }
    }
}
