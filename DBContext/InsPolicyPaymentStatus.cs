using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPolicyPaymentStatus
    {
        public InsPolicyPaymentStatus()
        {
            InsPolicyPaymentStatusLog = new HashSet<InsPolicyPaymentStatusLog>();
        }

        public string Pnr { get; set; }
        public string Paymentstatus { get; set; }
        public string Proccessedstatus { get; set; }
        public int? Attempt { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Policypaymentstatusuuid { get; set; }

        public virtual ICollection<InsPolicyPaymentStatusLog> InsPolicyPaymentStatusLog { get; set; }
    }
}
