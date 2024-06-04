using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Claimquestions
    {
        public Guid Id { get; set; }
        public string Memberid { get; set; }
        public int? Benefitid { get; set; }
        public string Sectiontitle { get; set; }
        public int? Qnserialnumber { get; set; }
        public int? Qnid { get; set; }
        public string Qntype { get; set; }
        public string Question { get; set; }
        public int? Parentqnid { get; set; }
        public bool? IsMandatory { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Registeredto { get; set; }
        public short? Activestatus { get; set; }

        public virtual Members Member { get; set; }
    }
}
