using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SettingStatus
    {
        public SettingStatus()
        {
            PlanSerial = new HashSet<PlanSerial>();
        }

        public short Id { get; set; }
        public string ReferenceTable { get; set; }
        public string StatusName { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<PlanSerial> PlanSerial { get; set; }
    }
}
