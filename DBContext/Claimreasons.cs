using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Claimreasons
    {
        public Guid Id { get; set; }
        public string Memberid { get; set; }
        public string Claimreason { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public short? Activestatus { get; set; }
        public string Claimreasoncode { get; set; }

        public virtual Members Member { get; set; }
    }
}
