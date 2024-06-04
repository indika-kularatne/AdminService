using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Notification
    {
        public Guid Id { get; set; }
        public short Type { get; set; }
        public bool IsSent { get; set; }
        public string Receipent { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? LastUpdatedBy { get; set; }
        public Guid? LastUpdatedDate { get; set; }
        public DateTime? SentTime { get; set; }
        public string Ccto { get; set; }
        public string Bccto { get; set; }
    }
}
