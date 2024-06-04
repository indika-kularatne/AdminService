using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Members
    {
        public Members()
        {
            Benefits = new HashSet<Benefits>();
            Claimquestions = new HashSet<Claimquestions>();
            Claimreasons = new HashSet<Claimreasons>();
            Ecards = new HashSet<Ecards>();
            Medcards = new HashSet<Medcards>();
        }

        public Guid Id { get; set; }
        public string Memberid { get; set; }
        public string Parentmemberid { get; set; }
        public short? Relation { get; set; }
        public string Fullname { get; set; }
        public string Nric { get; set; }
        public string Dob { get; set; }
        public string Companyid { get; set; }
        public string Registeredto { get; set; }
        public string Mobilenum { get; set; }
        public string Bankaccountnumber { get; set; }
        public string Clinictype { get; set; }
        public string Defaultpinnumber { get; set; }
        public short? Ecardeligibility { get; set; }
        public string Hotlinenumber { get; set; }
        public bool? AllowClaimsubmission { get; set; }
        public bool? AllowClaimattachments { get; set; }
        public bool? AllowOtp { get; set; }
        public bool? AllowPdpa { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<Benefits> Benefits { get; set; }
        public virtual ICollection<Claimquestions> Claimquestions { get; set; }
        public virtual ICollection<Claimreasons> Claimreasons { get; set; }
        public virtual ICollection<Ecards> Ecards { get; set; }
        public virtual ICollection<Medcards> Medcards { get; set; }
    }
}
