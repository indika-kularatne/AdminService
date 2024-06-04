using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPolicySerialRange
    {
        public DateTime Efffromdate { get; set; }
        public DateTime Efftodate { get; set; }
        public string Policynoheader { get; set; }
        public string Policynofrom { get; set; }
        public string Policynoto { get; set; }
        public string Lastusedno { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid Crby { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Policyserialrangeuuid { get; set; }
        public Guid? Underwriteruuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsUnderwriters Underwriteruu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
