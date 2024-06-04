using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysForex
    {
        public string Currencyfrom { get; set; }
        public string Currencyto { get; set; }
        public decimal Currencyfromvalue { get; set; }
        public decimal Currencytovalue { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public Guid Forexuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
