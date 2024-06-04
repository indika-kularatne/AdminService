using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class TokenManagement
    {
        public int Id { get; set; }
        public string TokenName { get; set; }
        public string Token { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public int StatusId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
