using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimPaidTo
    {
        public Guid Id { get; set; }
        public Guid ClaimId { get; set; }
        public bool IsClaimantPayee { get; set; }
        public string PayeeName { get; set; }
        public string PayeeRegistrationNo { get; set; }
        public string PayeeNationality { get; set; }
        public string PayeeMailingAddress { get; set; }
        public string PayeeBankName { get; set; }
        public string PayeeBankAccountNumber { get; set; }
    }
}
