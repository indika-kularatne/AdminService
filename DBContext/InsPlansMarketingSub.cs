using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansMarketingSub
    {
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
        public string Plancontent { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public string Marketingpointers { get; set; }
        public Guid Planmarketingsubuuid { get; set; }
        public Guid? Planmarketinguuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlansMarketing Planmarketinguu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
