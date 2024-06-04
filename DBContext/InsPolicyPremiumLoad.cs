using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPolicyPremiumLoad
    {
        public Guid Loaduuid { get; set; }
        public string Pnr { get; set; }
        public string PlanCode { get; set; }
        public string FeeCode { get; set; }
        public string DepartureStation { get; set; }
        public decimal DepartureLoad { get; set; }
        public string ReturnStation { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal? ReturnLoad { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? TotalPremium { get; set; }
        public decimal? TotalPremiumWithWeather { get; set; }
    }
}
