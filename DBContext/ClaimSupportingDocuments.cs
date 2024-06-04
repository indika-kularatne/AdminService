using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimSupportingDocuments
    {
        public Guid Id { get; set; }
        public Guid ClaimId { get; set; }
        public string FileContentBase64 { get; set; }
        public string FileName { get; set; }
        public string DocumentCode { get; set; }
        public string Remarks { get; set; }

        public virtual Claim Claim { get; set; }
    }
}
