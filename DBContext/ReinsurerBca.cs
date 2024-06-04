using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsurerBca
    {
        public ReinsurerBca()
        {
            ReinsurerQstreaties = new HashSet<ReinsurerQstreaties>();
        }

        public Guid Id { get; set; }
        public Guid InsurerId { get; set; }
        public Guid ReinsurerId { get; set; }
        public Guid RetroId { get; set; }
        public string AgreementName { get; set; }
        public string AgreementNo { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public short? InitialTermYear { get; set; }
        public DateTime InitialEndDate { get; set; }
        public short? RenewalTermYear { get; set; }
        public short? RenewalNoticeValue { get; set; }
        public string RenewalNoticeTerm { get; set; }
        public DateTime SignedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual Insurers Insurer { get; set; }
        public virtual Reinsurers Reinsurer { get; set; }
        public virtual ICollection<ReinsurerQstreaties> ReinsurerQstreaties { get; set; }
    }
}
