using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsurerRiskPremiums
    {
        public ReinsurerRiskPremiums()
        {
            ReinsurerRiskPremiumsMap = new HashSet<ReinsurerRiskPremiumsMap>();
        }

        public Guid Id { get; set; }
        public string RrpName { get; set; }
        public string TableJson { get; set; }
        public short StatusId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string DocName { get; set; }
        public string TableColumns { get; set; }
        public Guid? ReinsurerId { get; set; }

        public virtual ICollection<ReinsurerRiskPremiumsMap> ReinsurerRiskPremiumsMap { get; set; }
    }
}
