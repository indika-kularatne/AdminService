using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsEmails
    {
        public string Emailsubject { get; set; }
        public string Emailbody { get; set; }
        public string Emailname { get; set; }
        public string Emaildescription { get; set; }
        public string Emailbcc { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public string Countrycode { get; set; }
        public string Culturecode { get; set; }
        public Guid Emailuuid { get; set; }
        public Guid? Planuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlans Planuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
