using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Guaranteeletters
    {
        public Guid Id { get; set; }
        public string Memberid { get; set; }
        public DateTime? Requestdatetime { get; set; }
        public string Files { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Benefitid { get; set; }
        public string Benefittype { get; set; }
        public string Providerid { get; set; }
        public string Providername { get; set; }
        public string Remarks { get; set; }
        public string Plancode { get; set; }
        public string Policyno { get; set; }
        public string Glno { get; set; }
        public string Parentmemberid { get; set; }
        public string Glid { get; set; }
        public string Clmrefno { get; set; }
        public string Rocno { get; set; }
        public string Clmnric { get; set; }
        public string Clmname { get; set; }
        public string Empnric { get; set; }
        public string Empname { get; set; }
        public string Glstatus { get; set; }
        public string Benefittypedesc { get; set; }
        public string Attdoctor { get; set; }
        public string Diagnosis { get; set; }
        public string Additionalremark { get; set; }
        public string Glhistory { get; set; }
    }
}
