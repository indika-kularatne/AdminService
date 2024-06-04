using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Ecards
    {
        public Guid Id { get; set; }
        public string Memberid { get; set; }
        public string Remark1 { get; set; }
        public string Remark2 { get; set; }
        public string Remark3 { get; set; }
        public string Remark4 { get; set; }
        public string Remark5 { get; set; }
        public string Remark6 { get; set; }
        public string Remark7 { get; set; }
        public string Remark8 { get; set; }
        public string Format { get; set; }
        public string Urlfront { get; set; }
        public string Urlback { get; set; }
        public short? Ecardeligibility { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Parentmemberid { get; set; }

        public virtual Members Member { get; set; }
    }
}
