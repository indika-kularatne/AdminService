using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanInputType
    {
        public PlanInputType()
        {
            PlanCustomInput = new HashSet<PlanCustomInput>();
        }

        public short Id { get; set; }
        public string TypeName { get; set; }
        public bool IsNumeric { get; set; }
        public bool IsDecimal { get; set; }
        public short DecimalRounding { get; set; }

        public virtual ICollection<PlanCustomInput> PlanCustomInput { get; set; }
    }
}
