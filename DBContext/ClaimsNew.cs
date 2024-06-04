using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimsNew
    {
        public Guid Id { get; set; }
        public string Claimno { get; set; }
        public string Lob { get; set; }
        public string Submissionfor { get; set; }
        public string Claimcategory { get; set; }
        public string Policynumbers { get; set; }
        public string Converedpersondetails { get; set; }
        public string Claimantdetails { get; set; }
        public string Claimsdetails { get; set; }
        public string Claimspaymentdetails { get; set; }
        public string Declaractionsandauthorization { get; set; }
        public string Supportingdocuments { get; set; }
        public string Questionsanswers { get; set; }
        public string Claimstatusdetails { get; set; }
        public string Claimsprocessingdetails { get; set; }
        public decimal Claimamount { get; set; }
        public short? Claimstatus { get; set; }
        public DateTime? ClaimstatusDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public decimal EstAmount { get; set; }
        public decimal PayoutAmount { get; set; }
        public short Category { get; set; }
        public string Tags { get; set; }
        public string Claimstatushistory { get; set; }
        public string Remarks { get; set; }
        public string Claimtpavalues { get; set; }
    }
}
