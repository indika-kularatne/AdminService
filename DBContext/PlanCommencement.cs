using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCommencement
    {
        public Guid Id { get; set; }
        public Guid PlanCommencementGroupId { get; set; }
        public short Currentdayvaluestart { get; set; }
        public short Currentdayvalueend { get; set; }
        public short Commencementdayvalue { get; set; }

        public virtual PlanCommencementGroup PlanCommencementGroup { get; set; }
    }
}
