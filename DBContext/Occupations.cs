using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Occupations
    {
        public Occupations()
        {
            IndustryOccupationMap = new HashSet<IndustryOccupationMap>();
        }

        public Guid Id { get; set; }
        public string OccCode { get; set; }
        public string OccNameInternal { get; set; }
        public string OccNameExternal { get; set; }
        public string OccClass { get; set; }
        public decimal OccScore { get; set; }
        public decimal OccValue { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<IndustryOccupationMap> IndustryOccupationMap { get; set; }
    }
}
