using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysAdminPasswordHistory
    {
        public long Id { get; set; }
        public Guid Userid { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public int MinPasswordAgeDays { get; set; }

        public virtual SysAdmin User { get; set; }
    }
}
