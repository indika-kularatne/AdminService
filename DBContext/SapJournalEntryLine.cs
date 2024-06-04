using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SapJournalEntryLine
    {
        public Guid Id { get; set; }
        public Guid? SapJournalEntryId { get; set; }
        public string AccountCode { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? FcDebit { get; set; }
        public decimal? FcCredit { get; set; }
        public string FcCurrency { get; set; }
        public DateTime? DueDate { get; set; }
        public string ShortName { get; set; }
        public string LineMemo { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string ProjectCode { get; set; }
        public string CostingCode { get; set; }
        public decimal? BaseSum { get; set; }
        public string TaxGroup { get; set; }
        public string AdditionalReference { get; set; }
        public string CostingCode2 { get; set; }
        public string CostingCode3 { get; set; }
        public string CostingCode4 { get; set; }
        public string CostingCode5 { get; set; }
        public string UserFields { get; set; }

        public virtual SapJournalEntry SapJournalEntry { get; set; }
    }
}
