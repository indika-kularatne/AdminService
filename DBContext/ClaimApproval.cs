using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimApproval
    {
        public ClaimApproval()
        {
            ClaimApprovalMapping = new HashSet<ClaimApprovalMapping>();
        }

        public Guid Id { get; set; }
        public string WorkflowName { get; set; }
        public short ApprovalType { get; set; }
        public short? ClaimCategory { get; set; }
        public decimal? ClaimAmount { get; set; }

        public virtual ICollection<ClaimApprovalMapping> ClaimApprovalMapping { get; set; }
    }
}
