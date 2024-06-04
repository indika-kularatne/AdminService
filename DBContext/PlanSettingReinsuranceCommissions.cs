using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSettingReinsuranceCommissions
    {
        public Guid Id { get; set; }
        public Guid ReinsuranceCommissionId { get; set; }
        public Guid PlanId { get; set; }
        public short StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual SysAdmin CreatedByNavigation { get; set; }
        public virtual SysAdmin ModifiedByNavigation { get; set; }
        public virtual PlanSetting Plan { get; set; }
        public virtual ReinsuranceCommission ReinsuranceCommission { get; set; }
    }
}
