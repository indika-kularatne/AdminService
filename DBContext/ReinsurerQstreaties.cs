using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsurerQstreaties
    {
        public ReinsurerQstreaties()
        {
            ReinsurerQstComm = new HashSet<ReinsurerQstComm>();
            ReinsurerQstRpgMap = new HashSet<ReinsurerQstRpgMap>();
            ReinsurerQstreatiesCriteria = new HashSet<ReinsurerQstreatiesCriteria>();
            ReinsurerRiskPremiumsGroups = new HashSet<ReinsurerRiskPremiumsGroups>();
        }

        public Guid Id { get; set; }
        public Guid BcaId { get; set; }
        public string QstCode { get; set; }
        public string QstName { get; set; }
        public decimal InsurerShare { get; set; }
        public decimal ReinsurerShare { get; set; }
        public decimal RetroShare { get; set; }
        public decimal? CompulsoryCession { get; set; }
        public short? StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public decimal? InsurerLimit { get; set; }
        public string Plans { get; set; }
        public string Riskpremiums { get; set; }
        public string Premiumlayers { get; set; }

        public virtual ReinsurerBca Bca { get; set; }
        public virtual ICollection<ReinsurerQstComm> ReinsurerQstComm { get; set; }
        public virtual ICollection<ReinsurerQstRpgMap> ReinsurerQstRpgMap { get; set; }
        public virtual ICollection<ReinsurerQstreatiesCriteria> ReinsurerQstreatiesCriteria { get; set; }
        public virtual ICollection<ReinsurerRiskPremiumsGroups> ReinsurerRiskPremiumsGroups { get; set; }
    }
}
