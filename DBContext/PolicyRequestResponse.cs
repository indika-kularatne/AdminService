using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyRequestResponse
    {
        public Guid Id { get; set; }
        public Guid? PolicyId { get; set; }
        public string InputRequest { get; set; }
        public string OutputResponse { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Validity { get; set; }
        public string PlanCode { get; set; }
        public string BaseCurrencyCode { get; set; }
        public string ConvertCurrencyCode { get; set; }
        public decimal? CurrencyRate { get; set; }
        public Guid? PromoMapId { get; set; }
        public int? QuoteStatus { get; set; }
        public string QuotationNumber { get; set; }
        public string PremiumProjection { get; set; }
        public string Channel { get; set; }
        public bool? IsMasterPolicy { get; set; }

        public virtual Policy Policy { get; set; }
    }
}
