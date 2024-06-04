using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyPremiumBreakdown
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public string ChargeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal ChargeAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PayFactorValue { get; set; }
        public string ChargeCode { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public short? StatusId { get; set; }

        public virtual Policy Policy { get; set; }
    }
}
