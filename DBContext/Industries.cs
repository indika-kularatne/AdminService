using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Industries
    {
        public Industries()
        {
            IndustryGroupsMap = new HashSet<IndustryGroupsMap>();
            IndustryOccupationMap = new HashSet<IndustryOccupationMap>();
        }

        public Guid Id { get; set; }
        public string IndustryCode { get; set; }
        public string IndustryNameInternal { get; set; }
        public string IndustryNameExternal { get; set; }
        public string IndustryClass { get; set; }
        public decimal IndustryValue { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<IndustryGroupsMap> IndustryGroupsMap { get; set; }
        public virtual ICollection<IndustryOccupationMap> IndustryOccupationMap { get; set; }
    }
}
