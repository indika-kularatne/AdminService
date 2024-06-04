using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class BankingDetails
    {
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public string Bankname { get; set; }
        public string Accountno { get; set; }
        public string Accountholdername { get; set; }
        public string Accountholderidno { get; set; }
        public string Accountholdercontactno { get; set; }
        public string Accountholderemail { get; set; }
        public short? Statusid { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
