using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanVariable
    {
        public PlanVariable()
        {
            PlanFormula = new HashSet<PlanFormula>();
            PlanPromoCodeMap = new HashSet<PlanPromoCodeMap>();
            ReinsurerQstFormula = new HashSet<ReinsurerQstFormula>();
        }

        public Guid Id { get; set; }
        public string VariableName { get; set; }
        public string VariableDescription { get; set; }
        public short DefaultValueSign { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public short? StatusId { get; set; }
        public bool IsDefault { get; set; }

        public virtual ICollection<PlanFormula> PlanFormula { get; set; }
        public virtual ICollection<PlanPromoCodeMap> PlanPromoCodeMap { get; set; }
        public virtual ICollection<ReinsurerQstFormula> ReinsurerQstFormula { get; set; }
    }
}
