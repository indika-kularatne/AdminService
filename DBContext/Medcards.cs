using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Medcards
    {
        public Guid Id { get; set; }
        public string Registeredto { get; set; }
        public string Memberid { get; set; }
        public string Urlfront { get; set; }
        public string Urlback { get; set; }
        public string Cardformat { get; set; }
        public string Fontcolor { get; set; }
        public string Remarksemployee { get; set; }
        public string Designatedclinics { get; set; }
        public short? Dependantcount { get; set; }
        public string Remarksdependant { get; set; }
        public string Dependants { get; set; }
        public short? Activestatus { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual Members Member { get; set; }
    }
}
