using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PartnerPlanMapping
    {
        public Guid Id { get; set; }
        public Guid PartnerId { get; set; }
        public Guid PlanId { get; set; }

        public virtual PartnerManagement Partner { get; set; }
        public virtual PlanSetting Plan { get; set; }
    }
}
