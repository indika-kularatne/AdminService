using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class AuditWeatherIndex
    {
        public int OwmId { get; set; }
        public string Pnr { get; set; }
        public DateTime? Traveldate { get; set; }
        public string Airportcode { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Auditwiuuid { get; set; }
        public Guid? Weatherindexuuid { get; set; }

        public virtual SysWeatherIndex Weatherindexuu { get; set; }
    }
}
