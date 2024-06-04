using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyPaymentStatus
    {
        public PolicyPaymentStatus()
        {
            InverseOutstandingPaymentPolicyStatus = new HashSet<PolicyPaymentStatus>();
            PolicyPaymentReceipt = new HashSet<PolicyPaymentReceipt>();
        }

        public Guid Id { get; set; }
        public Guid PolicyPaymentProjectionId { get; set; }
        public DateTime PolicyPaymentProjectionBillingDate { get; set; }
        public long Status { get; set; }
        public Guid PaymentProviderId { get; set; }
        public Guid PaymentOptionId { get; set; }
        public decimal Premium { get; set; }
        public string RequestJson { get; set; }
        public int? PreResponseStatus { get; set; }
        public string PreResponseError { get; set; }
        public int? PostResponseStatus { get; set; }
        public string PostResponseError { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? PreResponseDate { get; set; }
        public DateTime? PostResponseDate { get; set; }
        public int? TryCount { get; set; }
        public Guid? PaymentBatchLogId { get; set; }
        public Guid? PolicyId { get; set; }
        public DateTime? ActualBillingDate { get; set; }
        public string PolicyNo { get; set; }
        public bool? IsReminderSent { get; set; }
        public Guid? OutstandingPaymentPolicyStatusId { get; set; }
        public decimal? OutstandingAmount { get; set; }
        public decimal? RequestAmount { get; set; }

        public virtual PolicyPaymentStatus OutstandingPaymentPolicyStatus { get; set; }
        public virtual PaymentBatchLog PaymentBatchLog { get; set; }
        public virtual PaymentOptions PaymentOption { get; set; }
        public virtual PaymentProviders PaymentProvider { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual PolicyPaymentProjection PolicyPaymentProjection { get; set; }
        public virtual ICollection<PolicyPaymentStatus> InverseOutstandingPaymentPolicyStatus { get; set; }
        public virtual ICollection<PolicyPaymentReceipt> PolicyPaymentReceipt { get; set; }
    }
}
