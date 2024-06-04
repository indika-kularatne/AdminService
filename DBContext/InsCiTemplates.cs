using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsCiTemplates
    {
        public int? Templatepages { get; set; }
        public string Templatename { get; set; }
        public string Templatedesc { get; set; }
        public string Templatebody1 { get; set; }
        public string Templatebody2 { get; set; }
        public string Templatebody3 { get; set; }
        public string Templatebody4 { get; set; }
        public string Templatebody5 { get; set; }
        public string Templateurl { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public string Countrycode { get; set; }
        public string Culturecode { get; set; }
        public DateTime? Efffromdate { get; set; }
        public DateTime? Efftodate { get; set; }
        public Guid? Upby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid Citemplateuuid { get; set; }
        public Guid? Planuuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual InsPlans Planuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
    }
}
