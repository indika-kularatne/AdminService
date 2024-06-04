using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPartnerKeys
    {
        public string Keyname { get; set; }
        public string Keydesc { get; set; }
        public string Keyvalue { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public int? Versionno { get; set; }
        public Guid Partnerkeyuuid { get; set; }
        public Guid? Underwriteruuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsUnderwriters Underwriteruu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
