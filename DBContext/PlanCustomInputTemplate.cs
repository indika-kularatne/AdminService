using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCustomInputTemplate
    {
        public PlanCustomInputTemplate()
        {
            PlanCustomInputTemplateItem = new HashSet<PlanCustomInputTemplateItem>();
            PlanCustomInputTemplateMap = new HashSet<PlanCustomInputTemplateMap>();
        }

        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public short StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<PlanCustomInputTemplateItem> PlanCustomInputTemplateItem { get; set; }
        public virtual ICollection<PlanCustomInputTemplateMap> PlanCustomInputTemplateMap { get; set; }
    }
}
