using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsRatings
    {
        public string Aafeecode { get; set; }
        public int? Directioncount { get; set; }
        public decimal? Suminsured { get; set; }
        public int? Minduration { get; set; }
        public int? Maxduration { get; set; }
        public int? Totalduration { get; set; }
        public int? Isweeklyrate { get; set; }
        public int? Tierno { get; set; }
        public string Currencycode { get; set; }
        public decimal Premiumamount { get; set; }
        public DateTime? Efffromdate { get; set; }
        public DateTime? Efftodate { get; set; }
        public int? Isdefault { get; set; }
        public decimal Stampdutyamount { get; set; }
        public decimal Vattaxrate { get; set; }
        public decimal Vattaxamount { get; set; }
        public int? Agemin { get; set; }
        public int? Agemax { get; set; }
        public string Gender { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public int? Minpaxcount { get; set; }
        public int? Maxpaxcount { get; set; }
        public int? Mindeparturetimeminutes { get; set; }
        public Guid Ratinguuid { get; set; }
        public Guid? Planuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlans Planuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
