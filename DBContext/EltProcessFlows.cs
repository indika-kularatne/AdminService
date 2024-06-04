using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class EltProcessFlows
    {
        public Guid Id { get; set; }
        public Guid EltSettingId { get; set; }
        public short SequenceNo { get; set; }
        public string ProcessName { get; set; }
        public string ProcessParameter { get; set; }
        public bool? SkipException { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual EltSettings EltSetting { get; set; }
    }
}
