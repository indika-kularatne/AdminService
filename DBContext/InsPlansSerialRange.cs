using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansSerialRange
    {
        public Guid Crby { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Crdt { get; set; }
        public DateTime? Updt { get; set; }
        public Guid Planserialrangeuuid { get; set; }
        public Guid? Planuuid { get; set; }
        public Guid? Policyserialrangeuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlans Planuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
