using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Entitlements
    {
        public Guid Id { get; set; }
        public string Memberid { get; set; }
        public int? Entitlementyear { get; set; }
        public string Benefittype { get; set; }
        public string Coverage { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public decimal? Entitlementamount { get; set; }
        public decimal? Utilizationpending { get; set; }
        public decimal? Utilizationpaid { get; set; }
        public decimal? Entitlementbalance { get; set; }
        public string Planname { get; set; }
        public string Documenturl { get; set; }
        public string Disclaimer { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Fullname { get; set; }
        public string Parententitlementid { get; set; }
        public string Parentmemberid { get; set; }
        public string PolicyNo { get; set; }
    }
}
