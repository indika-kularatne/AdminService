using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansCategoriesPlansLog
    {
        public DateTime? Efffromdate { get; set; }
        public DateTime? Efftodate { get; set; }
        public int? Weightage { get; set; }
        public string Comments { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid Plancatplanloguuid { get; set; }
        public Guid? Plancatplanuuid { get; set; }
        public Guid? Plancatuuid { get; set; }
        public Guid? Planuuid { get; set; }
        public Guid Crby { get; set; }
        public DateTime Crdt { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlansCategoriesPlans Plancatplanuu { get; set; }
        public virtual InsPlansCategories Plancatuu { get; set; }
        public virtual InsPlans Planuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
