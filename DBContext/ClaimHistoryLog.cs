using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimHistoryLog
    {
        public Guid Id { get; set; }
        public Guid? ClaimId { get; set; }
        public string PolicyNo { get; set; }
        public DateTime? IncidentDate { get; set; }
        public short? Status { get; set; }
        public string ClaimCode { get; set; }
        public string ClaimSerialNo { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Type { get; set; }
        public decimal? EstAmount { get; set; }
        public decimal? PayoutAmount { get; set; }
        public short? Category { get; set; }

        public virtual Claim Claim { get; set; }
    }
}
