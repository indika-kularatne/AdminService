using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyNomineeCommunication
    {
        public Guid Id { get; set; }
        public Guid PlanSettingId { get; set; }
        public Guid? EmailMessageId { get; set; }
        public Guid? SmsMessageId { get; set; }

        public virtual PlanSetting PlanSetting { get; set; }
    }
}
