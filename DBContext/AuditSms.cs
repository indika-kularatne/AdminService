using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class AuditSms
    {
        public Guid Id { get; set; }
        public Guid? PolicyId { get; set; }
        public string PolicyNo { get; set; }
        public string Senderid { get; set; }
        public string MobileNo { get; set; }
        public string Smsmessage { get; set; }
        public DateTime Sentdt { get; set; }
        public string Smsresponse { get; set; }
        public string Smsstatuscode { get; set; }
        public string Smsstatusdesc { get; set; }
        public string Smsstatus { get; set; }
        public DateTime Responsedt { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
