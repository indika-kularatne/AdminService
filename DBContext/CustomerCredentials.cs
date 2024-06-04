using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class CustomerCredentials
    {
        public Guid Id { get; set; }
        public Guid Customerid { get; set; }
        public int? Rsuserid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Tpin { get; set; }
        public string Credentialhistory { get; set; }
        public string Logindetails { get; set; }
        public int? Attempts { get; set; }
        public bool? IsLocked { get; set; }
        public DateTime? LockDate { get; set; }
        public DateTime? LockResetDate { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? NextLoginBefore { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual Customers IdNavigation { get; set; }
    }
}
