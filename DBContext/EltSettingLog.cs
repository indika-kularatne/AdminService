using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class EltSettingLog
    {
        public EltSettingLog()
        {
            EltDataTable = new HashSet<EltDataTable>();
        }

        public Guid Id { get; set; }
        public Guid EltSettingId { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        public bool IsSuccess { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual EltSettings EltSetting { get; set; }
        public virtual ICollection<EltDataTable> EltDataTable { get; set; }
    }
}
