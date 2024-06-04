using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyTrustee
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? Status { get; set; }
        public DateTime? ExpiryTime { get; set; }
        public short IdentityType { get; set; }
        public string IdentityValue { get; set; }
        public short? Relationship { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Nationality { get; set; }
        public string Address2 { get; set; }
        public string MobileCountryCode { get; set; }

        public virtual Policy Policy { get; set; }
    }
}
