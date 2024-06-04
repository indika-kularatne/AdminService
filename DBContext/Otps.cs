using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Otps
    {
        public Guid Id { get; set; }
        public Guid TransactionId { get; set; }
        public long OtpValue { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public Guid RequestId { get; set; }
        public string SendType { get; set; }
        public bool IsUsed { get; set; }
    }
}
