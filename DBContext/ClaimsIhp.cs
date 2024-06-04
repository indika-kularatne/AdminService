using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimsIhp
    {
        public Guid Id { get; set; }
        public Guid? Originalclaimid { get; set; }
        public string Memberid { get; set; }
        public string Claimantnric { get; set; }
        public string Claimantname { get; set; }
        public string Claimno { get; set; }
        public string Claimreferenceno { get; set; }
        public DateTime? Incurreddate { get; set; }
        public string Serviceprovider { get; set; }
        public int? Benefitid { get; set; }
        public string Claimreason { get; set; }
        public string Adminremarks { get; set; }
        public decimal? Payableamount { get; set; }
        public string Claimstatus { get; set; }
        public decimal? Fee { get; set; }
        public string Remarks { get; set; }
        public string Files { get; set; }
        public string Questions { get; set; }
        public bool? Claimmodified { get; set; }
        public short? Activestatus { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Receiptno { get; set; }
        public string Claimrefno { get; set; }
        public DateTime? Claimstatusdate { get; set; }
        public string Claimstatushistory { get; set; }
    }
}
