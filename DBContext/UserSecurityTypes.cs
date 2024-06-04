using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class UserSecurityTypes
    {
        public Guid Id { get; set; }
        public Guid? Entityid { get; set; }
        public string Description { get; set; }
        public int? AccountLockPeriod { get; set; }
        public int? LoginAttempts { get; set; }
        public int? LoginTimeOut { get; set; }
        public int? MaxLength { get; set; }
        public int? MinLength { get; set; }
        public int? PasswordExpiry { get; set; }
        public string Pattern { get; set; }
        public bool? ResetOnFirstLogin { get; set; }
        public int? TacExpiry { get; set; }
        public int? TacLength { get; set; }
        public int? VerificationAttempts { get; set; }
        public int? SecuritySettingId { get; set; }
        public int? ActivationCodeExpiry { get; set; }
        public bool? IsTacRequired { get; set; }
        public int? LastPasswordHistoryLimit { get; set; }
        public int? TacVerificationAttempts { get; set; }
        public bool? AppRedirection { get; set; }
        public long? InactivityPeriodInDays { get; set; }
        public bool? IsTacRequiredForWeb { get; set; }
        public int? AccessTokenValidity { get; set; }
        public int? RefreshTokenValidity { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsWeb { get; set; }
        public bool? IsMobile { get; set; }
        public bool? IsDefault { get; set; }

        public virtual Entities Entity { get; set; }
    }
}
