using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimHolderContactLog
    {
        public Guid Id { get; set; }
        public Guid ClaimHolderLogId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string ContactNumber { get; set; }
        public string ContactType { get; set; }

        public virtual ClaimHolderLog ClaimHolderLog { get; set; }
    }
}
