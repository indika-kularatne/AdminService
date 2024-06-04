using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PaymentRequestValidation
    {
        public Guid PaymentRequestId { get; set; }
        public string RequestJson { get; set; }
        public string ResponseJaon { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid Id { get; set; }
    }
}
