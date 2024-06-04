using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class IndustryGroupsMap
    {
        public Guid Id { get; set; }
        public Guid IndustryGroupId { get; set; }
        public Guid IndustryId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? StatusId { get; set; }

        public virtual Industries Industry { get; set; }
        public virtual IndustryGroups IndustryGroup { get; set; }
    }
}
