using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PaymentRequest
    {
        public Guid MerchantTransid { get; set; }
        public string SaleChannel { get; set; }
        public string PaymentGateway { get; set; }
        public string TransactionType { get; set; }
        public string PaymentIndicator { get; set; }
        public string PaymentCriteria { get; set; }
        public string PaymentInfo { get; set; }
        public string RequestJson { get; set; }
        public string ResponseJson { get; set; }
    }
}
