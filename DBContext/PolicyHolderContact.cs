using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyHolderContact
    {
        public Guid Id { get; set; }
        public Guid PolicyHolderId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string ContactNumber { get; set; }
        public string ContactType { get; set; }
        public string MobileCountryCode { get; set; }

        public virtual PolicyHolder PolicyHolder { get; set; }
    }
}
