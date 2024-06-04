using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsCarrierFares
    {
        public Guid Carrierfareuuid { get; set; }
        public Guid? Carrieruuid { get; set; }
        public Guid? Fareclassuuid { get; set; }
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

        public virtual InsCarriers Carrieruu { get; set; }
        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsFareclass Fareclassuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
