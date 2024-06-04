using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysCity
    {
        public SysCity()
        {
            SysAirports = new HashSet<SysAirports>();
        }

        public int? OwmId { get; set; }
        public string Cityname { get; set; }
        public string Countrycode { get; set; }
        public string Coordlon { get; set; }
        public string Coordlat { get; set; }
        public Guid Cityuuid { get; set; }

        public virtual ICollection<SysAirports> SysAirports { get; set; }
    }
}
