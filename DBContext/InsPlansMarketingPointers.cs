using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPlansMarketingPointers
    {
        public int? Sequenceno { get; set; }
        public string Marketingpointerdesc { get; set; }
        public Guid? Planmarketinguuid { get; set; }
        public Guid Planmarketingpointeruuid { get; set; }

        public virtual InsPlansMarketing Planmarketinguu { get; set; }
    }
}
