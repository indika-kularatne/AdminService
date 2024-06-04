using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsUnderwritersReports
    {
        public string Reporttype { get; set; }
        public int? Reportgentype { get; set; }
        public string Reportfilename { get; set; }
        public string Reportendpoint { get; set; }
        public string Reportdetails { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public Guid Underwriterreportuuid { get; set; }
        public Guid? Underwriteruuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsUnderwriters Underwriteruu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
