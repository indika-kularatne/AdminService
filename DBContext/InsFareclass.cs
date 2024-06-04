using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsFareclass
    {
        public InsFareclass()
        {
            InsCarrierFares = new HashSet<InsCarrierFares>();
        }

        public string Fareclass { get; set; }
        public string Fareclassdesc { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public Guid Fareclassuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<InsCarrierFares> InsCarrierFares { get; set; }
    }
}
