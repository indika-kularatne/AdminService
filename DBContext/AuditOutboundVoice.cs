using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class AuditOutboundVoice
    {
        public Guid Id { get; set; }
        public Guid? PolicyId { get; set; }
        public string PolicyNo { get; set; }
        public string Senderid { get; set; }
        public string MobileNo { get; set; }
        public string Voicemessage { get; set; }
        public string Ttsmessage { get; set; }
        public string Audiofileurl { get; set; }
        public DateTime Sentdt { get; set; }
        public string Responsebulkid { get; set; }
        public int? Responsegroupid { get; set; }
        public string Responsegroupname { get; set; }
        public int? Responseid { get; set; }
        public string Responsestatus { get; set; }
        public string Responsedesc { get; set; }
        public DateTime Responsedt { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
