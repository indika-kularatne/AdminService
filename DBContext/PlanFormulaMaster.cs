using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanFormulaMaster
    {
        public PlanFormulaMaster()
        {
            PlanCriteria = new HashSet<PlanCriteria>();
            PlanFormula = new HashSet<PlanFormula>();
            PlanFormulaPremiumMap = new HashSet<PlanFormulaPremiumMap>();
        }

        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public short? StatusId { get; set; }
        public Guid? EndDateReference { get; set; }
        public string EndDateValueType { get; set; }
        public int? FixedValue { get; set; }

        public virtual PlanCustomInput EndDateReferenceNavigation { get; set; }
        public virtual PlanSetting Plan { get; set; }
        public virtual ICollection<PlanCriteria> PlanCriteria { get; set; }
        public virtual ICollection<PlanFormula> PlanFormula { get; set; }
        public virtual ICollection<PlanFormulaPremiumMap> PlanFormulaPremiumMap { get; set; }
    }
}
