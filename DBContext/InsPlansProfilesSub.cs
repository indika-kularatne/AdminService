using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansProfilesSub
    {
        public InsPlansProfilesSub()
        {
            InsPlansProfilesUpsell = new HashSet<InsPlansProfilesUpsell>();
        }

        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Weightage { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public string Core2messageconfig { get; set; }
        public string Push2messageconfig { get; set; }
        public int? Probabilitystart { get; set; }
        public int? Probabilityend { get; set; }
        public Guid Planprofilesubuuid { get; set; }
        public Guid? Planprofileuuid { get; set; }
        public Guid? Coreplancategoryuuid { get; set; }
        public Guid? Pushplancategoryuuid { get; set; }
        public Guid? Push2plancategoryuuid { get; set; }
        public Guid? Core2plancategoryuuid { get; set; }

        public virtual InsPlansCategories Core2plancategoryuu { get; set; }
        public virtual InsPlansCategories Coreplancategoryuu { get; set; }
        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlansProfiles Planprofileuu { get; set; }
        public virtual InsPlansCategories Push2plancategoryuu { get; set; }
        public virtual InsPlansCategories Pushplancategoryuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<InsPlansProfilesUpsell> InsPlansProfilesUpsell { get; set; }
    }
}
