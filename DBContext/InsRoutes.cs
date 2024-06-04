using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsRoutes
    {
        public InsRoutes()
        {
            InsJourneys = new HashSet<InsJourneys>();
        }

        public string Routename { get; set; }
        public string Routedesc { get; set; }
        public string Routetype { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public Guid Routeuuid { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public Guid? Carrieruuid { get; set; }

        public virtual InsCarriers Carrieruu { get; set; }
        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<InsJourneys> InsJourneys { get; set; }
    }
}
