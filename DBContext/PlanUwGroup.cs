using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanUwGroup
    {
        public PlanUwGroup()
        {
            PlanUwGroupMap = new HashSet<PlanUwGroupMap>();
            PlanUwQuestionsMap = new HashSet<PlanUwQuestionsMap>();
        }

        public Guid Id { get; set; }
        public string GroupCode { get; set; }
        public string GroupDesc { get; set; }
        public short StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Weightage { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public virtual ICollection<PlanUwGroupMap> PlanUwGroupMap { get; set; }
        public virtual ICollection<PlanUwQuestionsMap> PlanUwQuestionsMap { get; set; }
    }
}
