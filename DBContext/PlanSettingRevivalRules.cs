using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSettingRevivalRules
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public decimal? MinDays { get; set; }
        public decimal? MaxDays { get; set; }
        public bool? RequireIndebtness { get; set; }
        public bool? RequireInterest { get; set; }
        public bool? RequirePersonalDeclarations { get; set; }
        public bool? RequireFullUnderwriting { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public virtual PlanSetting Plan { get; set; }
    }
}
