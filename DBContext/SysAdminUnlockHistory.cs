using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysAdminUnlockHistory
    {
        public long Id { get; set; }
        public Guid Userid { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }

        public virtual SysAdmin CreatedByNavigation { get; set; }
        public virtual SysAdmin User { get; set; }
    }
}
