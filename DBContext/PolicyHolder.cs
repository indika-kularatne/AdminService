using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyHolder
    {
        public PolicyHolder()
        {
            ClaimantDetails = new HashSet<ClaimantDetails>();
            PolicyHolderContact = new HashSet<PolicyHolderContact>();
        }

        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string IdNo { get; set; }
        public string Gender { get; set; }
        public string AddressPostalcode { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressCountry { get; set; }
        public DateTime? Dob { get; set; }
        public short InsuredType { get; set; }
        public short? Age { get; set; }
        public string ExtensionJson { get; set; }
        public short? StatusId { get; set; }

        public virtual Policy Policy { get; set; }
        public virtual ICollection<ClaimantDetails> ClaimantDetails { get; set; }
        public virtual ICollection<PolicyHolderContact> PolicyHolderContact { get; set; }
    }
}
