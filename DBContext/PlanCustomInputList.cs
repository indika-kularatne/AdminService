using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCustomInputList
    {
        public Guid Id { get; set; }
        public Guid PlanCustomInputId { get; set; }
        public string ListItemName { get; set; }
        public string ListItemValue { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanCustomInput PlanCustomInput { get; set; }
    }
}
