using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class CustomerDevices
    {
        public Guid Id { get; set; }
        public string Deviceno { get; set; }
        public Guid Customerid { get; set; }
        public int? RsUserid { get; set; }
        public string Devicetype { get; set; }
        public string Deviceos { get; set; }
        public string Deviceversion { get; set; }
        public string Deviceplatform { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual Customers Customer { get; set; }
    }
}
