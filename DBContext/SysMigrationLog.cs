using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysMigrationLog
    {
        public Guid Migrationloguuid { get; set; }
        public string Tablename { get; set; }
        public string Hashedvalue { get; set; }
        public DateTime Crdt { get; set; }
    }
}
