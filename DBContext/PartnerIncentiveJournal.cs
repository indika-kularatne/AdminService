using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PartnerIncentiveJournal
    {
        public Guid Id { get; set; }
        public Guid PartnerId { get; set; }
        public string DateCode { get; set; }
        public decimal GrossPremiumAmount { get; set; }
        public int GrossPolicyCount { get; set; }
        public decimal IncentiveAmount { get; set; }
        public string CalcRemarks { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
