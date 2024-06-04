using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansProfilesMarketing
    {
        public int? Segmentstatus { get; set; }
        public decimal? Messagegroupcorepcta { get; set; }
        public decimal? Messagegroupcorepctb { get; set; }
        public decimal? Messagegroupcorepctc { get; set; }
        public decimal? Messagegroupcorepctd { get; set; }
        public decimal? Messagegroupcorepcte { get; set; }
        public decimal? Messagegrouppushpcta { get; set; }
        public decimal? Messagegrouppushpctb { get; set; }
        public decimal? Messagegrouppushpctc { get; set; }
        public decimal? Messagegrouppushpctd { get; set; }
        public decimal? Messagegrouppushpcte { get; set; }
        public decimal? Messagefamilycorepcta { get; set; }
        public decimal? Messagefamilycorepctb { get; set; }
        public decimal? Messagefamilycorepctc { get; set; }
        public decimal? Messagefamilycorepctd { get; set; }
        public decimal? Messagefamilycorepcte { get; set; }
        public decimal? Messagefamilypushpcta { get; set; }
        public decimal? Messagefamilypushpctb { get; set; }
        public decimal? Messagefamilypushpctc { get; set; }
        public decimal? Messagefamilypushpctd { get; set; }
        public decimal? Messagefamilypushpcte { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Weightage { get; set; }
        public string Targetdeparturecountrycode { get; set; }
        public string Targetarrivalcountrycode { get; set; }
        public Guid Planprofilemarketinguuid { get; set; }
        public Guid? Planprofileuuid { get; set; }
        public Guid? Messagegroupcorea { get; set; }
        public Guid? Messagegroupcoreb { get; set; }
        public Guid? Messagegroupcorec { get; set; }
        public Guid? Messagegroupcored { get; set; }
        public Guid? Messagegroupcoree { get; set; }
        public Guid? Messagegrouppusha { get; set; }
        public Guid? Messagegrouppushb { get; set; }
        public Guid? Messagegrouppushc { get; set; }
        public Guid? Messagegrouppushd { get; set; }
        public Guid? Messagegrouppushe { get; set; }
        public Guid? Messagefamilycorea { get; set; }
        public Guid? Messagefamilycoreb { get; set; }
        public Guid? Messagefamilycorec { get; set; }
        public Guid? Messagefamilycored { get; set; }
        public Guid? Messagefamilycoree { get; set; }
        public Guid? Messagefamilypusha { get; set; }
        public Guid? Messagefamilypushb { get; set; }
        public Guid? Messagefamilypushc { get; set; }
        public Guid? Messagefamilypushd { get; set; }
        public Guid? Messagefamilypushe { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlansProfiles Planprofileuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
