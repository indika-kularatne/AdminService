using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class OrganizationEmployee
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public string Name { get; set; }
        public string IcId { get; set; }
        public string StaffId { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Designation { get; set; }
        public string Address { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string Relationship { get; set; }
        public string Ghsyrt { get; set; }
        public string GhsyrtThree { get; set; }
        public string Gpsp { get; set; }
        public string Gtl { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public short BlacklistId { get; set; }

        public virtual SysAdmin CreatedByNavigation { get; set; }
        public virtual SysAdmin ModifiedByNavigation { get; set; }
        public virtual SysOrganizations Organization { get; set; }
    }
}
