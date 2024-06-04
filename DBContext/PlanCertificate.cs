using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCertificate
    {
        public PlanCertificate()
        {
            PlanCertificateMap = new HashSet<PlanCertificateMap>();
            PlanCertificateTranslation = new HashSet<PlanCertificateTranslation>();
        }

        public Guid Id { get; set; }
        public string CertificateName { get; set; }
        public string CertificateDescription { get; set; }
        public string CertificateContent { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public short? StatusId { get; set; }

        public virtual ICollection<PlanCertificateMap> PlanCertificateMap { get; set; }
        public virtual ICollection<PlanCertificateTranslation> PlanCertificateTranslation { get; set; }
    }
}
