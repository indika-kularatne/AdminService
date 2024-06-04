using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitCustomInputTemplate
    {
        public PlanBenefitCustomInputTemplate()
        {
            PlanBenefitCustomInputTemplateItem = new HashSet<PlanBenefitCustomInputTemplateItem>();
            PlanBenefitCustomInputTemplateMap = new HashSet<PlanBenefitCustomInputTemplateMap>();
        }

        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public short StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<PlanBenefitCustomInputTemplateItem> PlanBenefitCustomInputTemplateItem { get; set; }
        public virtual ICollection<PlanBenefitCustomInputTemplateMap> PlanBenefitCustomInputTemplateMap { get; set; }
    }
}
