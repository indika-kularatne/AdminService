using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysCurrencyExchangeDashboard
    {
        public string Currencyfrom { get; set; }
        public string Currencyto { get; set; }
        public decimal Exchangerate { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public Guid Ceduuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
    }
}
