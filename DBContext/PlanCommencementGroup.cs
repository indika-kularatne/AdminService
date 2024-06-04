using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanCommencementGroup
    {
        public PlanCommencementGroup()
        {
            PlanCommencement = new HashSet<PlanCommencement>();
            PlanSettingCommencementGroupMap = new HashSet<PlanSettingCommencementGroupMap>();
        }

        public Guid Id { get; set; }
        public string PlanCommencementName { get; set; }
        public string PlanCommencementDesc { get; set; }
        public short Statusid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public virtual ICollection<PlanCommencement> PlanCommencement { get; set; }
        public virtual ICollection<PlanSettingCommencementGroupMap> PlanSettingCommencementGroupMap { get; set; }
    }
}
