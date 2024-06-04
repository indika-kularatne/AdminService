using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyPaymentReceipt
    {
        public Guid Id { get; set; }
        public int StatusId { get; set; }
        public string ReceiptNo { get; set; }
        public string Error { get; set; }
        public Guid PolicyPaymentStatusId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PolicyPaymentStatus PolicyPaymentStatus { get; set; }
    }
}
