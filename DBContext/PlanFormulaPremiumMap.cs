using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanFormulaPremiumMap
    {
        public PlanFormulaPremiumMap()
        {
            PlanCriteriaPremiumMap = new HashSet<PlanCriteriaPremiumMap>();
        }

        public Guid Id { get; set; }
        public Guid PlanFormulaMasterId { get; set; }
        public Guid PlanPremiumTableId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual PlanFormulaMaster PlanFormulaMaster { get; set; }
        public virtual PlanPremiumTable PlanPremiumTable { get; set; }
        public virtual ICollection<PlanCriteriaPremiumMap> PlanCriteriaPremiumMap { get; set; }
    }
}
