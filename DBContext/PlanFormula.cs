using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanFormula
    {
        public PlanFormula()
        {
            PlanUwPermutationFormulaMap = new HashSet<PlanUwPermutationFormulaMap>();
        }

        public Guid Id { get; set; }
        public Guid PlanFormulaMasterId { get; set; }
        public Guid PlanVariableId { get; set; }
        public string CalculationFormula { get; set; }
        public short ValueSign { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public short SequenceNo { get; set; }
        public short StatusId { get; set; }
        public long CalculationType { get; set; }
        public string JsonColumn { get; set; }
        public bool DisplayCalc { get; set; }
        public short? ChargeType { get; set; }
        public bool? IsAddFactorPayment { get; set; }

        public virtual PlanFormulaMaster PlanFormulaMaster { get; set; }
        public virtual PlanVariable PlanVariable { get; set; }
        public virtual ICollection<PlanUwPermutationFormulaMap> PlanUwPermutationFormulaMap { get; set; }
    }
}
