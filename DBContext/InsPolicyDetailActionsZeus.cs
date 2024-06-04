using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPolicyDetailActionsZeus
    {
        public int? Cisentflag { get; set; }
        public DateTime Cisentcrdt { get; set; }
        public int? Uwsentflag { get; set; }
        public DateTime? Uwsentcrdt { get; set; }
        public int? Cancelledflag { get; set; }
        public DateTime? Cancelledcrdt { get; set; }
        public Guid Policydetailactionuuid { get; set; }
        public Guid? Policydetailuuid { get; set; }

        public virtual InsPolicyDetailZeus Policydetailuu { get; set; }
    }
}
