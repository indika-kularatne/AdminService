using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanMarketing
    {
        public PlanMarketing()
        {
            PlanMarketingMap = new HashSet<PlanMarketingMap>();
            PlanMarketingTranslation = new HashSet<PlanMarketingTranslation>();
        }

        public Guid Id { get; set; }
        public string MarketingName { get; set; }
        public string MarketingDescription { get; set; }
        public string HtmlBody { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public short? StatusId { get; set; }

        public virtual ICollection<PlanMarketingMap> PlanMarketingMap { get; set; }
        public virtual ICollection<PlanMarketingTranslation> PlanMarketingTranslation { get; set; }
    }
}
