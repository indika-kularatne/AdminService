using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Reinsurers
    {
        public Reinsurers()
        {
            ReinsurerBca = new HashSet<ReinsurerBca>();
            ReinsurerPremiumLayers = new HashSet<ReinsurerPremiumLayers>();
        }

        public Guid Id { get; set; }
        public string ReinsurerCode { get; set; }
        public string ReinsurerName { get; set; }
        public string ReinsurerType { get; set; }
        public string CountryCode { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<ReinsurerBca> ReinsurerBca { get; set; }
        public virtual ICollection<ReinsurerPremiumLayers> ReinsurerPremiumLayers { get; set; }
    }
}
