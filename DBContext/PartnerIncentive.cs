using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PartnerIncentive
    {
        public PartnerIncentive()
        {
            PartnerIncentiveStructure = new HashSet<PartnerIncentiveStructure>();
            PartnerOrganizationIncentive = new HashSet<PartnerOrganizationIncentive>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public short IncentiveStructureTypeId { get; set; }
        public short IncentiveCalculationTypeId { get; set; }
        public short StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual SysAdmin CreatedByNavigation { get; set; }
        public virtual LookupReference IncentiveCalculationType { get; set; }
        public virtual LookupReference IncentiveStructureType { get; set; }
        public virtual SysAdmin ModifiedByNavigation { get; set; }
        public virtual ICollection<PartnerIncentiveStructure> PartnerIncentiveStructure { get; set; }
        public virtual ICollection<PartnerOrganizationIncentive> PartnerOrganizationIncentive { get; set; }
    }
}
