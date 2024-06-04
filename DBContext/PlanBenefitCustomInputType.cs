using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitCustomInputType
    {
        public PlanBenefitCustomInputType()
        {
            PlanBenefitCustomInput = new HashSet<PlanBenefitCustomInput>();
        }

        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public bool IsNumeric { get; set; }
        public bool IsDecimal { get; set; }
        public short DecimalRounding { get; set; }

        public virtual ICollection<PlanBenefitCustomInput> PlanBenefitCustomInput { get; set; }
    }
}
