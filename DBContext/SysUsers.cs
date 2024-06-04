using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysUsers
    {
        public SysUsers()
        {
            SysAdmin = new HashSet<SysAdmin>();
            SysUsersIp = new HashSet<SysUsersIp>();
            SysUsersUnderwriters = new HashSet<SysUsersUnderwriters>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public int? Acid { get; set; }
        public int? Usertype { get; set; }
        public int? Accessid { get; set; }
        public DateTime? Efffromdate { get; set; }
        public DateTime? Efftodate { get; set; }
        public int? Statusid { get; set; }
        public DateTime Crdt { get; set; }
        public Guid? Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public Guid Useruuid { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual ICollection<SysAdmin> SysAdmin { get; set; }
        public virtual ICollection<SysUsersIp> SysUsersIp { get; set; }
        public virtual ICollection<SysUsersUnderwriters> SysUsersUnderwriters { get; set; }
    }
}
