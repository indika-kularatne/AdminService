using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSettingConfig
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public short? GracePeriodDays { get; set; }
        public short? WaitingPeriodDays { get; set; }
        public bool? AllowClaimsDuringGracePeriod { get; set; }
        public short? PlanDurationYears { get; set; }
        public string BillingCycleDay { get; set; }
        public decimal? MaxOutstandingAmountCharged { get; set; }
        public short? MaxOutstandingMonthsCharged { get; set; }
        public short? FailedBillingNotification { get; set; }
        public bool? FailedBillingReminder { get; set; }
        public short? AdvancedBillingReminder { get; set; }
        public short? MaxLapsedBillingDays { get; set; }
        public bool? LapsedNotification { get; set; }
        public bool? AllowRevival { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public short? CancellationPeriodDays { get; set; }
        public bool? IsAllowCancellation { get; set; }
        public bool? IsAllowRefund { get; set; }
        public decimal? RefundRate { get; set; }
        public Guid? FailedBillingNotificationTemplateSms { get; set; }
        public Guid? FailedBillingNotificationTemplateEmail { get; set; }
        public Guid? AdvanceBillingNotificationTemplateSms { get; set; }
        public Guid? LapsedBillingNotificationTemplateSms { get; set; }
        public Guid? LapsedBillingNotificationTemplateEmail { get; set; }
        public Guid? AdvanceBillingNotificationTemplateEmail { get; set; }
        public string AdditionalRules { get; set; }
        public Guid? SuccessBillingNotificationTemplateEmail { get; set; }
        public string LapsedBillingNotificationTemplateEmailJson { get; set; }

        public virtual PlanSetting Plan { get; set; }
    }
}
