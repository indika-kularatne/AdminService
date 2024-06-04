using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimantDetails
    {
        public Guid Id { get; set; }
        public Guid ClaimId { get; set; }
        public string Name { get; set; }
        public short IdentityType { get; set; }
        public string IdNo { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public short Relationship { get; set; }
        public DateTime Dob { get; set; }
        public short PaymentMethod { get; set; }
        public string BankAccountNumber { get; set; }
        public string Address { get; set; }
        public Guid? InsurerPersonId { get; set; }
        public string BankName { get; set; }

        public virtual Claim Claim { get; set; }
        public virtual PolicyHolder InsurerPerson { get; set; }
    }
}
