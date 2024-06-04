using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Policy
    {
        public Policy()
        {
            ApiCommunicationLog = new HashSet<ApiCommunicationLog>();
            InverseParentPolicy = new HashSet<Policy>();
            PaymentTransactionProvider = new HashSet<PaymentTransactionProvider>();
            PolicyAttachmentLog = new HashSet<PolicyAttachmentLog>();
            PolicyCommunication = new HashSet<PolicyCommunication>();
            PolicyHolder = new HashSet<PolicyHolder>();
            PolicyHolderEndorsement = new HashSet<PolicyHolderEndorsement>();
            PolicyJournal = new HashSet<PolicyJournal>();
            PolicyMasterDetails = new HashSet<PolicyMasterDetails>();
            PolicyNominee = new HashSet<PolicyNominee>();
            PolicyPaymentProjection = new HashSet<PolicyPaymentProjection>();
            PolicyPaymentStatus = new HashSet<PolicyPaymentStatus>();
            PolicyPaymentToken = new HashSet<PolicyPaymentToken>();
            PolicyPremiumBreakdown = new HashSet<PolicyPremiumBreakdown>();
            PolicyRequestResponse = new HashSet<PolicyRequestResponse>();
            PolicyTrustee = new HashSet<PolicyTrustee>();
            PolicyUw = new HashSet<PolicyUw>();
            PolicyWitness = new HashSet<PolicyWitness>();
            SapJournalEntry = new HashSet<SapJournalEntry>();
        }

        public Guid Id { get; set; }
        public Guid PolicyRequestId { get; set; }
        public Guid PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PremiumAmount { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public short StatusId { get; set; }
        public string PolicyNo { get; set; }
        public DateTime? StatusCoiSent { get; set; }
        public Guid? ParentPolicyId { get; set; }
        public string CurrencyCode { get; set; }
        public string ExtensionJson { get; set; }
        public string Channel { get; set; }
        public string ConfirmRequest { get; set; }
        public bool IsMasterPolicy { get; set; }
        public string RefPolicyNo { get; set; }
        public decimal? SumInsured { get; set; }
        public Guid? DependentPolicyId { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? DistributionpartnerId { get; set; }
        public string TpaInfo { get; set; }
        public string Treatment { get; set; }
        public string InvoiceNo { get; set; }

        public virtual Policy ParentPolicy { get; set; }
        public virtual PlanSetting Plan { get; set; }
        public virtual ICollection<ApiCommunicationLog> ApiCommunicationLog { get; set; }
        public virtual ICollection<Policy> InverseParentPolicy { get; set; }
        public virtual ICollection<PaymentTransactionProvider> PaymentTransactionProvider { get; set; }
        public virtual ICollection<PolicyAttachmentLog> PolicyAttachmentLog { get; set; }
        public virtual ICollection<PolicyCommunication> PolicyCommunication { get; set; }
        public virtual ICollection<PolicyHolder> PolicyHolder { get; set; }
        public virtual ICollection<PolicyHolderEndorsement> PolicyHolderEndorsement { get; set; }
        public virtual ICollection<PolicyJournal> PolicyJournal { get; set; }
        public virtual ICollection<PolicyMasterDetails> PolicyMasterDetails { get; set; }
        public virtual ICollection<PolicyNominee> PolicyNominee { get; set; }
        public virtual ICollection<PolicyPaymentProjection> PolicyPaymentProjection { get; set; }
        public virtual ICollection<PolicyPaymentStatus> PolicyPaymentStatus { get; set; }
        public virtual ICollection<PolicyPaymentToken> PolicyPaymentToken { get; set; }
        public virtual ICollection<PolicyPremiumBreakdown> PolicyPremiumBreakdown { get; set; }
        public virtual ICollection<PolicyRequestResponse> PolicyRequestResponse { get; set; }
        public virtual ICollection<PolicyTrustee> PolicyTrustee { get; set; }
        public virtual ICollection<PolicyUw> PolicyUw { get; set; }
        public virtual ICollection<PolicyWitness> PolicyWitness { get; set; }
        public virtual ICollection<SapJournalEntry> SapJournalEntry { get; set; }
    }
}
