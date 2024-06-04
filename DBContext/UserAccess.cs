using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class UserAccess
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public short AccessRoleId { get; set; }
        public short StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
