using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansRestrictions
    {
        public int? Isallowed { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Activestatus { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public Guid Planrestrictionuuid { get; set; }
        public Guid? Planuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlans Planuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
