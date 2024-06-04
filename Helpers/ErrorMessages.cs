namespace AdminService.Helpers
{
    public static class ErrorMessages
    {
        public static readonly string ACCOUNT_IS_LOCKED = "Account is locked.";
        public static readonly string NOT_ALLOWED_PREVIOUS_PASSWORD = "Must NOT be same of the last ";
        public static readonly string NOT_ALLOWED_PREVIOUS_PASSWORD_2 = "{0} used password.";
        public static readonly string NOT_ALLOWED_UNLOCK_OWN_ACCOUNT = "User is not allowed to unlock own account.";
        public static readonly string ERROR_IN_UNLOCK_ACCOUNT = "Error when unlocking user. Please contact administrator.";
        public static readonly string FAILED_MIN_PASSWORD_AGE = "Not allowed to change password due to failed to meet min password age.";
        public static readonly string FAILED_MIN_PASSWORD_AGE_2 = "You are allowed to change password after {0:yyyy/MM/dd hh:mm:ss tt}.";
    }
}
