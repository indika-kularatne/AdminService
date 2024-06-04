using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class CustomerRisks
    {
        public Guid Id { get; set; }
        public Guid? Customerid { get; set; }
        public decimal? Riskaccumulationregular { get; set; }
        public decimal? Riskaccumulationsingle { get; set; }
        public string Riskaccumulationmovement { get; set; }
        public string Riskprofile { get; set; }
        public string Riskprofilemovement { get; set; }
        public string Riskindustry { get; set; }
        public string Riskindustrymovement { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual Customers Customer { get; set; }
    }
}
