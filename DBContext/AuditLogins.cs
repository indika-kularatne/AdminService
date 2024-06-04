using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class AuditLogins
    {
        public string Adminsessionid { get; set; }
        public Guid Adminid { get; set; }
        public string Loginid { get; set; }
        public string Remoteip { get; set; }
        public int? Loginstatus { get; set; }
        public string Remarks { get; set; }
        public DateTime? Logincrdt { get; set; }
        public DateTime? Logoutupdt { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Auditloginuuid { get; set; }
    }
}
