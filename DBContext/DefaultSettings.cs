using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class DefaultSettings
    {
        public string Key { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Value { get; set; }
    }
}
