using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsPolicyUnsentZeus
    {
        public string Pnr { get; set; }
        public string Policyno { get; set; }
        public string Countrycode { get; set; }
        public string Culturecode { get; set; }
        public string Email { get; set; }
        public string Departurestationcode { get; set; }
        public string Arrivalstationcode { get; set; }
        public DateTime? Departuredatetime { get; set; }
        public DateTime? Returndatetime { get; set; }
        public int? Isflight1way { get; set; }
        public int? Isflight2way { get; set; }
        public string Coveragepersons { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public Guid Policyunsentuuid { get; set; }
        public Guid? Planuuid { get; set; }
        public Guid? Policydetailuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlans Planuu { get; set; }
        public virtual InsPolicyDetailZeus Policydetailuu { get; set; }
    }
}
