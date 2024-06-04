using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Entities
    {
        public Entities()
        {
            Customers = new HashSet<Customers>();
            PolicyMasterDetails = new HashSet<PolicyMasterDetails>();
            UserSecurityTypes = new HashSet<UserSecurityTypes>();
        }

        public Guid Id { get; set; }
        public string Partnertype { get; set; }
        public string Businessentityname { get; set; }
        public string Businessentityno { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Url { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsLocked { get; set; }
        public string Contactdetails { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Partnercode { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public Guid? Sourceid { get; set; }
        public string Industrycode { get; set; }
        public short? Establishedyear { get; set; }
        public string Businessentitycode { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<PolicyMasterDetails> PolicyMasterDetails { get; set; }
        public virtual ICollection<UserSecurityTypes> UserSecurityTypes { get; set; }
    }
}
