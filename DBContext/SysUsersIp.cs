using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysUsersIp
    {
        public Guid Useruuid { get; set; }
        public string Ipaddress { get; set; }
        public DateTime? Efffromdate { get; set; }
        public DateTime? Efftodate { get; set; }
        public Guid Useripuuid { get; set; }

        public virtual SysUsers Useruu { get; set; }
    }
}
