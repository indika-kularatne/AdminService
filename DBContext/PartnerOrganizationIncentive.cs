using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PartnerOrganizationIncentive
    {
        public Guid Id { get; set; }
        public Guid PartnerOrganizationId { get; set; }
        public Guid PartnerIncentiveId { get; set; }
        public short SequenceNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual SysAdmin CreatedByNavigation { get; set; }
        public virtual SysAdmin ModifiedByNavigation { get; set; }
        public virtual PartnerIncentive PartnerIncentive { get; set; }
        public virtual PartnerOrganization PartnerOrganization { get; set; }
    }
}
