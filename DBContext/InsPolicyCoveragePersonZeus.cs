using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPolicyCoveragePersonZeus
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public int? Age { get; set; }
        public int? Paxtype { get; set; }
        public string Nationality { get; set; }
        public string Cor { get; set; }
        public string Plancode { get; set; }
        public string Aafeecode { get; set; }
        public string Currencycode { get; set; }
        public decimal? Paxpremiumamount { get; set; }
        public DateTime Crdt { get; set; }
        public string Idno { get; set; }
        public int? Isqualified { get; set; }
        public Guid Policycoveragepersonuuid { get; set; }
        public Guid? Policydetailuuid { get; set; }

        public virtual InsPolicyDetailZeus Policydetailuu { get; set; }
    }
}
