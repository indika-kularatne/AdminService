using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysCurrencyExchange
    {
        public string Currency1 { get; set; }
        public string Currency2 { get; set; }
        public decimal Currencyvalue1 { get; set; }
        public decimal Currencyvalue2 { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public Guid Currencyexchangeuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
    }
}
