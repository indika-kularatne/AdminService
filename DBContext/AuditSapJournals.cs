using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class AuditSapJournals
    {
        public Guid Id { get; set; }
        public Guid? PlanId { get; set; }
        public Guid? PolicyId { get; set; }
        public string PolicyNo { get; set; }
        public string Actiontype { get; set; }
        public short? Journaltype { get; set; }
        public string Transactioncode { get; set; }
        public string Projectcode { get; set; }
        public bool Autovat { get; set; }
        public string Accountcode { get; set; }
        public string Shortname { get; set; }
        public string Linememo { get; set; }
        public string Costingcode { get; set; }
        public string Costingcode2 { get; set; }
        public string Costingcode3 { get; set; }
        public string Costingcode4 { get; set; }
        public string Costingcode5 { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
