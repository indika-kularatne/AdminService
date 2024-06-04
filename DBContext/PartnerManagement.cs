using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PartnerManagement
    {
        public PartnerManagement()
        {
            PartnerPlanMapping = new HashSet<PartnerPlanMapping>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public Guid? OrganizationId { get; set; }

        public virtual PartnerOrganization Organization { get; set; }
        public virtual ICollection<PartnerPlanMapping> PartnerPlanMapping { get; set; }
    }
}
