using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Claim
    {
        public Claim()
        {
            ClaimHistoryLog = new HashSet<ClaimHistoryLog>();
            ClaimHolderLog = new HashSet<ClaimHolderLog>();
            ClaimSupportingDocuments = new HashSet<ClaimSupportingDocuments>();
            ClaimantDetails = new HashSet<ClaimantDetails>();
            SapJournalEntry = new HashSet<SapJournalEntry>();
        }

        public Guid Id { get; set; }
        public string PolicyNo { get; set; }
        public DateTime IncidentDate { get; set; }
        public short? Status { get; set; }
        public string ClaimCode { get; set; }
        public string ClaimSerialNo { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public decimal EstAmount { get; set; }
        public decimal PayoutAmount { get; set; }
        public short Category { get; set; }
        public string Tags { get; set; }

        public virtual ICollection<ClaimHistoryLog> ClaimHistoryLog { get; set; }
        public virtual ICollection<ClaimHolderLog> ClaimHolderLog { get; set; }
        public virtual ICollection<ClaimSupportingDocuments> ClaimSupportingDocuments { get; set; }
        public virtual ICollection<ClaimantDetails> ClaimantDetails { get; set; }
        public virtual ICollection<SapJournalEntry> SapJournalEntry { get; set; }
    }
}
