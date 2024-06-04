using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCertificateMap
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public Guid PlanCertificateId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int SequenceNo { get; set; }
        public string DocFilename { get; set; }
        public short DocumentType { get; set; }
        public short DocumentAction { get; set; }
        public bool IsPasswordProtected { get; set; }
        public string Password { get; set; }

        public virtual PlanSetting Plan { get; set; }
        public virtual PlanCertificate PlanCertificate { get; set; }
    }
}
