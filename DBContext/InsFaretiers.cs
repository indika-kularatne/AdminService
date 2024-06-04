using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsFaretiers
    {
        public InsFaretiers()
        {
            InsCarrierFaretiers = new HashSet<InsCarrierFaretiers>();
            InsFaretierRanges = new HashSet<InsFaretierRanges>();
        }

        public string Faretier { get; set; }
        public string Faretierdesc { get; set; }
        public DateTime Crdt { get; set; }
        public DateTime? Updt { get; set; }
        public Guid Crby { get; set; }
        public Guid? Upby { get; set; }
        public Guid Faretieruuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<InsCarrierFaretiers> InsCarrierFaretiers { get; set; }
        public virtual ICollection<InsFaretierRanges> InsFaretierRanges { get; set; }
    }
}
