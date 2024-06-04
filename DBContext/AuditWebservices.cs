using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class AuditWebservices
    {
        public string Agentname { get; set; }
        public string Modulename { get; set; }
        public string Functionname { get; set; }
        public string Direction { get; set; }
        public string Xmlcontent { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Auditwsuuid { get; set; }
    }
}
