using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PartnerOrganization
    {
        public PartnerOrganization()
        {
            PartnerManagement = new HashSet<PartnerManagement>();
            PartnerOrganizationIncentive = new HashSet<PartnerOrganizationIncentive>();
        }

        public Guid Id { get; set; }
        public string OrganizationName { get; set; }

        public virtual ICollection<PartnerManagement> PartnerManagement { get; set; }
        public virtual ICollection<PartnerOrganizationIncentive> PartnerOrganizationIncentive { get; set; }
    }
}
