using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Addresses
    {
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public string Addresstype { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public short? Statusid { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
