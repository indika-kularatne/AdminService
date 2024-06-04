using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCustomInput
    {
        public PlanCustomInput()
        {
            PlanCustomInputList = new HashSet<PlanCustomInputList>();
            PlanCustomInputTemplateItem = new HashSet<PlanCustomInputTemplateItem>();
            PlanFormulaMaster = new HashSet<PlanFormulaMaster>();
            ReinsurerQstFormulaMaster = new HashSet<ReinsurerQstFormulaMaster>();
        }

        public Guid Id { get; set; }
        public string InputName { get; set; }
        public string InputDescription { get; set; }
        public short InputTypeId { get; set; }
        public bool IsCustomValidation { get; set; }
        public string RegexExpression { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public short StatusId { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsInsured { get; set; }

        public virtual PlanInputType InputType { get; set; }
        public virtual ICollection<PlanCustomInputList> PlanCustomInputList { get; set; }
        public virtual ICollection<PlanCustomInputTemplateItem> PlanCustomInputTemplateItem { get; set; }
        public virtual ICollection<PlanFormulaMaster> PlanFormulaMaster { get; set; }
        public virtual ICollection<ReinsurerQstFormulaMaster> ReinsurerQstFormulaMaster { get; set; }
    }
}
