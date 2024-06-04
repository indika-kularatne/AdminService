using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPolicyPaymentStatusLog
    {
        public string Pnr { get; set; }
        public string Paymentstatus { get; set; }
        public string Proccessedstatus { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Policypaymentstatusloguuid { get; set; }
        public Guid? Policypaymentstatusuuid { get; set; }

        public virtual InsPolicyPaymentStatus Policypaymentstatusuu { get; set; }
    }
}
