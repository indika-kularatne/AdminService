using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyDependent
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public Guid DependentPolicyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public short RelationshipToParent { get; set; }
    }
}
