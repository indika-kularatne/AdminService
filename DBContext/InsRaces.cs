using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsRaces
    {
        public string Racedesc { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Raceuuid { get; set; }
    }
}
