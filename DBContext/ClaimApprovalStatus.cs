using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimApprovalStatus
    {
        public Guid Id { get; set; }
        public short StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
