using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class IndustryGroups
    {
        public IndustryGroups()
        {
            IndustryGroupsMap = new HashSet<IndustryGroupsMap>();
            PlanSettingIndustriesMap = new HashSet<PlanSettingIndustriesMap>();
        }

        public Guid Id { get; set; }
        public string IndustryGroupCode { get; set; }
        public string IndustryGroupName { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<IndustryGroupsMap> IndustryGroupsMap { get; set; }
        public virtual ICollection<PlanSettingIndustriesMap> PlanSettingIndustriesMap { get; set; }
    }
}
