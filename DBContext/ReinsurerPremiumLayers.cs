using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsurerPremiumLayers
    {
        public Guid Id { get; set; }
        public Guid? ReinsurerId { get; set; }
        public string LayerName { get; set; }
        public string LayerFormula { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Reinsurers Reinsurer { get; set; }
    }
}
