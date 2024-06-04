using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
