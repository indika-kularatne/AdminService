using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Clinics
    {
        public Guid Id { get; set; }
        public string Memberid { get; set; }
        public string Parentmemberid { get; set; }
        public string Clinicname { get; set; }
        public string Doctor { get; set; }
        public string Address { get; set; }
        public string Clinictype { get; set; }
        public string Companyname { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Distance { get; set; }
        public string Employeename { get; set; }
        public string Status { get; set; }
        public string Phoiam { get; set; }
        public string Phoipm { get; set; }
        public string Phoint { get; set; }
        public string Phoneno { get; set; }
        public string Remarks { get; set; }
        public string Satam { get; set; }
        public string Satpm { get; set; }
        public string Sant { get; set; }
        public string Sunam { get; set; }
        public string Sunpm { get; set; }
        public string Sunnt { get; set; }
        public string Wdayam { get; set; }
        public string Wdaypm { get; set; }
        public string Wdaynt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
