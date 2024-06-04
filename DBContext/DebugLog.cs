using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class DebugLog
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public string ItemValue { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
