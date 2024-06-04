using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyRequest
    {
        public Guid Id { get; set; }
        public string InputRequest { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PremiumAmout { get; set; }
        public Guid CreatedBy { get; set; }
        public TimeSpan CreatedDate { get; set; }
    }
}
