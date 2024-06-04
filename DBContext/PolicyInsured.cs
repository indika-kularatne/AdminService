using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyInsured
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public short StatusId { get; set; }
        public decimal PremiumAmount { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
