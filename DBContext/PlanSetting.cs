using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSetting
    {
        public PlanSetting()
        {
            InversePlanParent = new HashSet<PlanSetting>();
            PartnerPlanMapping = new HashSet<PartnerPlanMapping>();
            PlanBenefitMap = new HashSet<PlanBenefitMap>();
            PlanCertificateMap = new HashSet<PlanCertificateMap>();
            PlanCustomInputTemplateMap = new HashSet<PlanCustomInputTemplateMap>();
            PlanExternalApi = new HashSet<PlanExternalApi>();
            PlanFormulaMaster = new HashSet<PlanFormulaMaster>();
            PlanMarketingMap = new HashSet<PlanMarketingMap>();
            PlanMessageMap = new HashSet<PlanMessageMap>();
            PlanPromoCodeMap = new HashSet<PlanPromoCodeMap>();
            PlanSettingBillingRetryRules = new HashSet<PlanSettingBillingRetryRules>();
            PlanSettingCommencementGroupMap = new HashSet<PlanSettingCommencementGroupMap>();
            PlanSettingCommissions = new HashSet<PlanSettingCommissions>();
            PlanSettingConfig = new HashSet<PlanSettingConfig>();
            PlanSettingExchangeRate = new HashSet<PlanSettingExchangeRate>();
            PlanSettingExchangeRateLog = new HashSet<PlanSettingExchangeRateLog>();
            PlanSettingExchangeRateSchedule = new HashSet<PlanSettingExchangeRateSchedule>();
            PlanSettingIndustriesMap = new HashSet<PlanSettingIndustriesMap>();
            PlanSettingMapChildPlan = new HashSet<PlanSettingMap>();
            PlanSettingMapParentPlan = new HashSet<PlanSettingMap>();
            PlanSettingModule = new HashSet<PlanSettingModule>();
            PlanSettingPaymentFreqMap = new HashSet<PlanSettingPaymentFreqMap>();
            PlanSettingPaymentOptions = new HashSet<PlanSettingPaymentOptions>();
            PlanSettingReinsuranceCommissions = new HashSet<PlanSettingReinsuranceCommissions>();
            PlanSettingRevivalRules = new HashSet<PlanSettingRevivalRules>();
            PlanSettingSerial = new HashSet<PlanSettingSerial>();
            PlanUwGroupMap = new HashSet<PlanUwGroupMap>();
            PlanUwPermutations = new HashSet<PlanUwPermutations>();
            Policy = new HashSet<Policy>();
            PolicyMasterDetails = new HashSet<PolicyMasterDetails>();
            PolicyNomineeCommunication = new HashSet<PolicyNomineeCommunication>();
            ReinsurerQstComm = new HashSet<ReinsurerQstComm>();
            SapJournals = new HashSet<SapJournals>();
        }

        public Guid Id { get; set; }
        public string PlanCode { get; set; }
        public string PlanDescription { get; set; }
        public short? StatusId { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool StatusPurgedata { get; set; }
        public bool StatusEncryptdata { get; set; }
        public Guid? InsurerId { get; set; }
        public Guid? PlanParentId { get; set; }
        public int Category { get; set; }
        public short MaxPolicyHolder { get; set; }
        public short MaxInsuredPerson { get; set; }
        public int? PlanMajorClassId { get; set; }
        public int? PlanSubClassId { get; set; }
        public bool IsMasterPolicy { get; set; }
        public Guid? QuoteSerialId { get; set; }
        public decimal? SumInsured { get; set; }
        public short? MinInsuredPerson { get; set; }
        public short? MinPolicyHolder { get; set; }
        public string PlanAgeRestrictions { get; set; }
        public decimal? MinSumInsured { get; set; }
        public decimal? MaxSumInsured { get; set; }
        public decimal? OverallAnnualLimit { get; set; }
        public short? RenewalActionLimit { get; set; }
        public short? ClaimActionFullLimit { get; set; }

        public virtual PlanSetting PlanParent { get; set; }
        public virtual PlanSerial QuoteSerial { get; set; }
        public virtual ICollection<PlanSetting> InversePlanParent { get; set; }
        public virtual ICollection<PartnerPlanMapping> PartnerPlanMapping { get; set; }
        public virtual ICollection<PlanBenefitMap> PlanBenefitMap { get; set; }
        public virtual ICollection<PlanCertificateMap> PlanCertificateMap { get; set; }
        public virtual ICollection<PlanCustomInputTemplateMap> PlanCustomInputTemplateMap { get; set; }
        public virtual ICollection<PlanExternalApi> PlanExternalApi { get; set; }
        public virtual ICollection<PlanFormulaMaster> PlanFormulaMaster { get; set; }
        public virtual ICollection<PlanMarketingMap> PlanMarketingMap { get; set; }
        public virtual ICollection<PlanMessageMap> PlanMessageMap { get; set; }
        public virtual ICollection<PlanPromoCodeMap> PlanPromoCodeMap { get; set; }
        public virtual ICollection<PlanSettingBillingRetryRules> PlanSettingBillingRetryRules { get; set; }
        public virtual ICollection<PlanSettingCommencementGroupMap> PlanSettingCommencementGroupMap { get; set; }
        public virtual ICollection<PlanSettingCommissions> PlanSettingCommissions { get; set; }
        public virtual ICollection<PlanSettingConfig> PlanSettingConfig { get; set; }
        public virtual ICollection<PlanSettingExchangeRate> PlanSettingExchangeRate { get; set; }
        public virtual ICollection<PlanSettingExchangeRateLog> PlanSettingExchangeRateLog { get; set; }
        public virtual ICollection<PlanSettingExchangeRateSchedule> PlanSettingExchangeRateSchedule { get; set; }
        public virtual ICollection<PlanSettingIndustriesMap> PlanSettingIndustriesMap { get; set; }
        public virtual ICollection<PlanSettingMap> PlanSettingMapChildPlan { get; set; }
        public virtual ICollection<PlanSettingMap> PlanSettingMapParentPlan { get; set; }
        public virtual ICollection<PlanSettingModule> PlanSettingModule { get; set; }
        public virtual ICollection<PlanSettingPaymentFreqMap> PlanSettingPaymentFreqMap { get; set; }
        public virtual ICollection<PlanSettingPaymentOptions> PlanSettingPaymentOptions { get; set; }
        public virtual ICollection<PlanSettingReinsuranceCommissions> PlanSettingReinsuranceCommissions { get; set; }
        public virtual ICollection<PlanSettingRevivalRules> PlanSettingRevivalRules { get; set; }
        public virtual ICollection<PlanSettingSerial> PlanSettingSerial { get; set; }
        public virtual ICollection<PlanUwGroupMap> PlanUwGroupMap { get; set; }
        public virtual ICollection<PlanUwPermutations> PlanUwPermutations { get; set; }
        public virtual ICollection<Policy> Policy { get; set; }
        public virtual ICollection<PolicyMasterDetails> PolicyMasterDetails { get; set; }
        public virtual ICollection<PolicyNomineeCommunication> PolicyNomineeCommunication { get; set; }
        public virtual ICollection<ReinsurerQstComm> ReinsurerQstComm { get; set; }
        public virtual ICollection<SapJournals> SapJournals { get; set; }
    }
}
