using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansMarketing
    {
        public InsPlansMarketing()
        {
            AuditWsPlanprofilesCoreplanmarketinguu = new HashSet<AuditWsPlanprofiles>();
            AuditWsPlanprofilesPushplanmarketinguu = new HashSet<AuditWsPlanprofiles>();
            InsPlansMarketingOwn = new HashSet<InsPlansMarketingOwn>();
            InsPlansMarketingPointers = new HashSet<InsPlansMarketingPointers>();
            InsPlansMarketingSub = new HashSet<InsPlansMarketingSub>();
        }

        public string Coreorpush { get; set; }
        public string Familyorgroup { get; set; }
        public string Marketingtitle { get; set; }
        public string Countrycode { get; set; }
        public string Culturecode { get; set; }
        public string Plantitle { get; set; }
        public string Plandesc { get; set; }
        public string Planadditionalinfotitle { get; set; }
        public string Planadditionalinfodesc { get; set; }
        public string Planyesdesc { get; set; }
        public string Plannodesc { get; set; }
        public string Plannoconsideration { get; set; }
        public string Plantnc { get; set; }
        public int? Plandefault { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public string Plancontent { get; set; }
        public DateTime? Efffromdate { get; set; }
        public DateTime? Efftodate { get; set; }
        public string Marketingpointers { get; set; }
        public Guid Planmarketinguuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<AuditWsPlanprofiles> AuditWsPlanprofilesCoreplanmarketinguu { get; set; }
        public virtual ICollection<AuditWsPlanprofiles> AuditWsPlanprofilesPushplanmarketinguu { get; set; }
        public virtual ICollection<InsPlansMarketingOwn> InsPlansMarketingOwn { get; set; }
        public virtual ICollection<InsPlansMarketingPointers> InsPlansMarketingPointers { get; set; }
        public virtual ICollection<InsPlansMarketingSub> InsPlansMarketingSub { get; set; }
    }
}
