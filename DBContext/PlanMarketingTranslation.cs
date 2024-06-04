using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanMarketingTranslation
    {
        public Guid Id { get; set; }
        public Guid PlanMarketingId { get; set; }
        public string Locale { get; set; }
        public string Content { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual PlanMarketing PlanMarketing { get; set; }
    }
}
