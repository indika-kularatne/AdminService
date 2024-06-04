using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PaymentProcessItem
    {
        public Guid Id { get; set; }
        public Guid PaymentProcessId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public string ItemName { get; set; }
        public string ItemDataDesc { get; set; }
        public bool? Optional { get; set; }
        public string ItemDataFormat { get; set; }
        public int? TypeId { get; set; }
        public string TrueValue { get; set; }
        public int? Sequence { get; set; }
        public bool? IsSecure { get; set; }
        public int? SecureType { get; set; }
        public bool? IsUsedForSecureKey { get; set; }
        public short? SecureKeySequence { get; set; }
        public string Delimeter { get; set; }
        public string SecureKey { get; set; }

        public virtual PaymentProcess PaymentProcess { get; set; }
    }
}
