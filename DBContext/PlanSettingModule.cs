using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSettingModule
    {
        public Guid Id { get; set; }
        public int ModuleType { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid PlanId { get; set; }
        public bool ModuleValue { get; set; }

        public virtual PlanSetting Plan { get; set; }
    }
}
