using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class AuditWsPlanprofiles
    {
        public string Channel { get; set; }
        public string Pseudoagentcode { get; set; }
        public string Pseudocitycode { get; set; }
        public int? Directioncount { get; set; }
        public string Stopover { get; set; }
        public int? Stopoverhours { get; set; }
        public int? Totalnatsamedest { get; set; }
        public int? Totalnatnotsamedest { get; set; }
        public string Natsamedest { get; set; }
        public string Departureday { get; set; }
        public int? Totaladults { get; set; }
        public int? Totalchild { get; set; }
        public int? Totalinfants { get; set; }
        public string Departureairlinecode { get; set; }
        public string Departurestationcode { get; set; }
        public string Arrivalstationcode { get; set; }
        public int? Mindeparturetimeminutes { get; set; }
        public string Planprofilename { get; set; }
        public string Coreplancode { get; set; }
        public string Coreplanaafeecode { get; set; }
        public string Coreplancurrencycode { get; set; }
        public decimal? Coreplantotalpremiumamount { get; set; }
        public string Pushplancode { get; set; }
        public string Pushplanaafeecode { get; set; }
        public string Pushplancurrencycode { get; set; }
        public decimal? Pushplantotalpremiumamount { get; set; }
        public string Errorcode { get; set; }
        public string Errormessage { get; set; }
        public DateTime Crdt { get; set; }
        public int? Tripdurationdays { get; set; }
        public int? Checked { get; set; }
        public Guid Auditwsppuuid { get; set; }
        public Guid? Planprofileuuid { get; set; }
        public Guid? Coreplancatuuid { get; set; }
        public Guid? Pushplancatuuid { get; set; }
        public Guid? Coreplanuuid { get; set; }
        public Guid? Pushplanuuid { get; set; }
        public Guid? Coreplanmarketinguuid { get; set; }
        public Guid? Pushplanmarketinguuid { get; set; }

        public virtual InsPlansCategories Coreplancatuu { get; set; }
        public virtual InsPlansMarketing Coreplanmarketinguu { get; set; }
        public virtual InsPlans Coreplanuu { get; set; }
        public virtual InsPlansProfiles Planprofileuu { get; set; }
        public virtual InsPlansCategories Pushplancatuu { get; set; }
        public virtual InsPlansMarketing Pushplanmarketinguu { get; set; }
        public virtual InsPlans Pushplanuu { get; set; }
    }
}
