using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSettingCommencementGroupMap
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public Guid PlanCommencementGroupId { get; set; }
        public string PlanCommencementName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public short? StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual PlanSetting Plan { get; set; }
        public virtual PlanCommencementGroup PlanCommencementGroup { get; set; }
    }
}
