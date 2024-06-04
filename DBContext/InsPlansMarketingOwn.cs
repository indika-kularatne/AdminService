using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansMarketingOwn
    {
        public int? Overwritedefaultmarketing { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Crdt { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Planmarketinguuid { get; set; }
        public Guid? Planuuid { get; set; }
        public Guid Planmarketingownuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlansMarketing Planmarketinguu { get; set; }
        public virtual InsPlans Planuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
