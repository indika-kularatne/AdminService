using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsJourneys
    {
        public string Departureairportcode { get; set; }
        public string Transitairportcode { get; set; }
        public string Arrivalairportcode { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Efffromdate { get; set; }
        public DateTime? Efftodate { get; set; }
        public Guid Journeyuuid { get; set; }
        public Guid? Routeuuid { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsRoutes Routeuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
