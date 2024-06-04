using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsCarrierBookings
    {
        public Guid Carrierbookinguuid { get; set; }
        public Guid? Carrieruuid { get; set; }
        public Guid? Bookingclassuuid { get; set; }
        public int? Activestatus { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Weightage { get; set; }
        public double? Qualityvalue { get; set; }
        public double? Coeffvalue { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }

        public virtual InsBookingclass Bookingclassuu { get; set; }
        public virtual InsCarriers Carrieruu { get; set; }
        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
