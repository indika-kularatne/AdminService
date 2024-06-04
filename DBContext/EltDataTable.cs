using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class EltDataTable
    {
        public Guid Id { get; set; }
        public Guid EltSettingLogId { get; set; }
        public string TableColumns { get; set; }
        public string TableJson { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual EltSettingLog EltSettingLog { get; set; }
    }
}
