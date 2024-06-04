using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysWeatherIndex
    {
        public SysWeatherIndex()
        {
            AuditWeatherIndex = new HashSet<AuditWeatherIndex>();
        }

        public string Conditioncode { get; set; }
        public string Maincode { get; set; }
        public string Description { get; set; }
        public bool? Disabledinsurance { get; set; }
        public decimal? Loading { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public Guid Weatherindexuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<AuditWeatherIndex> AuditWeatherIndex { get; set; }
    }
}
