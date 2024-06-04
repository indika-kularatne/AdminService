using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSettingExchangeRateSchedule
    {
        public Guid Id { get; set; }
        public Guid PlanSettingId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CurrencyRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanSetting PlanSetting { get; set; }
    }
}
