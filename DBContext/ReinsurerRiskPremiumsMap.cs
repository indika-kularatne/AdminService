using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsurerRiskPremiumsMap
    {
        public Guid Id { get; set; }
        public Guid ReinsurerRiskPremiumGroupId { get; set; }
        public Guid ReinsurerRiskPremiumId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ReinsurerRiskPremiums ReinsurerRiskPremium { get; set; }
        public virtual ReinsurerRiskPremiumsGroups ReinsurerRiskPremiumGroup { get; set; }
    }
}
