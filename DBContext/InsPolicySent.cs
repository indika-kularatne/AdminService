using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPolicySent
    {
        public Guid Id { get; set; }
        public string PolicyNo { get; set; }
        public string CertificateAttachment { get; set; }
        public TimeSpan CreatedDate { get; set; }
    }
}
