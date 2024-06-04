using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanUwPermutations
    {
        public PlanUwPermutations()
        {
            PlanUwPermutationFormulaMap = new HashSet<PlanUwPermutationFormulaMap>();
        }

        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public string PlanUwPermutations1 { get; set; }
        public string PlanVariables { get; set; }
        public short StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Weightage { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public virtual PlanSetting Plan { get; set; }
        public virtual ICollection<PlanUwPermutationFormulaMap> PlanUwPermutationFormulaMap { get; set; }
    }
}
