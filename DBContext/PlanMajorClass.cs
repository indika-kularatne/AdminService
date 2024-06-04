using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanMajorClass
    {
        public PlanMajorClass()
        {
            PlanSubClass = new HashSet<PlanSubClass>();
        }

        public int Id { get; set; }
        public string MajorClassName { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }

        public virtual ICollection<PlanSubClass> PlanSubClass { get; set; }
    }
}
