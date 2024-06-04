using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PgStatStatementsInfo
    {
        public long? Dealloc { get; set; }
        public DateTime? StatsReset { get; set; }
    }
}
