using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Emailtemplate
    {
        public int Templateid { get; set; }
        public string Subject { get; set; }
        public string Emailcontent { get; set; }
        public DateTime Createddate { get; set; }
        public DateTime Enddate { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
