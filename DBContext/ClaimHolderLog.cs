using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimHolderLog
    {
        public ClaimHolderLog()
        {
            ClaimHolderContactLog = new HashSet<ClaimHolderContactLog>();
        }

        public Guid Id { get; set; }
        public Guid ClaimId { get; set; }
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

        public virtual Claim Claim { get; set; }
        public virtual ICollection<ClaimHolderContactLog> ClaimHolderContactLog { get; set; }
    }
}
