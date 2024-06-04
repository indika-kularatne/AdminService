using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SapJournalEntry
    {
        public SapJournalEntry()
        {
            SapJournalEntryLine = new HashSet<SapJournalEntryLine>();
        }

        public Guid Id { get; set; }
        public Guid? PolicyId { get; set; }
        public Guid? ClaimId { get; set; }
        public short? JournalType { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public string Memo { get; set; }
        public string Reference { get; set; }
        public string Reference2 { get; set; }
        public string TransactionCode { get; set; }
        public string ProjectCode { get; set; }
        public int? Series { get; set; }
        public DateTime? DueDate { get; set; }
        public string Reference3 { get; set; }
        public string UserFields { get; set; }
        public DateTime? SentDate { get; set; }
        public short? StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsSent { get; set; }
        public bool? AutoVat { get; set; }

        public virtual Claim Claim { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual ICollection<SapJournalEntryLine> SapJournalEntryLine { get; set; }
    }
}
