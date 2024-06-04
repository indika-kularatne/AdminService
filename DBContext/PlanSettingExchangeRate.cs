﻿using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSettingExchangeRate
    {
        public Guid Id { get; set; }
        public Guid PlanSettingId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CurrencyRate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual PlanSetting PlanSetting { get; set; }
    }
}
