using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysUsersUnderwriters
    {
        public DateTime? Efffromdate { get; set; }
        public DateTime? Efftodate { get; set; }
        public Guid Useruwuuid { get; set; }
        public Guid Useruuid { get; set; }
        public Guid Underwriteruuid { get; set; }

        public virtual InsUnderwriters Underwriteruu { get; set; }
        public virtual SysUsers Useruu { get; set; }
    }
}
