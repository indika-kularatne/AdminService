using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Enquiry
    {
        public Guid Id { get; set; }
        public int EnquiryType { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Details { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
