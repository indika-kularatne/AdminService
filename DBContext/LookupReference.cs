using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class LookupReference
    {
        public LookupReference()
        {
            PartnerIncentiveIncentiveCalculationType = new HashSet<PartnerIncentive>();
            PartnerIncentiveIncentiveStructureType = new HashSet<PartnerIncentive>();
            PartnerIncentiveStructure = new HashSet<PartnerIncentiveStructure>();
            PlanSettingCommissionsAllocationType = new HashSet<PlanSettingCommissions>();
            PlanSettingCommissionsCommissionStructureType = new HashSet<PlanSettingCommissions>();
            ReinsuranceCommission = new HashSet<ReinsuranceCommission>();
            ReinsuranceCommissionStructure = new HashSet<ReinsuranceCommissionStructure>();
        }

        public short Id { get; set; }
        public string ReferenceTable { get; set; }
        public string ReferenceGroup { get; set; }
        public string ReferenceName { get; set; }
        public string ReferenceValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public short? SequenceNo { get; set; }
        public short StatusId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }

        public virtual SysAdmin CreatedByNavigation { get; set; }
        public virtual SysAdmin ModifiedByNavigation { get; set; }
        public virtual ICollection<PartnerIncentive> PartnerIncentiveIncentiveCalculationType { get; set; }
        public virtual ICollection<PartnerIncentive> PartnerIncentiveIncentiveStructureType { get; set; }
        public virtual ICollection<PartnerIncentiveStructure> PartnerIncentiveStructure { get; set; }
        public virtual ICollection<PlanSettingCommissions> PlanSettingCommissionsAllocationType { get; set; }
        public virtual ICollection<PlanSettingCommissions> PlanSettingCommissionsCommissionStructureType { get; set; }
        public virtual ICollection<ReinsuranceCommission> ReinsuranceCommission { get; set; }
        public virtual ICollection<ReinsuranceCommissionStructure> ReinsuranceCommissionStructure { get; set; }
    }
}
