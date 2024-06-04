using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Authorisationapi
    {
        public string Authoriseusername { get; set; }
        public string Authorisepassword { get; set; }
        public Guid Crby { get; set; }
        public DateTime Crdt { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid Authapiuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
