using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysAirports
    {
        public string Citydesc { get; set; }
        public string Citycode { get; set; }
        public string Countrycode { get; set; }
        public string Areacode { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid Crby { get; set; }
        public DateTime Crdt { get; set; }
        public Guid? Cityuuid { get; set; }
        public Guid Airportuuid { get; set; }
        public double? Hourdiff { get; set; }

        public virtual SysCity Cityuu { get; set; }
        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
