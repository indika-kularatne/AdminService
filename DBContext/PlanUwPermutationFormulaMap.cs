using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanUwPermutationFormulaMap
    {
        public Guid Id { get; set; }
        public Guid PlanUwPermutationId { get; set; }
        public Guid PlanFormulaId { get; set; }
        public short StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Weightage { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public virtual PlanFormula PlanFormula { get; set; }
        public virtual PlanUwPermutations PlanUwPermutation { get; set; }
    }
}
