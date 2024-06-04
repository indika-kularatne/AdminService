using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCriteria
    {
        public Guid Id { get; set; }
        public Guid PlanFormulaMasterId { get; set; }
        public string Condition { get; set; }
        public string Jsoncolumn { get; set; }
        public string Input { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FixedValue { get; set; }

        public virtual PlanFormulaMaster PlanFormulaMaster { get; set; }
    }
}
