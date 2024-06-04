using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansRoutes
    {
        public Guid Planrouteuuid { get; set; }
        public Guid? Planuuid { get; set; }
        public Guid? Routeuuid { get; set; }
        public DateTime? Crdt { get; set; }
        public Guid? Crby { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlans Planuu { get; set; }
    }
}
