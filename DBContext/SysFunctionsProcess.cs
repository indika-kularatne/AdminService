using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysFunctionsProcess
    {
        public SysFunctionsProcess()
        {
            InverseParentuu = new HashSet<SysFunctionsProcess>();
            InverseSequenceuu = new HashSet<SysFunctionsProcess>();
        }

        public string Functiontitle { get; set; }
        public string Functiondesc { get; set; }
        public string Functionlink { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public Guid Functionprocessuuid { get; set; }
        public Guid? Parentuuid { get; set; }
        public Guid? Sequenceuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysFunctionsProcess Parentuu { get; set; }
        public virtual SysFunctionsProcess Sequenceuu { get; set; }
        public virtual ICollection<SysFunctionsProcess> InverseParentuu { get; set; }
        public virtual ICollection<SysFunctionsProcess> InverseSequenceuu { get; set; }
    }
}
