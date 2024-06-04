using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysFunctions
    {
        public SysFunctions()
        {
            InverseParentuu = new HashSet<SysFunctions>();
            InverseSequenceuu = new HashSet<SysFunctions>();
            SysFunctionsAccess = new HashSet<SysFunctionsAccess>();
        }

        public string Functiontitle { get; set; }
        public string Functiondesc { get; set; }
        public string Functionlink { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid Functionuuid { get; set; }
        public Guid? Parentuuid { get; set; }
        public Guid? Sequenceuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysFunctions Parentuu { get; set; }
        public virtual SysFunctions Sequenceuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<SysFunctions> InverseParentuu { get; set; }
        public virtual ICollection<SysFunctions> InverseSequenceuu { get; set; }
        public virtual ICollection<SysFunctionsAccess> SysFunctionsAccess { get; set; }
    }
}
