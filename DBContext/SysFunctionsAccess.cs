using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysFunctionsAccess
    {
        public int? Functionlist { get; set; }
        public int? Functionadd { get; set; }
        public int? Functionedit { get; set; }
        public int? Functiondelete { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public Guid Functionaccessuuid { get; set; }
        public Guid? Functionuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysFunctions Functionuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
