using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimMessageMap
    {
        public Guid Id { get; set; }
        public Guid PlanBenefitId { get; set; }
        public Guid PlanMessageId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string MessageCode { get; set; }
        public string MessageFrom { get; set; }
        public string MessageTo { get; set; }
        public string MessageCc { get; set; }
        public string MessageBcc { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual PlanBenefit PlanBenefit { get; set; }
        public virtual PlanMessage PlanMessage { get; set; }
    }
}
