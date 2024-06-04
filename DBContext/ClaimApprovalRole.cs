using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimApprovalRole
    {
        public Guid Id { get; set; }
        public short RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
