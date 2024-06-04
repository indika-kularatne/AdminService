using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCertificateTranslation
    {
        public Guid Id { get; set; }
        public Guid PlanCertificateId { get; set; }
        public string Locale { get; set; }
        public string Content { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual PlanCertificate PlanCertificate { get; set; }
    }
}
