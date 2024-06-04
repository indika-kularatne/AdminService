using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitCustomInputList
    {
        public Guid Id { get; set; }
        public Guid PlanBenefitCustomInputId { get; set; }
        public string ListItemName { get; set; }
        public string ListItemValue { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanBenefitCustomInput PlanBenefitCustomInput { get; set; }
    }
}
