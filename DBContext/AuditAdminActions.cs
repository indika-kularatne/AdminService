using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class AuditAdminActions
    {
        public string Module { get; set; }
        public string Page { get; set; }
        public string Action { get; set; }
        public string Actiondescription { get; set; }
        public string Actionresult { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Adminactionuuid { get; set; }
        public Guid? Adminuuid { get; set; }
        public Guid? Actionapprovaluseruuid { get; set; }

        public virtual SysAdmin Actionapprovaluseruu { get; set; }
        public virtual SysAdmin Adminuu { get; set; }
    }
}
