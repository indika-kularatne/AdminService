using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Benefits
    {
        public Guid Id { get; set; }
        public string Memberid { get; set; }
        public int? Benefitid { get; set; }
        public string Benefitcategory { get; set; }
        public string Benefitdescription { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public short? Activestatus { get; set; }

        public virtual Members Member { get; set; }
    }
}
