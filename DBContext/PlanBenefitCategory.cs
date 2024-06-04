using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitCategory
    {
        public short Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
