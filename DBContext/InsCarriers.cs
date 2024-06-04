using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsCarriers
    {
        public InsCarriers()
        {
            InsCarrierBookings = new HashSet<InsCarrierBookings>();
            InsCarrierFares = new HashSet<InsCarrierFares>();
            InsCarrierFaretiers = new HashSet<InsCarrierFaretiers>();
            InsRoutes = new HashSet<InsRoutes>();
        }

        public string Carriercode { get; set; }
        public string Carrierdesc { get; set; }
        public string Currencycode { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public Guid Carrieruuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<InsCarrierBookings> InsCarrierBookings { get; set; }
        public virtual ICollection<InsCarrierFares> InsCarrierFares { get; set; }
        public virtual ICollection<InsCarrierFaretiers> InsCarrierFaretiers { get; set; }
        public virtual ICollection<InsRoutes> InsRoutes { get; set; }
    }
}
