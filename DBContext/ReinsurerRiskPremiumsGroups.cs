using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsurerRiskPremiumsGroups
    {
        public ReinsurerRiskPremiumsGroups()
        {
            ReinsurerQstRpgMap = new HashSet<ReinsurerQstRpgMap>();
            ReinsurerRiskPremiumsMap = new HashSet<ReinsurerRiskPremiumsMap>();
        }

        public Guid Id { get; set; }
        public Guid QstId { get; set; }
        public string RrpgCode { get; set; }
        public string RrpgName { get; set; }
        public short StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ReinsurerQstreaties Qst { get; set; }
        public virtual ICollection<ReinsurerQstRpgMap> ReinsurerQstRpgMap { get; set; }
        public virtual ICollection<ReinsurerRiskPremiumsMap> ReinsurerRiskPremiumsMap { get; set; }
    }
}
