using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class EltBatchProcess
    {
        public Guid Id { get; set; }
        public Guid EltSettinLogId { get; set; }
        public byte[] FileContent { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public Guid EltProcessFlowId { get; set; }
        public string EltProcessFlowProcessParameter { get; set; }
    }
}
