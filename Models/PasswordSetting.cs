namespace AdminService.Models
{
    public class PasswordSetting
    {
        public int DefaultLength { get; set; }
        public int MinPasswordAge { get; set; }
        public int MaxPasswordAge { get; set; }
        public int EnforcePasswordHistory { get; set; }
        public int AccountLockoutAttempt { get; set; }
        public int? AccountLockoutDuration { get; set; }
    }
}
