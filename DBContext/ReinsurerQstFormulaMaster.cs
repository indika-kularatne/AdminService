using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsurerQstFormulaMaster
    {
        public ReinsurerQstFormulaMaster()
        {
            ReinsurerQstFormula = new HashSet<ReinsurerQstFormula>();
        }

        public Guid Id { get; set; }
        public Guid QstId { get; set; }
        public string FormulaMasterCode { get; set; }
        public string FormulaMasterName { get; set; }
        public short? SequenceNo { get; set; }
        public Guid? EndDateReference { get; set; }
        public string EndDateValueType { get; set; }
        public short? StatusId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual PlanCustomInput EndDateReferenceNavigation { get; set; }
        public virtual ICollection<ReinsurerQstFormula> ReinsurerQstFormula { get; set; }
    }
}
