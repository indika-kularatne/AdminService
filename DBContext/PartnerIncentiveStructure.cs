using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PartnerIncentiveStructure
    {
        public Guid Id { get; set; }
        public Guid PartnerIncentiveId { get; set; }
        public short AllocationTypeId { get; set; }
        public short SequenceNo { get; set; }
        public decimal Incentive { get; set; }
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
        public short StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual LookupReference AllocationType { get; set; }
        public virtual SysAdmin CreatedByNavigation { get; set; }
        public virtual SysAdmin ModifiedByNavigation { get; set; }
        public virtual PartnerIncentive PartnerIncentive { get; set; }
    }
}
