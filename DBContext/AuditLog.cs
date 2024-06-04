using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class AuditLog
    {
        public string Tablename { get; set; }
        public string Actionvalue { get; set; }
        public DateTime Actiondt { get; set; }
        public int Actionby { get; set; }
        public string Oldvalue { get; set; }
        public Guid Auditloguuid { get; set; }
        public Guid? Itemuuid { get; set; }
    }
}
