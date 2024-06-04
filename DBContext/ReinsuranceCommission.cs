using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsuranceCommission
    {
        public ReinsuranceCommission()
        {
            PlanSettingReinsuranceCommissions = new HashSet<PlanSettingReinsuranceCommissions>();
            ReinsuranceCommissionFormula = new HashSet<ReinsuranceCommissionFormula>();
            ReinsuranceCommissionStructure = new HashSet<ReinsuranceCommissionStructure>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid Underwriteruuid { get; set; }
        public short CommissionStructureTypeId { get; set; }
        public short StatusId { get; set; }
        public decimal QuotaShare { get; set; }
        public decimal RetentionAmount { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual LookupReference CommissionStructureType { get; set; }
        public virtual SysAdmin CreatedByNavigation { get; set; }
        public virtual SysAdmin ModifiedByNavigation { get; set; }
        public virtual InsUnderwriters Underwriteruu { get; set; }
        public virtual ICollection<PlanSettingReinsuranceCommissions> PlanSettingReinsuranceCommissions { get; set; }
        public virtual ICollection<ReinsuranceCommissionFormula> ReinsuranceCommissionFormula { get; set; }
        public virtual ICollection<ReinsuranceCommissionStructure> ReinsuranceCommissionStructure { get; set; }
    }
}
