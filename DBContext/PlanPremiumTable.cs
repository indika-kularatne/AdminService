using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanPremiumTable
    {
        public PlanPremiumTable()
        {
            PlanFormulaPremiumMap = new HashSet<PlanFormulaPremiumMap>();
        }

        public Guid Id { get; set; }
        public string TableJson { get; set; }
        public short StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string DocName { get; set; }
        public string TableColumns { get; set; }

        public virtual ICollection<PlanFormulaPremiumMap> PlanFormulaPremiumMap { get; set; }
    }
}
