using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class IndustryOccupationMap
    {
        public Guid Id { get; set; }
        public Guid IndustryId { get; set; }
        public Guid OccupationId { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual Industries Industry { get; set; }
        public virtual Occupations Occupation { get; set; }
    }
}
