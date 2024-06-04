using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCriteriaPremiumMap
    {
        public Guid Id { get; set; }
        public Guid PlanFormulaPremiumMapId { get; set; }
        public string Condition { get; set; }
        public string Jsoncolumn { get; set; }
        public string Input { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanFormulaPremiumMap PlanFormulaPremiumMap { get; set; }
    }
}
