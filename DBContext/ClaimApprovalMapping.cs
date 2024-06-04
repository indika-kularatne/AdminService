using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimApprovalMapping
    {
        public Guid Id { get; set; }
        public Guid ClaimApprovalId { get; set; }
        public short StatusId { get; set; }
        public short RoleId { get; set; }

        public virtual ClaimApproval ClaimApproval { get; set; }
    }
}
