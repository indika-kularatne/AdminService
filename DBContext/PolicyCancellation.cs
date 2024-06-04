using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyCancellation
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public Guid CancelledBy { get; set; }
        public DateTime CancelledDate { get; set; }
        public decimal RefundAmount { get; set; }
        public decimal RefundRate { get; set; }
        public int PolicyDuration { get; set; }
        public int PolicyDurationWhenCancel { get; set; }
        public string PolicyNo { get; set; }
        public string Reason { get; set; }
    }
}
