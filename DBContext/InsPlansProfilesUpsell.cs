using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansProfilesUpsell
    {
        public string Plancat { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Weightage { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public Guid Planprofileupselluuid { get; set; }
        public Guid? Planprofileuuid { get; set; }
        public Guid? Planprofilesubuuid { get; set; }
        public Guid? Plancategoryuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlansCategories Plancategoryuu { get; set; }
        public virtual InsPlansProfilesSub Planprofilesubuu { get; set; }
        public virtual InsPlansProfiles Planprofileuu { get; set; }
    }
}
