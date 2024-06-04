using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitCustomInput
    {
        public PlanBenefitCustomInput()
        {
            PlanBenefitCustomInputList = new HashSet<PlanBenefitCustomInputList>();
            PlanBenefitCustomInputTemplateItem = new HashSet<PlanBenefitCustomInputTemplateItem>();
        }

        public Guid Id { get; set; }
        public string InputName { get; set; }
        public string InputDescription { get; set; }
        public Guid InputTypeId { get; set; }
        public bool IsRequired { get; set; }
        public string RegexExpression { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanBenefitCustomInputType InputType { get; set; }
        public virtual ICollection<PlanBenefitCustomInputList> PlanBenefitCustomInputList { get; set; }
        public virtual ICollection<PlanBenefitCustomInputTemplateItem> PlanBenefitCustomInputTemplateItem { get; set; }
    }
}
