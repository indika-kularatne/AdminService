using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansProfiles
    {
        public InsPlansProfiles()
        {
            AuditWsPlanprofiles = new HashSet<AuditWsPlanprofiles>();
            InsPlansProfilesMarketing = new HashSet<InsPlansProfilesMarketing>();
            InsPlansProfilesSub = new HashSet<InsPlansProfilesSub>();
            InsPlansProfilesUpsell = new HashSet<InsPlansProfilesUpsell>();
        }

        public string Profilename { get; set; }
        public int? Directioncount { get; set; }
        public string Stopover { get; set; }
        public int? Stopoverminhours { get; set; }
        public int? Stopovermaxhours { get; set; }
        public string Nationalitysamedestination { get; set; }
        public int? Tripdurationdaysmin { get; set; }
        public int? Tripdurationdaysmax { get; set; }
        public string Departuredayoftheweek { get; set; }
        public int? Adultcountmin { get; set; }
        public int? Adultcountmax { get; set; }
        public int? Childcountmin { get; set; }
        public int? Childcountmax { get; set; }
        public int? Infantcountmin { get; set; }
        public int? Infantcountmax { get; set; }
        public int? Mindeparturetimeminutes { get; set; }
        public int? Probabilitypct { get; set; }
        public int? Isdefault { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Weightage { get; set; }
        public string Core2messageconfig { get; set; }
        public string Push2messageconfig { get; set; }
        public Guid Crby { get; set; }
        public DateTime Crdt { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public int? Probabilitypctstart { get; set; }
        public Guid Planprofileuuid { get; set; }
        public Guid? Coreplanuuid { get; set; }
        public Guid? Pushplanuuid { get; set; }
        public Guid? Core2planuuid { get; set; }
        public Guid? Push2planuuid { get; set; }
        public Guid? Carrieruuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<AuditWsPlanprofiles> AuditWsPlanprofiles { get; set; }
        public virtual ICollection<InsPlansProfilesMarketing> InsPlansProfilesMarketing { get; set; }
        public virtual ICollection<InsPlansProfilesSub> InsPlansProfilesSub { get; set; }
        public virtual ICollection<InsPlansProfilesUpsell> InsPlansProfilesUpsell { get; set; }
    }
}
