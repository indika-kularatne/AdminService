using System;

namespace AdminService.Models
{
    public class AdminModel : BaseModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Guid RoleUUID { get; set; }

        public bool IsRequiredChangePassword { get; set; }

        public bool IsLocked { get; set; }

        public DateTime? PasswordExpiryDate { get; set; }
    }
}
