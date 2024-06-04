using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPolicyContactPersonZeus
    {
        public string Fullname { get; set; }
        public string Addressline1 { get; set; }
        public string Addressline2 { get; set; }
        public string Addressline3 { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Homephone { get; set; }
        public string Otherphone { get; set; }
        public string Mobilephone { get; set; }
        public string Email { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Policycontactpersonuuid { get; set; }
        public Guid? Policydetailuuid { get; set; }

        public virtual InsPolicyDetailZeus Policydetailuu { get; set; }
    }
}
