using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsurerQstRpgMap
    {
        public Guid Id { get; set; }
        public Guid QstId { get; set; }
        public Guid RpgId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ReinsurerQstreaties Qst { get; set; }
        public virtual ReinsurerRiskPremiumsGroups Rpg { get; set; }
    }
}
