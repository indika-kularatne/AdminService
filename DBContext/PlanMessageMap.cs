using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanMessageMap
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public Guid PlanMessageId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual PlanSetting Plan { get; set; }
        public virtual PlanMessage PlanMessage { get; set; }
    }
}
