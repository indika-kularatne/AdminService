using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansCategories
    {
        public InsPlansCategories()
        {
            AuditGetquote = new HashSet<AuditGetquote>();
            AuditWsPlanprofilesCoreplancatuu = new HashSet<AuditWsPlanprofiles>();
            AuditWsPlanprofilesPushplancatuu = new HashSet<AuditWsPlanprofiles>();
            InsPlansCategoriesPlans = new HashSet<InsPlansCategoriesPlans>();
            InsPlansCategoriesPlansLog = new HashSet<InsPlansCategoriesPlansLog>();
            InsPlansProfilesSubCore2plancategoryuu = new HashSet<InsPlansProfilesSub>();
            InsPlansProfilesSubCoreplancategoryuu = new HashSet<InsPlansProfilesSub>();
            InsPlansProfilesSubPush2plancategoryuu = new HashSet<InsPlansProfilesSub>();
            InsPlansProfilesSubPushplancategoryuu = new HashSet<InsPlansProfilesSub>();
            InsPlansProfilesUpsell = new HashSet<InsPlansProfilesUpsell>();
        }

        public string Plancat { get; set; }
        public int? Reportsequenceno { get; set; }
        public bool? Isweathercheck { get; set; }
        public Guid Crby { get; set; }
        public DateTime Crdt { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid Plancatuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<AuditGetquote> AuditGetquote { get; set; }
        public virtual ICollection<AuditWsPlanprofiles> AuditWsPlanprofilesCoreplancatuu { get; set; }
        public virtual ICollection<AuditWsPlanprofiles> AuditWsPlanprofilesPushplancatuu { get; set; }
        public virtual ICollection<InsPlansCategoriesPlans> InsPlansCategoriesPlans { get; set; }
        public virtual ICollection<InsPlansCategoriesPlansLog> InsPlansCategoriesPlansLog { get; set; }
        public virtual ICollection<InsPlansProfilesSub> InsPlansProfilesSubCore2plancategoryuu { get; set; }
        public virtual ICollection<InsPlansProfilesSub> InsPlansProfilesSubCoreplancategoryuu { get; set; }
        public virtual ICollection<InsPlansProfilesSub> InsPlansProfilesSubPush2plancategoryuu { get; set; }
        public virtual ICollection<InsPlansProfilesSub> InsPlansProfilesSubPushplancategoryuu { get; set; }
        public virtual ICollection<InsPlansProfilesUpsell> InsPlansProfilesUpsell { get; set; }
    }
}
