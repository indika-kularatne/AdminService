using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsurerQstFormula
    {
        public Guid Id { get; set; }
        public Guid ReinsurerQstFormulaMasterId { get; set; }
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

        public virtual PlanVariable PlanVariable { get; set; }
        public virtual ReinsurerQstFormulaMaster ReinsurerQstFormulaMaster { get; set; }
    }
}
