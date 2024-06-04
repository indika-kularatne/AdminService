using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSettingBillingRetryRules
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public decimal? MinMonthlyPremiumAmount { get; set; }
        public decimal? MaxMonthlyPremiumAmount { get; set; }
        public short? MaxRetriesMonthly { get; set; }
        public short? MaxRetriesAnnually { get; set; }
        public short? MaxRetriesLifetime { get; set; }
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
