using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsBookingclass
    {
        public InsBookingclass()
        {
            InsCarrierBookings = new HashSet<InsCarrierBookings>();
        }

        public Guid Bookingclassuuid { get; set; }
        public string Bookingclass { get; set; }
        public string Bookingclassdesc { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<InsCarrierBookings> InsCarrierBookings { get; set; }
    }
}
