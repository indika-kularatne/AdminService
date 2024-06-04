using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyWitness
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
        public short Type { get; set; }
        public short? Relationship { get; set; }
        public string MobileCountryCode { get; set; }

        public virtual Policy Policy { get; set; }
    }
}
