using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyNominee
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public string FullName { get; set; }
        public string IdentityValue { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int SharePercentage { get; set; }
        public string Relationship { get; set; }
        public string IdentityType { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Country { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public string Religion { get; set; }
        public string WitnessType { get; set; }
        public string Address2 { get; set; }
        public string MobileCountryCode { get; set; }

        public virtual Policy Policy { get; set; }
    }
}
