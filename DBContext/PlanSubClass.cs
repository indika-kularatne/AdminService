using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSubClass
    {
        public int Id { get; set; }
        public string SubClassName { get; set; }
        public int MajorClassId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }

        public virtual PlanMajorClass MajorClass { get; set; }
    }
}
