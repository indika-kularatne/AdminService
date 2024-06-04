using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlans
    {
        public InsPlans()
        {
            AuditWsPlanprofilesCoreplanuu = new HashSet<AuditWsPlanprofiles>();
            AuditWsPlanprofilesPushplanuu = new HashSet<AuditWsPlanprofiles>();
            InsCiTemplates = new HashSet<InsCiTemplates>();
            InsEmails = new HashSet<InsEmails>();
            InsPlansCategoriesPlans = new HashSet<InsPlansCategoriesPlans>();
            InsPlansCategoriesPlansLog = new HashSet<InsPlansCategoriesPlansLog>();
            InsPlansMarketingOwn = new HashSet<InsPlansMarketingOwn>();
            InsPlansRestrictions = new HashSet<InsPlansRestrictions>();
            InsPlansRoutes = new HashSet<InsPlansRoutes>();
            InsPlansSerialRange = new HashSet<InsPlansSerialRange>();
            InsPolicyDetailZeus = new HashSet<InsPolicyDetailZeus>();
            InsPolicyUnsentZeus = new HashSet<InsPolicyUnsentZeus>();
            InsRatings = new HashSet<InsRatings>();
        }

        public string Planname { get; set; }
        public string Plancode { get; set; }
        public string Plandesc { get; set; }
        public string Plandesc2 { get; set; }
        public int? Planstatus { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public Guid Planuuid { get; set; }
        public Guid? Underwriteruuid { get; set; }
        public int? Chargetype { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsUnderwriters Underwriteruu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<AuditWsPlanprofiles> AuditWsPlanprofilesCoreplanuu { get; set; }
        public virtual ICollection<AuditWsPlanprofiles> AuditWsPlanprofilesPushplanuu { get; set; }
        public virtual ICollection<InsCiTemplates> InsCiTemplates { get; set; }
        public virtual ICollection<InsEmails> InsEmails { get; set; }
        public virtual ICollection<InsPlansCategoriesPlans> InsPlansCategoriesPlans { get; set; }
        public virtual ICollection<InsPlansCategoriesPlansLog> InsPlansCategoriesPlansLog { get; set; }
        public virtual ICollection<InsPlansMarketingOwn> InsPlansMarketingOwn { get; set; }
        public virtual ICollection<InsPlansRestrictions> InsPlansRestrictions { get; set; }
        public virtual ICollection<InsPlansRoutes> InsPlansRoutes { get; set; }
        public virtual ICollection<InsPlansSerialRange> InsPlansSerialRange { get; set; }
        public virtual ICollection<InsPolicyDetailZeus> InsPolicyDetailZeus { get; set; }
        public virtual ICollection<InsPolicyUnsentZeus> InsPolicyUnsentZeus { get; set; }
        public virtual ICollection<InsRatings> InsRatings { get; set; }
    }
}
