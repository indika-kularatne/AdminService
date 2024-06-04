using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsuranceCommissionFormula
    {
        public Guid Id { get; set; }
        public Guid ReinsuranceCommissionId { get; set; }
        public string CalculationFormula { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual SysAdmin CreatedByNavigation { get; set; }
        public virtual SysAdmin ModifiedByNavigation { get; set; }
        public virtual ReinsuranceCommission ReinsuranceCommission { get; set; }
    }
}
