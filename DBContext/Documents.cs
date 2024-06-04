using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Documents
    {
        public Guid Id { get; set; }
        public string Companyid { get; set; }
        public string Documenturl { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Registeredto { get; set; }
        public short? Activestatus { get; set; }
    }
}
