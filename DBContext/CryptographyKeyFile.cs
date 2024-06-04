using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class CryptographyKeyFile
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string KeyValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public short? TypeId { get; set; }
    }
}
