using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Contactpersons
    {
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public short? Isdefault { get; set; }
        public string Contacttype { get; set; }
        public string Fullname { get; set; }
        public string Nric { get; set; }
        public string Passport { get; set; }
        public string OtherId { get; set; }
        public DateTime? Dob { get; set; }
        public string Nationality { get; set; }
        public string Nationalitycode { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Mobileno { get; set; }
        public short? Statusid { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Designation { get; set; }
    }
}
