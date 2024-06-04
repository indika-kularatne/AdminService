using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanMessage
    {
        public PlanMessage()
        {
            ClaimMessageMap = new HashSet<ClaimMessageMap>();
            PlanMessageMap = new HashSet<PlanMessageMap>();
            PlanMessageTranslation = new HashSet<PlanMessageTranslation>();
        }

        public Guid Id { get; set; }
        public string MessageName { get; set; }
        public string MessageDescription { get; set; }
        public short MessageTypeId { get; set; }
        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        public bool IsBodyHtml { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public short? StatusId { get; set; }
        public short? TemplateId { get; set; }

        public virtual ICollection<ClaimMessageMap> ClaimMessageMap { get; set; }
        public virtual ICollection<PlanMessageMap> PlanMessageMap { get; set; }
        public virtual ICollection<PlanMessageTranslation> PlanMessageTranslation { get; set; }
    }
}
