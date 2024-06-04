using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysLoginLog
    {
        public string Sessionid { get; set; }
        public string Username { get; set; }
        public string Pagename { get; set; }
        public short Actionid { get; set; }
        public DateTime Createddate { get; set; }
        public Guid Loginloguuid { get; set; }
    }
}
