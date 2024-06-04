using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AdminService.DBContext
{
    public partial class pgzeusContext : DbContext
    {
        public pgzeusContext()
        {
        }

        public pgzeusContext(DbContextOptions<pgzeusContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<ActionLog> ActionLog { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<ApiCommunicationLog> ApiCommunicationLog { get; set; }
        public virtual DbSet<AuditAdminActions> AuditAdminActions { get; set; }
        public virtual DbSet<AuditAdminEvents> AuditAdminEvents { get; set; }
        public virtual DbSet<AuditGetquote> AuditGetquote { get; set; }
        public virtual DbSet<AuditLog> AuditLog { get; set; }
        public virtual DbSet<AuditLogins> AuditLogins { get; set; }
        public virtual DbSet<AuditOutboundVoice> AuditOutboundVoice { get; set; }
        public virtual DbSet<AuditPolicyCancellations> AuditPolicyCancellations { get; set; }
        public virtual DbSet<AuditPolicyRefund> AuditPolicyRefund { get; set; }
        public virtual DbSet<AuditSapJournals> AuditSapJournals { get; set; }
        public virtual DbSet<AuditSms> AuditSms { get; set; }
        public virtual DbSet<AuditWeatherIndex> AuditWeatherIndex { get; set; }
        public virtual DbSet<AuditWebservices> AuditWebservices { get; set; }
        public virtual DbSet<AuditWsPlanprofiles> AuditWsPlanprofiles { get; set; }
        public virtual DbSet<Authorisationapi> Authorisationapi { get; set; }
        public virtual DbSet<BankingDetails> BankingDetails { get; set; }
        public virtual DbSet<Benefits> Benefits { get; set; }
        public virtual DbSet<Claim> Claim { get; set; }
        public virtual DbSet<ClaimApproval> ClaimApproval { get; set; }
        public virtual DbSet<ClaimApprovalMapping> ClaimApprovalMapping { get; set; }
        public virtual DbSet<ClaimApprovalRole> ClaimApprovalRole { get; set; }
        public virtual DbSet<ClaimApprovalStatus> ClaimApprovalStatus { get; set; }
        public virtual DbSet<ClaimDueAccident> ClaimDueAccident { get; set; }
        public virtual DbSet<ClaimEmail> ClaimEmail { get; set; }
        public virtual DbSet<ClaimHistoryLog> ClaimHistoryLog { get; set; }
        public virtual DbSet<ClaimHolderContactLog> ClaimHolderContactLog { get; set; }
        public virtual DbSet<ClaimHolderLog> ClaimHolderLog { get; set; }
        public virtual DbSet<ClaimIllness> ClaimIllness { get; set; }
        public virtual DbSet<ClaimLifeAssured> ClaimLifeAssured { get; set; }
        public virtual DbSet<ClaimMessageMap> ClaimMessageMap { get; set; }
        public virtual DbSet<ClaimPaidTo> ClaimPaidTo { get; set; }
        public virtual DbSet<ClaimSupportingDocuments> ClaimSupportingDocuments { get; set; }
        public virtual DbSet<ClaimantDetails> ClaimantDetails { get; set; }
        public virtual DbSet<Claimquestions> Claimquestions { get; set; }
        public virtual DbSet<Claimreasons> Claimreasons { get; set; }
        public virtual DbSet<ClaimsIhp> ClaimsIhp { get; set; }
        public virtual DbSet<ClaimsNew> ClaimsNew { get; set; }
        public virtual DbSet<Clinics> Clinics { get; set; }
        public virtual DbSet<ConsAdvancedRaw> ConsAdvancedRaw { get; set; }
        public virtual DbSet<Contactpersons> Contactpersons { get; set; }
        public virtual DbSet<CryptographyKeyFile> CryptographyKeyFile { get; set; }
        public virtual DbSet<CustomerCredentials> CustomerCredentials { get; set; }
        public virtual DbSet<CustomerDevices> CustomerDevices { get; set; }
        public virtual DbSet<CustomerRisks> CustomerRisks { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DebugLog> DebugLog { get; set; }
        public virtual DbSet<DefaultSettings> DefaultSettings { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<Ecards> Ecards { get; set; }
        public virtual DbSet<EltBatchProcess> EltBatchProcess { get; set; }
        public virtual DbSet<EltDataTable> EltDataTable { get; set; }
        public virtual DbSet<EltProcessFlows> EltProcessFlows { get; set; }
        public virtual DbSet<EltSettingLog> EltSettingLog { get; set; }
        public virtual DbSet<EltSettingNotification> EltSettingNotification { get; set; }
        public virtual DbSet<EltSettings> EltSettings { get; set; }
        public virtual DbSet<Emailtemplate> Emailtemplate { get; set; }
        public virtual DbSet<Enquiry> Enquiry { get; set; }
        public virtual DbSet<Entities> Entities { get; set; }
        public virtual DbSet<Entitlements> Entitlements { get; set; }
        public virtual DbSet<GenericApplicationLog> GenericApplicationLog { get; set; }
        public virtual DbSet<Guaranteeletters> Guaranteeletters { get; set; }
        public virtual DbSet<Hospital> Hospital { get; set; }
        public virtual DbSet<Industries> Industries { get; set; }
        public virtual DbSet<IndustryGroups> IndustryGroups { get; set; }
        public virtual DbSet<IndustryGroupsMap> IndustryGroupsMap { get; set; }
        public virtual DbSet<IndustryOccupationMap> IndustryOccupationMap { get; set; }
        public virtual DbSet<InsBookingclass> InsBookingclass { get; set; }
        public virtual DbSet<InsCampaigns> InsCampaigns { get; set; }
        public virtual DbSet<InsCarrierBookings> InsCarrierBookings { get; set; }
        public virtual DbSet<InsCarrierFares> InsCarrierFares { get; set; }
        public virtual DbSet<InsCarrierFaretiers> InsCarrierFaretiers { get; set; }
        public virtual DbSet<InsCarriers> InsCarriers { get; set; }
        public virtual DbSet<InsCiTemplates> InsCiTemplates { get; set; }
        public virtual DbSet<InsEmails> InsEmails { get; set; }
        public virtual DbSet<InsFareclass> InsFareclass { get; set; }
        public virtual DbSet<InsFaretierRanges> InsFaretierRanges { get; set; }
        public virtual DbSet<InsFaretiers> InsFaretiers { get; set; }
        public virtual DbSet<InsJourneys> InsJourneys { get; set; }
        public virtual DbSet<InsPartnerKeys> InsPartnerKeys { get; set; }
        public virtual DbSet<InsPlans> InsPlans { get; set; }
        public virtual DbSet<InsPlansCategories> InsPlansCategories { get; set; }
        public virtual DbSet<InsPlansCategoriesPlans> InsPlansCategoriesPlans { get; set; }
        public virtual DbSet<InsPlansCategoriesPlansLog> InsPlansCategoriesPlansLog { get; set; }
        public virtual DbSet<InsPlansMarketing> InsPlansMarketing { get; set; }
        public virtual DbSet<InsPlansMarketingOwn> InsPlansMarketingOwn { get; set; }
        public virtual DbSet<InsPlansMarketingPointers> InsPlansMarketingPointers { get; set; }
        public virtual DbSet<InsPlansMarketingSub> InsPlansMarketingSub { get; set; }
        public virtual DbSet<InsPlansProfiles> InsPlansProfiles { get; set; }
        public virtual DbSet<InsPlansProfilesMarketing> InsPlansProfilesMarketing { get; set; }
        public virtual DbSet<InsPlansProfilesSub> InsPlansProfilesSub { get; set; }
        public virtual DbSet<InsPlansProfilesUpsell> InsPlansProfilesUpsell { get; set; }
        public virtual DbSet<InsPlansRestrictions> InsPlansRestrictions { get; set; }
        public virtual DbSet<InsPlansRoutes> InsPlansRoutes { get; set; }
        public virtual DbSet<InsPlansSerialRange> InsPlansSerialRange { get; set; }
        public virtual DbSet<InsPolicyContactPersonZeus> InsPolicyContactPersonZeus { get; set; }
        public virtual DbSet<InsPolicyCoverageEncrypted> InsPolicyCoverageEncrypted { get; set; }
        public virtual DbSet<InsPolicyCoveragePersonZeus> InsPolicyCoveragePersonZeus { get; set; }
        public virtual DbSet<InsPolicyDetailActionsZeus> InsPolicyDetailActionsZeus { get; set; }
        public virtual DbSet<InsPolicyDetailZeus> InsPolicyDetailZeus { get; set; }
        public virtual DbSet<InsPolicyPaymentStatus> InsPolicyPaymentStatus { get; set; }
        public virtual DbSet<InsPolicyPaymentStatusLog> InsPolicyPaymentStatusLog { get; set; }
        public virtual DbSet<InsPolicyPremiumLoad> InsPolicyPremiumLoad { get; set; }
        public virtual DbSet<InsPolicySent> InsPolicySent { get; set; }
        public virtual DbSet<InsPolicySerialRange> InsPolicySerialRange { get; set; }
        public virtual DbSet<InsPolicyStates> InsPolicyStates { get; set; }
        public virtual DbSet<InsPolicyUnsentZeus> InsPolicyUnsentZeus { get; set; }
        public virtual DbSet<InsRaces> InsRaces { get; set; }
        public virtual DbSet<InsRatings> InsRatings { get; set; }
        public virtual DbSet<InsRoutes> InsRoutes { get; set; }
        public virtual DbSet<InsUnderwriters> InsUnderwriters { get; set; }
        public virtual DbSet<InsUnderwritersReports> InsUnderwritersReports { get; set; }
        public virtual DbSet<Insurers> Insurers { get; set; }
        public virtual DbSet<InsurersExpenseGroups> InsurersExpenseGroups { get; set; }
        public virtual DbSet<InsurersExpenses> InsurersExpenses { get; set; }
        public virtual DbSet<LookupReference> LookupReference { get; set; }
        public virtual DbSet<Medcards> Medcards { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Occupations> Occupations { get; set; }
        public virtual DbSet<OrganizationEmployee> OrganizationEmployee { get; set; }
        public virtual DbSet<OrganizationEmployeeDocuments> OrganizationEmployeeDocuments { get; set; }
        public virtual DbSet<Otps> Otps { get; set; }
        public virtual DbSet<PartnerIncentive> PartnerIncentive { get; set; }
        public virtual DbSet<PartnerIncentiveJournal> PartnerIncentiveJournal { get; set; }
        public virtual DbSet<PartnerIncentiveStructure> PartnerIncentiveStructure { get; set; }
        public virtual DbSet<PartnerManagement> PartnerManagement { get; set; }
        public virtual DbSet<PartnerOrganization> PartnerOrganization { get; set; }
        public virtual DbSet<PartnerOrganizationIncentive> PartnerOrganizationIncentive { get; set; }
        public virtual DbSet<PartnerPlanMapping> PartnerPlanMapping { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<PaymentBatchLog> PaymentBatchLog { get; set; }
        public virtual DbSet<PaymentOptions> PaymentOptions { get; set; }
        public virtual DbSet<PaymentProcess> PaymentProcess { get; set; }
        public virtual DbSet<PaymentProcessItem> PaymentProcessItem { get; set; }
        public virtual DbSet<PaymentProviders> PaymentProviders { get; set; }
        public virtual DbSet<PaymentRequest> PaymentRequest { get; set; }
        public virtual DbSet<PaymentRequestValidation> PaymentRequestValidation { get; set; }
        public virtual DbSet<PaymentTransactionProvider> PaymentTransactionProvider { get; set; }
        public virtual DbSet<PgStatStatements> PgStatStatements { get; set; }
        public virtual DbSet<PgStatStatementsInfo> PgStatStatementsInfo { get; set; }
        public virtual DbSet<PlanBenefit> PlanBenefit { get; set; }
        public virtual DbSet<PlanBenefitCategory> PlanBenefitCategory { get; set; }
        public virtual DbSet<PlanBenefitConfig> PlanBenefitConfig { get; set; }
        public virtual DbSet<PlanBenefitCustomInput> PlanBenefitCustomInput { get; set; }
        public virtual DbSet<PlanBenefitCustomInputList> PlanBenefitCustomInputList { get; set; }
        public virtual DbSet<PlanBenefitCustomInputTemplate> PlanBenefitCustomInputTemplate { get; set; }
        public virtual DbSet<PlanBenefitCustomInputTemplateItem> PlanBenefitCustomInputTemplateItem { get; set; }
        public virtual DbSet<PlanBenefitCustomInputTemplateMap> PlanBenefitCustomInputTemplateMap { get; set; }
        public virtual DbSet<PlanBenefitCustomInputType> PlanBenefitCustomInputType { get; set; }
        public virtual DbSet<PlanBenefitGroup> PlanBenefitGroup { get; set; }
        public virtual DbSet<PlanBenefitGroupConfig> PlanBenefitGroupConfig { get; set; }
        public virtual DbSet<PlanBenefitGroupMap> PlanBenefitGroupMap { get; set; }
        public virtual DbSet<PlanBenefitMap> PlanBenefitMap { get; set; }
        public virtual DbSet<PlanBenefitRate> PlanBenefitRate { get; set; }
        public virtual DbSet<PlanBenefitSupportingDocuments> PlanBenefitSupportingDocuments { get; set; }
        public virtual DbSet<PlanBenefitSupportingDocumentsMap> PlanBenefitSupportingDocumentsMap { get; set; }
        public virtual DbSet<PlanBenefitSupportingDocumentsTranslation> PlanBenefitSupportingDocumentsTranslation { get; set; }
        public virtual DbSet<PlanBenefitTranslation> PlanBenefitTranslation { get; set; }
        public virtual DbSet<PlanCategory> PlanCategory { get; set; }
        public virtual DbSet<PlanCertificate> PlanCertificate { get; set; }
        public virtual DbSet<PlanCertificateMap> PlanCertificateMap { get; set; }
        public virtual DbSet<PlanCertificateTranslation> PlanCertificateTranslation { get; set; }
        public virtual DbSet<PlanClaimBenefit> PlanClaimBenefit { get; set; }
        public virtual DbSet<PlanClaimBenefitRates> PlanClaimBenefitRates { get; set; }
        public virtual DbSet<PlanCommencement> PlanCommencement { get; set; }
        public virtual DbSet<PlanCommencementGroup> PlanCommencementGroup { get; set; }
        public virtual DbSet<PlanCriteria> PlanCriteria { get; set; }
        public virtual DbSet<PlanCriteriaPremiumMap> PlanCriteriaPremiumMap { get; set; }
        public virtual DbSet<PlanCustomInput> PlanCustomInput { get; set; }
        public virtual DbSet<PlanCustomInputList> PlanCustomInputList { get; set; }
        public virtual DbSet<PlanCustomInputTemplate> PlanCustomInputTemplate { get; set; }
        public virtual DbSet<PlanCustomInputTemplateItem> PlanCustomInputTemplateItem { get; set; }
        public virtual DbSet<PlanCustomInputTemplateMap> PlanCustomInputTemplateMap { get; set; }
        public virtual DbSet<PlanExternalApi> PlanExternalApi { get; set; }
        public virtual DbSet<PlanFormula> PlanFormula { get; set; }
        public virtual DbSet<PlanFormulaMaster> PlanFormulaMaster { get; set; }
        public virtual DbSet<PlanFormulaPremiumMap> PlanFormulaPremiumMap { get; set; }
        public virtual DbSet<PlanInputType> PlanInputType { get; set; }
        public virtual DbSet<PlanMajorClass> PlanMajorClass { get; set; }
        public virtual DbSet<PlanMarketing> PlanMarketing { get; set; }
        public virtual DbSet<PlanMarketingMap> PlanMarketingMap { get; set; }
        public virtual DbSet<PlanMarketingTranslation> PlanMarketingTranslation { get; set; }
        public virtual DbSet<PlanMessage> PlanMessage { get; set; }
        public virtual DbSet<PlanMessageMap> PlanMessageMap { get; set; }
        public virtual DbSet<PlanMessageTranslation> PlanMessageTranslation { get; set; }
        public virtual DbSet<PlanPaymentFreq> PlanPaymentFreq { get; set; }
        public virtual DbSet<PlanPremiumTable> PlanPremiumTable { get; set; }
        public virtual DbSet<PlanPromoCodeMap> PlanPromoCodeMap { get; set; }
        public virtual DbSet<PlanRandomNumber> PlanRandomNumber { get; set; }
        public virtual DbSet<PlanSerial> PlanSerial { get; set; }
        public virtual DbSet<PlanSetting> PlanSetting { get; set; }
        public virtual DbSet<PlanSettingBillingRetryRules> PlanSettingBillingRetryRules { get; set; }
        public virtual DbSet<PlanSettingCommencementGroupMap> PlanSettingCommencementGroupMap { get; set; }
        public virtual DbSet<PlanSettingCommissions> PlanSettingCommissions { get; set; }
        public virtual DbSet<PlanSettingConfig> PlanSettingConfig { get; set; }
        public virtual DbSet<PlanSettingExchangeRate> PlanSettingExchangeRate { get; set; }
        public virtual DbSet<PlanSettingExchangeRateLog> PlanSettingExchangeRateLog { get; set; }
        public virtual DbSet<PlanSettingExchangeRateSchedule> PlanSettingExchangeRateSchedule { get; set; }
        public virtual DbSet<PlanSettingIndustriesMap> PlanSettingIndustriesMap { get; set; }
        public virtual DbSet<PlanSettingMap> PlanSettingMap { get; set; }
        public virtual DbSet<PlanSettingModule> PlanSettingModule { get; set; }
        public virtual DbSet<PlanSettingPaymentFreqMap> PlanSettingPaymentFreqMap { get; set; }
        public virtual DbSet<PlanSettingPaymentOptions> PlanSettingPaymentOptions { get; set; }
        public virtual DbSet<PlanSettingReinsuranceCommissions> PlanSettingReinsuranceCommissions { get; set; }
        public virtual DbSet<PlanSettingRevivalRules> PlanSettingRevivalRules { get; set; }
        public virtual DbSet<PlanSettingSerial> PlanSettingSerial { get; set; }
        public virtual DbSet<PlanSubClass> PlanSubClass { get; set; }
        public virtual DbSet<PlanUwAnswers> PlanUwAnswers { get; set; }
        public virtual DbSet<PlanUwGroup> PlanUwGroup { get; set; }
        public virtual DbSet<PlanUwGroupMap> PlanUwGroupMap { get; set; }
        public virtual DbSet<PlanUwPermutationFormulaMap> PlanUwPermutationFormulaMap { get; set; }
        public virtual DbSet<PlanUwPermutations> PlanUwPermutations { get; set; }
        public virtual DbSet<PlanUwQuestions> PlanUwQuestions { get; set; }
        public virtual DbSet<PlanUwQuestionsMap> PlanUwQuestionsMap { get; set; }
        public virtual DbSet<PlanUwQuestionsTranslation> PlanUwQuestionsTranslation { get; set; }
        public virtual DbSet<PlanVariable> PlanVariable { get; set; }
        public virtual DbSet<Policy> Policy { get; set; }
        public virtual DbSet<PolicyAttachmentLog> PolicyAttachmentLog { get; set; }
        public virtual DbSet<PolicyCancellation> PolicyCancellation { get; set; }
        public virtual DbSet<PolicyCommunication> PolicyCommunication { get; set; }
        public virtual DbSet<PolicyCompanyWitness> PolicyCompanyWitness { get; set; }
        public virtual DbSet<PolicyDependent> PolicyDependent { get; set; }
        public virtual DbSet<PolicyHolder> PolicyHolder { get; set; }
        public virtual DbSet<PolicyHolderContact> PolicyHolderContact { get; set; }
        public virtual DbSet<PolicyHolderEndorsement> PolicyHolderEndorsement { get; set; }
        public virtual DbSet<PolicyJournal> PolicyJournal { get; set; }
        public virtual DbSet<PolicyMasterDetails> PolicyMasterDetails { get; set; }
        public virtual DbSet<PolicyNominee> PolicyNominee { get; set; }
        public virtual DbSet<PolicyNomineeCommunication> PolicyNomineeCommunication { get; set; }
        public virtual DbSet<PolicyNomineeMessage> PolicyNomineeMessage { get; set; }
        public virtual DbSet<PolicyPaymentProjection> PolicyPaymentProjection { get; set; }
        public virtual DbSet<PolicyPaymentReceipt> PolicyPaymentReceipt { get; set; }
        public virtual DbSet<PolicyPaymentStatus> PolicyPaymentStatus { get; set; }
        public virtual DbSet<PolicyPaymentToken> PolicyPaymentToken { get; set; }
        public virtual DbSet<PolicyPremiumBreakdown> PolicyPremiumBreakdown { get; set; }
        public virtual DbSet<PolicyRequestResponse> PolicyRequestResponse { get; set; }
        public virtual DbSet<PolicyTrustee> PolicyTrustee { get; set; }
        public virtual DbSet<PolicyUw> PolicyUw { get; set; }
        public virtual DbSet<PolicyWitness> PolicyWitness { get; set; }
        public virtual DbSet<PromoCodeSetting> PromoCodeSetting { get; set; }
        public virtual DbSet<ReinsuranceCommission> ReinsuranceCommission { get; set; }
        public virtual DbSet<ReinsuranceCommissionFormula> ReinsuranceCommissionFormula { get; set; }
        public virtual DbSet<ReinsuranceCommissionJournal> ReinsuranceCommissionJournal { get; set; }
        public virtual DbSet<ReinsuranceCommissionStructure> ReinsuranceCommissionStructure { get; set; }
        public virtual DbSet<ReinsurerBca> ReinsurerBca { get; set; }
        public virtual DbSet<ReinsurerPremiumLayers> ReinsurerPremiumLayers { get; set; }
        public virtual DbSet<ReinsurerQstComm> ReinsurerQstComm { get; set; }
        public virtual DbSet<ReinsurerQstFormula> ReinsurerQstFormula { get; set; }
        public virtual DbSet<ReinsurerQstFormulaMaster> ReinsurerQstFormulaMaster { get; set; }
        public virtual DbSet<ReinsurerQstRpgMap> ReinsurerQstRpgMap { get; set; }
        public virtual DbSet<ReinsurerQstreaties> ReinsurerQstreaties { get; set; }
        public virtual DbSet<ReinsurerQstreatiesCriteria> ReinsurerQstreatiesCriteria { get; set; }
        public virtual DbSet<ReinsurerRiskPremiums> ReinsurerRiskPremiums { get; set; }
        public virtual DbSet<ReinsurerRiskPremiumsGroups> ReinsurerRiskPremiumsGroups { get; set; }
        public virtual DbSet<ReinsurerRiskPremiumsMap> ReinsurerRiskPremiumsMap { get; set; }
        public virtual DbSet<Reinsurers> Reinsurers { get; set; }
        public virtual DbSet<SapJournalEntry> SapJournalEntry { get; set; }
        public virtual DbSet<SapJournalEntryLine> SapJournalEntryLine { get; set; }
        public virtual DbSet<SapJournals> SapJournals { get; set; }
        public virtual DbSet<SdnAdvanced> SdnAdvanced { get; set; }
        public virtual DbSet<SecurityQuestions> SecurityQuestions { get; set; }
        public virtual DbSet<SettingStatus> SettingStatus { get; set; }
        public virtual DbSet<SysAccessRights> SysAccessRights { get; set; }
        public virtual DbSet<SysAdmin> SysAdmin { get; set; }
        public virtual DbSet<SysAdminPasswordHistory> SysAdminPasswordHistory { get; set; }
        public virtual DbSet<SysAdminUnlockHistory> SysAdminUnlockHistory { get; set; }
        public virtual DbSet<SysAgents> SysAgents { get; set; }
        public virtual DbSet<SysAgentsFunctionsWs> SysAgentsFunctionsWs { get; set; }
        public virtual DbSet<SysAgentsIpaddresses> SysAgentsIpaddresses { get; set; }
        public virtual DbSet<SysAgentsPlans> SysAgentsPlans { get; set; }
        public virtual DbSet<SysAgentsPseudos> SysAgentsPseudos { get; set; }
        public virtual DbSet<SysAgentsVirtualsettings> SysAgentsVirtualsettings { get; set; }
        public virtual DbSet<SysAirports> SysAirports { get; set; }
        public virtual DbSet<SysCity> SysCity { get; set; }
        public virtual DbSet<SysClaimPermission> SysClaimPermission { get; set; }
        public virtual DbSet<SysCountries> SysCountries { get; set; }
        public virtual DbSet<SysCulturecodes> SysCulturecodes { get; set; }
        public virtual DbSet<SysCurrencies> SysCurrencies { get; set; }
        public virtual DbSet<SysCurrencyExchange> SysCurrencyExchange { get; set; }
        public virtual DbSet<SysCurrencyExchangeDashboard> SysCurrencyExchangeDashboard { get; set; }
        public virtual DbSet<SysForex> SysForex { get; set; }
        public virtual DbSet<SysFunctions> SysFunctions { get; set; }
        public virtual DbSet<SysFunctionsAccess> SysFunctionsAccess { get; set; }
        public virtual DbSet<SysFunctionsProcess> SysFunctionsProcess { get; set; }
        public virtual DbSet<SysFunctionsWs> SysFunctionsWs { get; set; }
        public virtual DbSet<SysGatewayAccount> SysGatewayAccount { get; set; }
        public virtual DbSet<SysLoginLog> SysLoginLog { get; set; }
        public virtual DbSet<SysMenu> SysMenu { get; set; }
        public virtual DbSet<SysMenuGroup> SysMenuGroup { get; set; }
        public virtual DbSet<SysMigrationLog> SysMigrationLog { get; set; }
        public virtual DbSet<SysOrganizations> SysOrganizations { get; set; }
        public virtual DbSet<SysRoleClaimPermission> SysRoleClaimPermission { get; set; }
        public virtual DbSet<SysRolePermission> SysRolePermission { get; set; }
        public virtual DbSet<SysRoles> SysRoles { get; set; }
        public virtual DbSet<SysRolesMenu> SysRolesMenu { get; set; }
        public virtual DbSet<SysTitles> SysTitles { get; set; }
        public virtual DbSet<SysUsers> SysUsers { get; set; }
        public virtual DbSet<SysUsersIp> SysUsersIp { get; set; }
        public virtual DbSet<SysUsersUnderwriters> SysUsersUnderwriters { get; set; }
        public virtual DbSet<SysVirtualsetting> SysVirtualsetting { get; set; }
        public virtual DbSet<SysWeatherIndex> SysWeatherIndex { get; set; }
        public virtual DbSet<TaskSchedulerJob> TaskSchedulerJob { get; set; }
        public virtual DbSet<TaskSchedulerLog> TaskSchedulerLog { get; set; }
        public virtual DbSet<TokenManagement> TokenManagement { get; set; }
        public virtual DbSet<UserAccess> UserAccess { get; set; }
        public virtual DbSet<UserSecurityTypes> UserSecurityTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=pgzeus;Username=postgres;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum(null, "dml_type", new[] { "INSERT", "UPDATE" })
                .HasPostgresExtension("pg_stat_statements")
                .HasPostgresExtension("uuid-ossp");

            modelBuilder.Entity<Action>(entity =>
            {
                entity.ToTable("action");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasColumnName("action_name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ActionLog>(entity =>
            {
                entity.ToTable("action_log");

                entity.HasIndex(e => e.ReferenceTable)
                    .HasName("idx_reference_table");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ActionType).HasColumnName("action_type");

                entity.Property(e => e.ColumnName)
                    .HasColumnName("column_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ColumnNewValue)
                    .HasColumnName("column_new_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.ColumnOldValue)
                    .HasColumnName("column_old_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.CreatedUser).HasColumnName("created_user");

                entity.Property(e => e.RecordValue)
                    .HasColumnName("record_value")
                    .HasColumnType("json");

                entity.Property(e => e.ReferenceId).HasColumnName("reference_id");

                entity.Property(e => e.ReferenceTable).HasColumnName("reference_table");

                entity.HasOne(d => d.CreatedUserNavigation)
                    .WithMany(p => p.ActionLog)
                    .HasForeignKey(d => d.CreatedUser)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_created_user");
            });

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.ToTable("addresses");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasColumnType("character varying");

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasColumnType("character varying");

                entity.Property(e => e.Address3)
                    .HasColumnName("address3")
                    .HasColumnType("character varying");

                entity.Property(e => e.Addresstype)
                    .HasColumnName("addresstype")
                    .HasColumnType("character varying");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("character varying");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("character varying");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("character varying");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasColumnType("character varying");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("character varying");

                entity.Property(e => e.Statusid).HasColumnName("statusid");
            });

            modelBuilder.Entity<ApiCommunicationLog>(entity =>
            {
                entity.ToTable("api_communication_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.ErrorException)
                    .HasColumnName("error_exception")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.PostUrl)
                    .HasColumnName("post_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReferenceCode)
                    .HasColumnName("reference_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.RequestJson)
                    .IsRequired()
                    .HasColumnName("request_json")
                    .HasColumnType("json");

                entity.Property(e => e.ResponseJson)
                    .HasColumnName("response_json")
                    .HasColumnType("json");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.ApiCommunicationLog)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_api_policy");
            });

            modelBuilder.Entity<AuditAdminActions>(entity =>
            {
                entity.HasKey(e => e.Adminactionuuid)
                    .HasName("audit_admin_actions_pkey");

                entity.ToTable("audit_admin_actions");

                entity.Property(e => e.Adminactionuuid)
                    .HasColumnName("adminactionuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(100);

                entity.Property(e => e.Actionapprovaluseruuid).HasColumnName("actionapprovaluseruuid");

                entity.Property(e => e.Actiondescription)
                    .HasColumnName("actiondescription")
                    .HasMaxLength(4000);

                entity.Property(e => e.Actionresult)
                    .HasColumnName("actionresult")
                    .HasMaxLength(50);

                entity.Property(e => e.Adminuuid).HasColumnName("adminuuid");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("module")
                    .HasMaxLength(150);

                entity.Property(e => e.Page)
                    .IsRequired()
                    .HasColumnName("page")
                    .HasMaxLength(150);

                entity.HasOne(d => d.Actionapprovaluseruu)
                    .WithMany(p => p.AuditAdminActionsActionapprovaluseruu)
                    .HasForeignKey(d => d.Actionapprovaluseruuid)
                    .HasConstraintName("audit_admin_actions_actionapprovaluseruuid_fkey");

                entity.HasOne(d => d.Adminuu)
                    .WithMany(p => p.AuditAdminActionsAdminuu)
                    .HasForeignKey(d => d.Adminuuid)
                    .HasConstraintName("audit_admin_actions_adminuuid_fkey");
            });

            modelBuilder.Entity<AuditAdminEvents>(entity =>
            {
                entity.HasKey(e => e.Auditadmineventuuid)
                    .HasName("audit_admin_events_pkey");

                entity.ToTable("audit_admin_events");

                entity.Property(e => e.Auditadmineventuuid)
                    .HasColumnName("auditadmineventuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(100);

                entity.Property(e => e.Actionapprovaluseruuid).HasColumnName("actionapprovaluseruuid");

                entity.Property(e => e.Actiondescription)
                    .HasColumnName("actiondescription")
                    .HasMaxLength(4000);

                entity.Property(e => e.Actionresult)
                    .HasColumnName("actionresult")
                    .HasMaxLength(50);

                entity.Property(e => e.Adminid).HasColumnName("adminid");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("module")
                    .HasMaxLength(150);

                entity.Property(e => e.Page)
                    .IsRequired()
                    .HasColumnName("page")
                    .HasMaxLength(150);

                entity.HasOne(d => d.Actionapprovaluseruu)
                    .WithMany(p => p.AuditAdminEvents)
                    .HasForeignKey(d => d.Actionapprovaluseruuid)
                    .HasConstraintName("audit_admin_events_actionapprovaluseruuid_fkey");
            });

            modelBuilder.Entity<AuditGetquote>(entity =>
            {
                entity.HasKey(e => e.Auditgetquoteuuid)
                    .HasName("audit_getquote_pkey");

                entity.ToTable("audit_getquote");

                entity.Property(e => e.Auditgetquoteuuid)
                    .HasColumnName("auditgetquoteuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Agentname)
                    .HasColumnName("agentname")
                    .HasMaxLength(50);

                entity.Property(e => e.Arrivalairportcode)
                    .IsRequired()
                    .HasColumnName("arrivalairportcode")
                    .HasMaxLength(4);

                entity.Property(e => e.Arrivalcountrycode)
                    .IsRequired()
                    .HasColumnName("arrivalcountrycode")
                    .HasMaxLength(3);

                entity.Property(e => e.Carriercode)
                    .IsRequired()
                    .HasColumnName("carriercode")
                    .HasMaxLength(3);

                entity.Property(e => e.Currencycode)
                    .IsRequired()
                    .HasColumnName("currencycode")
                    .HasMaxLength(3);

                entity.Property(e => e.Departureairportcode)
                    .IsRequired()
                    .HasColumnName("departureairportcode")
                    .HasMaxLength(4);

                entity.Property(e => e.Departurecountrycode)
                    .IsRequired()
                    .HasColumnName("departurecountrycode")
                    .HasMaxLength(3);

                entity.Property(e => e.Directioncount).HasColumnName("directioncount");

                entity.Property(e => e.Mindeparturetimeminutes).HasColumnName("mindeparturetimeminutes");

                entity.Property(e => e.Plancatuuid).HasColumnName("plancatuuid");

                entity.Property(e => e.Querydatetime)
                    .HasColumnName("querydatetime")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Tripdurationdays).HasColumnName("tripdurationdays");

                entity.HasOne(d => d.Plancatuu)
                    .WithMany(p => p.AuditGetquote)
                    .HasForeignKey(d => d.Plancatuuid)
                    .HasConstraintName("audit_getquote_plancatuuid_fkey");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.HasKey(e => e.Auditloguuid)
                    .HasName("audit_log_new_pkey");

                entity.ToTable("audit_log");

                entity.Property(e => e.Auditloguuid)
                    .HasColumnName("auditloguuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Actionby).HasColumnName("actionby");

                entity.Property(e => e.Actiondt)
                    .HasColumnName("actiondt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Actionvalue)
                    .IsRequired()
                    .HasColumnName("actionvalue")
                    .HasMaxLength(50);

                entity.Property(e => e.Itemuuid).HasColumnName("itemuuid");

                entity.Property(e => e.Oldvalue).HasColumnName("oldvalue");

                entity.Property(e => e.Tablename)
                    .IsRequired()
                    .HasColumnName("tablename")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<AuditLogins>(entity =>
            {
                entity.HasKey(e => e.Auditloginuuid)
                    .HasName("audit_logins_pkey");

                entity.ToTable("audit_logins");

                entity.Property(e => e.Auditloginuuid)
                    .HasColumnName("auditloginuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Adminid).HasColumnName("adminid");

                entity.Property(e => e.Adminsessionid)
                    .IsRequired()
                    .HasColumnName("adminsessionid")
                    .HasMaxLength(50);

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Logincrdt)
                    .HasColumnName("logincrdt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Loginid)
                    .IsRequired()
                    .HasColumnName("loginid")
                    .HasMaxLength(50);

                entity.Property(e => e.Loginstatus).HasColumnName("loginstatus");

                entity.Property(e => e.Logoutupdt)
                    .HasColumnName("logoutupdt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(500);

                entity.Property(e => e.Remoteip)
                    .HasColumnName("remoteip")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AuditOutboundVoice>(entity =>
            {
                entity.ToTable("audit_outbound_voice");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Audiofileurl)
                    .HasColumnName("audiofileurl")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasColumnName("mobile_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasColumnName("policy_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.Responsebulkid)
                    .IsRequired()
                    .HasColumnName("responsebulkid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Responsedesc)
                    .IsRequired()
                    .HasColumnName("responsedesc")
                    .HasColumnType("character varying");

                entity.Property(e => e.Responsedt)
                    .HasColumnName("responsedt")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Responsegroupid).HasColumnName("responsegroupid");

                entity.Property(e => e.Responsegroupname)
                    .IsRequired()
                    .HasColumnName("responsegroupname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Responseid).HasColumnName("responseid");

                entity.Property(e => e.Responsestatus)
                    .IsRequired()
                    .HasColumnName("responsestatus")
                    .HasColumnType("character varying");

                entity.Property(e => e.Senderid)
                    .IsRequired()
                    .HasColumnName("senderid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sentdt)
                    .HasColumnName("sentdt")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Ttsmessage)
                    .HasColumnName("ttsmessage")
                    .HasColumnType("character varying");

                entity.Property(e => e.Voicemessage)
                    .HasColumnName("voicemessage")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<AuditPolicyCancellations>(entity =>
            {
                entity.HasKey(e => e.Auditpolicycanceluuid)
                    .HasName("audit_policy_cancellations_pkey");

                entity.ToTable("audit_policy_cancellations");

                entity.Property(e => e.Auditpolicycanceluuid)
                    .HasColumnName("auditpolicycanceluuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Pnr)
                    .HasColumnName("pnr")
                    .HasMaxLength(50);

                entity.Property(e => e.Policydetailuuid).HasColumnName("policydetailuuid");

                entity.Property(e => e.Policyno)
                    .IsRequired()
                    .HasColumnName("policyno")
                    .HasMaxLength(50);

                entity.Property(e => e.Processeddt)
                    .HasColumnName("processeddt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Processedflag).HasColumnName("processedflag");

                entity.HasOne(d => d.Policydetailuu)
                    .WithMany(p => p.AuditPolicyCancellations)
                    .HasForeignKey(d => d.Policydetailuuid)
                    .HasConstraintName("audit_policy_cancellations_policydetailuuid_fkey");
            });

            modelBuilder.Entity<AuditPolicyRefund>(entity =>
            {
                entity.HasKey(e => e.Auditpolicyrefunduuid)
                    .HasName("audit_policy_refund_pkey");

                entity.ToTable("audit_policy_refund");

                entity.Property(e => e.Auditpolicyrefunduuid)
                    .HasColumnName("auditpolicyrefunduuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Pnr)
                    .HasColumnName("pnr")
                    .HasMaxLength(50);

                entity.Property(e => e.Policydetailuuid).HasColumnName("policydetailuuid");

                entity.Property(e => e.Policyno)
                    .IsRequired()
                    .HasColumnName("policyno")
                    .HasMaxLength(50);

                entity.Property(e => e.Processeddt)
                    .HasColumnName("processeddt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Processedflag).HasColumnName("processedflag");

                entity.HasOne(d => d.Policydetailuu)
                    .WithMany(p => p.AuditPolicyRefund)
                    .HasForeignKey(d => d.Policydetailuuid)
                    .HasConstraintName("audit_policy_refund_policydetailuuid_fkey");
            });

            modelBuilder.Entity<AuditSapJournals>(entity =>
            {
                entity.ToTable("audit_sap_journals");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Accountcode)
                    .IsRequired()
                    .HasColumnName("accountcode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Actiontype)
                    .IsRequired()
                    .HasColumnName("actiontype")
                    .HasColumnType("character varying");

                entity.Property(e => e.Autovat).HasColumnName("autovat");

                entity.Property(e => e.Costingcode)
                    .IsRequired()
                    .HasColumnName("costingcode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Costingcode2)
                    .IsRequired()
                    .HasColumnName("costingcode2")
                    .HasColumnType("character varying");

                entity.Property(e => e.Costingcode3)
                    .IsRequired()
                    .HasColumnName("costingcode3")
                    .HasColumnType("character varying");

                entity.Property(e => e.Costingcode4)
                    .IsRequired()
                    .HasColumnName("costingcode4")
                    .HasColumnType("character varying");

                entity.Property(e => e.Costingcode5)
                    .IsRequired()
                    .HasColumnName("costingcode5")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasColumnType("numeric");

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasColumnType("numeric");

                entity.Property(e => e.Journaltype).HasColumnName("journaltype");

                entity.Property(e => e.Linememo)
                    .IsRequired()
                    .HasColumnName("linememo")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasColumnName("policy_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.Projectcode)
                    .IsRequired()
                    .HasColumnName("projectcode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Shortname)
                    .IsRequired()
                    .HasColumnName("shortname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Transactioncode)
                    .IsRequired()
                    .HasColumnName("transactioncode")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<AuditSms>(entity =>
            {
                entity.ToTable("audit_sms");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasColumnName("mobile_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasColumnName("policy_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.Responsedt)
                    .HasColumnName("responsedt")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Senderid)
                    .IsRequired()
                    .HasColumnName("senderid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sentdt)
                    .HasColumnName("sentdt")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Smsmessage)
                    .IsRequired()
                    .HasColumnName("smsmessage")
                    .HasColumnType("character varying");

                entity.Property(e => e.Smsresponse)
                    .IsRequired()
                    .HasColumnName("smsresponse")
                    .HasColumnType("character varying");

                entity.Property(e => e.Smsstatus)
                    .IsRequired()
                    .HasColumnName("smsstatus")
                    .HasColumnType("character varying");

                entity.Property(e => e.Smsstatuscode)
                    .IsRequired()
                    .HasColumnName("smsstatuscode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Smsstatusdesc)
                    .IsRequired()
                    .HasColumnName("smsstatusdesc")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<AuditWeatherIndex>(entity =>
            {
                entity.HasKey(e => e.Auditwiuuid)
                    .HasName("audit_weather_index_pkey");

                entity.ToTable("audit_weather_index");

                entity.Property(e => e.Auditwiuuid)
                    .HasColumnName("auditwiuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Airportcode)
                    .HasColumnName("airportcode")
                    .HasMaxLength(5);

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.OwmId).HasColumnName("owm_id");

                entity.Property(e => e.Pnr)
                    .HasColumnName("pnr")
                    .HasMaxLength(12);

                entity.Property(e => e.Traveldate)
                    .HasColumnName("traveldate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Weatherindexuuid).HasColumnName("weatherindexuuid");

                entity.HasOne(d => d.Weatherindexuu)
                    .WithMany(p => p.AuditWeatherIndex)
                    .HasForeignKey(d => d.Weatherindexuuid)
                    .HasConstraintName("audit_weather_index_weatherindexuuid_fkey");
            });

            modelBuilder.Entity<AuditWebservices>(entity =>
            {
                entity.HasKey(e => e.Auditwsuuid)
                    .HasName("audit_webservices_pkey");

                entity.ToTable("audit_webservices");

                entity.Property(e => e.Auditwsuuid)
                    .HasColumnName("auditwsuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Agentname)
                    .IsRequired()
                    .HasColumnName("agentname")
                    .HasMaxLength(100);

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasMaxLength(5);

                entity.Property(e => e.Functionname)
                    .IsRequired()
                    .HasColumnName("functionname")
                    .HasMaxLength(150);

                entity.Property(e => e.Modulename)
                    .IsRequired()
                    .HasColumnName("modulename")
                    .HasMaxLength(150);

                entity.Property(e => e.Xmlcontent).HasColumnName("xmlcontent");
            });

            modelBuilder.Entity<AuditWsPlanprofiles>(entity =>
            {
                entity.HasKey(e => e.Auditwsppuuid)
                    .HasName("audit_ws_planprofiles_pkey");

                entity.ToTable("audit_ws_planprofiles");

                entity.Property(e => e.Auditwsppuuid)
                    .HasColumnName("auditwsppuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Arrivalstationcode)
                    .HasColumnName("arrivalstationcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Channel)
                    .HasColumnName("channel")
                    .HasMaxLength(50);

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.Coreplanaafeecode)
                    .HasColumnName("coreplanaafeecode")
                    .HasMaxLength(50);

                entity.Property(e => e.Coreplancatuuid).HasColumnName("coreplancatuuid");

                entity.Property(e => e.Coreplancode)
                    .HasColumnName("coreplancode")
                    .HasMaxLength(50);

                entity.Property(e => e.Coreplancurrencycode)
                    .HasColumnName("coreplancurrencycode")
                    .HasMaxLength(3);

                entity.Property(e => e.Coreplanmarketinguuid).HasColumnName("coreplanmarketinguuid");

                entity.Property(e => e.Coreplantotalpremiumamount)
                    .HasColumnName("coreplantotalpremiumamount")
                    .HasColumnType("numeric");

                entity.Property(e => e.Coreplanuuid).HasColumnName("coreplanuuid");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Departureairlinecode)
                    .HasColumnName("departureairlinecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Departureday)
                    .HasColumnName("departureday")
                    .HasMaxLength(3);

                entity.Property(e => e.Departurestationcode)
                    .HasColumnName("departurestationcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Directioncount).HasColumnName("directioncount");

                entity.Property(e => e.Errorcode)
                    .HasColumnName("errorcode")
                    .HasMaxLength(5);

                entity.Property(e => e.Errormessage)
                    .HasColumnName("errormessage")
                    .HasMaxLength(4000);

                entity.Property(e => e.Mindeparturetimeminutes).HasColumnName("mindeparturetimeminutes");

                entity.Property(e => e.Natsamedest)
                    .HasColumnName("natsamedest")
                    .HasMaxLength(1);

                entity.Property(e => e.Planprofilename)
                    .HasColumnName("planprofilename")
                    .HasMaxLength(50);

                entity.Property(e => e.Planprofileuuid).HasColumnName("planprofileuuid");

                entity.Property(e => e.Pseudoagentcode)
                    .HasColumnName("pseudoagentcode")
                    .HasMaxLength(50);

                entity.Property(e => e.Pseudocitycode)
                    .HasColumnName("pseudocitycode")
                    .HasMaxLength(50);

                entity.Property(e => e.Pushplanaafeecode)
                    .HasColumnName("pushplanaafeecode")
                    .HasMaxLength(50);

                entity.Property(e => e.Pushplancatuuid).HasColumnName("pushplancatuuid");

                entity.Property(e => e.Pushplancode)
                    .HasColumnName("pushplancode")
                    .HasMaxLength(50);

                entity.Property(e => e.Pushplancurrencycode)
                    .HasColumnName("pushplancurrencycode")
                    .HasMaxLength(3);

                entity.Property(e => e.Pushplanmarketinguuid).HasColumnName("pushplanmarketinguuid");

                entity.Property(e => e.Pushplantotalpremiumamount)
                    .HasColumnName("pushplantotalpremiumamount")
                    .HasColumnType("numeric");

                entity.Property(e => e.Pushplanuuid).HasColumnName("pushplanuuid");

                entity.Property(e => e.Stopover)
                    .HasColumnName("stopover")
                    .HasMaxLength(1);

                entity.Property(e => e.Stopoverhours).HasColumnName("stopoverhours");

                entity.Property(e => e.Totaladults).HasColumnName("totaladults");

                entity.Property(e => e.Totalchild).HasColumnName("totalchild");

                entity.Property(e => e.Totalinfants).HasColumnName("totalinfants");

                entity.Property(e => e.Totalnatnotsamedest).HasColumnName("totalnatnotsamedest");

                entity.Property(e => e.Totalnatsamedest).HasColumnName("totalnatsamedest");

                entity.Property(e => e.Tripdurationdays).HasColumnName("tripdurationdays");

                entity.HasOne(d => d.Coreplancatuu)
                    .WithMany(p => p.AuditWsPlanprofilesCoreplancatuu)
                    .HasForeignKey(d => d.Coreplancatuuid)
                    .HasConstraintName("audit_ws_planprofiles_coreplancatuuid_fkey");

                entity.HasOne(d => d.Coreplanmarketinguu)
                    .WithMany(p => p.AuditWsPlanprofilesCoreplanmarketinguu)
                    .HasForeignKey(d => d.Coreplanmarketinguuid)
                    .HasConstraintName("audit_ws_planprofiles_coreplanmarketinguuid_fkey");

                entity.HasOne(d => d.Coreplanuu)
                    .WithMany(p => p.AuditWsPlanprofilesCoreplanuu)
                    .HasForeignKey(d => d.Coreplanuuid)
                    .HasConstraintName("audit_ws_planprofiles_coreplanuuid_fkey");

                entity.HasOne(d => d.Planprofileuu)
                    .WithMany(p => p.AuditWsPlanprofiles)
                    .HasForeignKey(d => d.Planprofileuuid)
                    .HasConstraintName("audit_ws_planprofiles_planprofileuuid_fkey");

                entity.HasOne(d => d.Pushplancatuu)
                    .WithMany(p => p.AuditWsPlanprofilesPushplancatuu)
                    .HasForeignKey(d => d.Pushplancatuuid)
                    .HasConstraintName("audit_ws_planprofiles_pushplancatuuid_fkey");

                entity.HasOne(d => d.Pushplanmarketinguu)
                    .WithMany(p => p.AuditWsPlanprofilesPushplanmarketinguu)
                    .HasForeignKey(d => d.Pushplanmarketinguuid)
                    .HasConstraintName("audit_ws_planprofiles_pushplanmarketinguuid_fkey");

                entity.HasOne(d => d.Pushplanuu)
                    .WithMany(p => p.AuditWsPlanprofilesPushplanuu)
                    .HasForeignKey(d => d.Pushplanuuid)
                    .HasConstraintName("audit_ws_planprofiles_pushplanuuid_fkey");
            });

            modelBuilder.Entity<Authorisationapi>(entity =>
            {
                entity.HasKey(e => e.Authapiuuid)
                    .HasName("authorisationapi_pkey");

                entity.ToTable("authorisationapi");

                entity.Property(e => e.Authapiuuid)
                    .HasColumnName("authapiuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Authorisepassword)
                    .IsRequired()
                    .HasColumnName("authorisepassword")
                    .HasMaxLength(100);

                entity.Property(e => e.Authoriseusername)
                    .IsRequired()
                    .HasColumnName("authoriseusername")
                    .HasMaxLength(100);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.AuthorisationapiCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.AuthorisationapiUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<BankingDetails>(entity =>
            {
                entity.ToTable("banking_details");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Accountholdercontactno)
                    .HasColumnName("accountholdercontactno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Accountholderemail)
                    .HasColumnName("accountholderemail")
                    .HasColumnType("character varying");

                entity.Property(e => e.Accountholderidno)
                    .HasColumnName("accountholderidno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Accountholdername)
                    .HasColumnName("accountholdername")
                    .HasColumnType("character varying");

                entity.Property(e => e.Accountno)
                    .HasColumnName("accountno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Bankname)
                    .HasColumnName("bankname")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.Statusid).HasColumnName("statusid");
            });

            modelBuilder.Entity<Benefits>(entity =>
            {
                entity.ToTable("benefits");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Activestatus).HasColumnName("activestatus");

                entity.Property(e => e.Benefitcategory)
                    .HasColumnName("benefitcategory")
                    .HasColumnType("character varying");

                entity.Property(e => e.Benefitdescription)
                    .HasColumnName("benefitdescription")
                    .HasColumnType("character varying");

                entity.Property(e => e.Benefitid).HasColumnName("benefitid");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Memberid)
                    .HasColumnName("memberid")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Benefits)
                    .HasForeignKey(d => d.Memberid)
                    .HasConstraintName("memberid_fkey");
            });

            modelBuilder.Entity<Claim>(entity =>
            {
                entity.ToTable("claim");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.ClaimCode)
                    .HasColumnName("claim_code")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''''::character varying");

                entity.Property(e => e.ClaimSerialNo)
                    .IsRequired()
                    .HasColumnName("claim_serial_no")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''''::character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EstAmount)
                    .HasColumnName("est_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.IncidentDate).HasColumnName("incident_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PayoutAmount)
                    .HasColumnName("payout_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasColumnName("policy_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ClaimApproval>(entity =>
            {
                entity.ToTable("claim_approval");

                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ApprovalType).HasColumnName("approval_type");

                entity.Property(e => e.ClaimAmount)
                    .HasColumnName("claim_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.ClaimCategory).HasColumnName("claim_category");

                entity.Property(e => e.WorkflowName)
                    .IsRequired()
                    .HasColumnName("workflow_name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ClaimApprovalMapping>(entity =>
            {
                entity.ToTable("claim_approval_mapping");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ClaimApprovalId).HasColumnName("claim_approval_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.ClaimApproval)
                    .WithMany(p => p.ClaimApprovalMapping)
                    .HasForeignKey(d => d.ClaimApprovalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("claim_approval_fkey");
            });

            modelBuilder.Entity<ClaimApprovalRole>(entity =>
            {
                entity.ToTable("claim_approval_role");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ClaimApprovalStatus>(entity =>
            {
                entity.ToTable("claim_approval_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasColumnName("status_name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ClaimDueAccident>(entity =>
            {
                entity.ToTable("claim_due_accident");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AccidentPlace).HasColumnType("character varying");

                entity.Property(e => e.AccidentType).HasColumnType("character varying");

                entity.Property(e => e.ClaimId).HasColumnName("claimId");

                entity.Property(e => e.EmployerAddress).HasColumnType("character varying");

                entity.Property(e => e.EmployerContactNo).HasColumnType("character varying");

                entity.Property(e => e.EmployerName).HasColumnType("character varying");

                entity.Property(e => e.InjuryType).HasColumnType("character varying");

                entity.Property(e => e.IsWorkingNow)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.NatureOfWork).HasColumnType("character varying");

                entity.Property(e => e.OccupationAfterDisability).HasColumnType("character varying");

                entity.Property(e => e.OccupationBefore).HasColumnType("character varying");
            });

            modelBuilder.Entity<ClaimEmail>(entity =>
            {
                entity.ToTable("claim_email");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReferenceId).HasColumnName("reference_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<ClaimHistoryLog>(entity =>
            {
                entity.ToTable("claim_history_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.ClaimCode)
                    .HasColumnName("claim_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.ClaimSerialNo)
                    .HasColumnName("claim_serial_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EstAmount)
                    .HasColumnName("est_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.IncidentDate).HasColumnName("incident_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PayoutAmount)
                    .HasColumnName("payout_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.PolicyNo)
                    .HasColumnName("policy_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.ClaimHistoryLog)
                    .HasForeignKey(d => d.ClaimId)
                    .HasConstraintName("claim_history_log_id_fkey");
            });

            modelBuilder.Entity<ClaimHolderContactLog>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ClaimHolderLogId })
                    .HasName("claim_holder_contact_log_pkey");

                entity.ToTable("claim_holder_contact_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ClaimHolderLogId).HasColumnName("claim_holder_log_id");

                entity.Property(e => e.ContactNumber)
                    .HasColumnName("contact_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContactType)
                    .HasColumnName("contact_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.HasOne(d => d.ClaimHolderLog)
                    .WithMany(p => p.ClaimHolderContactLog)
                    .HasForeignKey(d => d.ClaimHolderLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("claim_holder_log__id_fkey");
            });

            modelBuilder.Entity<ClaimHolderLog>(entity =>
            {
                entity.ToTable("claim_holder_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("character varying");

                entity.Property(e => e.AddressCity)
                    .HasColumnName("address_city")
                    .HasColumnType("character varying");

                entity.Property(e => e.AddressCountry)
                    .HasColumnName("address_country")
                    .HasColumnType("character varying");

                entity.Property(e => e.AddressPostalcode)
                    .HasColumnName("address_postalcode")
                    .HasColumnType("character varying");

                entity.Property(e => e.AddressState)
                    .HasColumnName("address_state")
                    .HasColumnType("character varying");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.ExtensionJson)
                    .HasColumnName("extension_json")
                    .HasColumnType("json");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("character varying");

                entity.Property(e => e.IdNo)
                    .HasColumnName("id_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.InsuredType).HasColumnName("insured_type");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.ClaimHolderLog)
                    .HasForeignKey(d => d.ClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("claim_holder_log_claim_id_fkey");
            });

            modelBuilder.Entity<ClaimIllness>(entity =>
            {
                entity.ToTable("claim_illness");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.DcotorName).HasColumnType("character varying");

                entity.Property(e => e.HospitalName).HasColumnType("character varying");

                entity.Property(e => e.NatureOfIllness).HasColumnType("character varying");

                entity.Property(e => e.Symptoms).HasColumnType("character varying");
            });

            modelBuilder.Entity<ClaimLifeAssured>(entity =>
            {
                entity.ToTable("claim_life_assured");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BenefitAmount)
                    .HasColumnName("benefitAmount")
                    .HasColumnType("character varying");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.EmployeeDependentName).HasColumnType("character varying");

                entity.Property(e => e.EmployeeDependentRegNo).HasColumnType("character varying");

                entity.Property(e => e.InsuranceComName).HasColumnType("character varying");

                entity.Property(e => e.InsuranceCoverage).HasColumnType("character varying");

                entity.Property(e => e.PolicyNo)
                    .HasColumnName("policy_no")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ClaimMessageMap>(entity =>
            {
                entity.ToTable("claim_message_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("last_modified_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.MessageBcc)
                    .HasColumnName("message_bcc")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageCc)
                    .HasColumnName("message_cc")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageCode)
                    .HasColumnName("message_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageFrom)
                    .HasColumnName("message_from")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageTo)
                    .HasColumnName("message_to")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanBenefitId).HasColumnName("plan_benefit_id");

                entity.Property(e => e.PlanMessageId).HasColumnName("plan_message_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.HasOne(d => d.PlanBenefit)
                    .WithMany(p => p.ClaimMessageMap)
                    .HasForeignKey(d => d.PlanBenefitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_id_fk");

                entity.HasOne(d => d.PlanMessage)
                    .WithMany(p => p.ClaimMessageMap)
                    .HasForeignKey(d => d.PlanMessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_message_id_fk");
            });

            modelBuilder.Entity<ClaimPaidTo>(entity =>
            {
                entity.ToTable("claim_paid_to");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.PayeeBankAccountNumber).HasColumnType("character varying");

                entity.Property(e => e.PayeeBankName).HasColumnType("character varying");

                entity.Property(e => e.PayeeMailingAddress).HasColumnType("character varying");

                entity.Property(e => e.PayeeName).HasColumnType("character varying");

                entity.Property(e => e.PayeeNationality).HasColumnType("character varying");

                entity.Property(e => e.PayeeRegistrationNo).HasColumnType("character varying");
            });

            modelBuilder.Entity<ClaimSupportingDocuments>(entity =>
            {
                entity.ToTable("claim_supporting_documents");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.DocumentCode)
                    .IsRequired()
                    .HasColumnName("document_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileContentBase64)
                    .IsRequired()
                    .HasColumnName("file_content_base64")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(300);

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.ClaimSupportingDocuments)
                    .HasForeignKey(d => d.ClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("claim_supporting_documents_claim_id_fkey");
            });

            modelBuilder.Entity<ClaimantDetails>(entity =>
            {
                entity.ToTable("claimant_details");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("character varying");

                entity.Property(e => e.BankAccountNumber)
                    .HasColumnName("bank_account_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.BankName)
                    .HasColumnName("bank_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.ContactNumber)
                    .HasColumnName("contact_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.IdNo)
                    .IsRequired()
                    .HasColumnName("id_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.IdentityType).HasColumnName("identity_type");

                entity.Property(e => e.InsurerPersonId).HasColumnName("insurer_person_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentMethod).HasColumnName("payment_method");

                entity.Property(e => e.Relationship).HasColumnName("relationship");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.ClaimantDetails)
                    .HasForeignKey(d => d.ClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("claim_id_fkey");

                entity.HasOne(d => d.InsurerPerson)
                    .WithMany(p => p.ClaimantDetails)
                    .HasForeignKey(d => d.InsurerPersonId)
                    .HasConstraintName("claim_insurer_person_id_fkey");
            });

            modelBuilder.Entity<Claimquestions>(entity =>
            {
                entity.ToTable("claimquestions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Activestatus).HasColumnName("activestatus");

                entity.Property(e => e.Benefitid).HasColumnName("benefitid");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.IsMandatory).HasColumnName("is_mandatory");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Memberid)
                    .HasColumnName("memberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Parentqnid).HasColumnName("parentqnid");

                entity.Property(e => e.Qnid).HasColumnName("qnid");

                entity.Property(e => e.Qnserialnumber).HasColumnName("qnserialnumber");

                entity.Property(e => e.Qntype)
                    .HasColumnName("qntype")
                    .HasColumnType("character varying");

                entity.Property(e => e.Question)
                    .HasColumnName("question")
                    .HasColumnType("character varying");

                entity.Property(e => e.Registeredto)
                    .HasColumnName("registeredto")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sectiontitle)
                    .HasColumnName("sectiontitle")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Claimquestions)
                    .HasForeignKey(d => d.Memberid)
                    .HasConstraintName("memberid_fkey");
            });

            modelBuilder.Entity<Claimreasons>(entity =>
            {
                entity.ToTable("claimreasons");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Activestatus).HasColumnName("activestatus");

                entity.Property(e => e.Claimreason)
                    .HasColumnName("claimreason")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimreasoncode)
                    .HasColumnName("claimreasoncode")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Memberid)
                    .HasColumnName("memberid")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Claimreasons)
                    .HasForeignKey(d => d.Memberid)
                    .HasConstraintName("memberid_fkey");
            });

            modelBuilder.Entity<ClaimsIhp>(entity =>
            {
                entity.ToTable("claims_ihp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Activestatus).HasColumnName("activestatus");

                entity.Property(e => e.Adminremarks)
                    .HasColumnName("adminremarks")
                    .HasColumnType("character varying");

                entity.Property(e => e.Benefitid).HasColumnName("benefitid");

                entity.Property(e => e.Claimantname)
                    .HasColumnName("claimantname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimantnric)
                    .HasColumnName("claimantnric")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimmodified).HasColumnName("claimmodified");

                entity.Property(e => e.Claimno)
                    .HasColumnName("claimno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimreason)
                    .HasColumnName("claimreason")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimreferenceno)
                    .HasColumnName("claimreferenceno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimrefno)
                    .HasColumnName("claimrefno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimstatus)
                    .HasColumnName("claimstatus")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimstatusdate).HasColumnName("claimstatusdate");

                entity.Property(e => e.Claimstatushistory)
                    .HasColumnName("claimstatushistory")
                    .HasColumnType("json");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Fee)
                    .HasColumnName("fee")
                    .HasColumnType("numeric");

                entity.Property(e => e.Files)
                    .HasColumnName("files")
                    .HasColumnType("json");

                entity.Property(e => e.Incurreddate).HasColumnName("incurreddate");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Memberid)
                    .HasColumnName("memberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Originalclaimid).HasColumnName("originalclaimid");

                entity.Property(e => e.Payableamount)
                    .HasColumnName("payableamount")
                    .HasColumnType("numeric");

                entity.Property(e => e.Questions)
                    .HasColumnName("questions")
                    .HasColumnType("json");

                entity.Property(e => e.Receiptno)
                    .HasColumnName("receiptno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("character varying");

                entity.Property(e => e.Serviceprovider)
                    .HasColumnName("serviceprovider")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ClaimsNew>(entity =>
            {
                entity.ToTable("claims_new");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Claimamount)
                    .HasColumnName("claimamount")
                    .HasColumnType("numeric");

                entity.Property(e => e.Claimantdetails)
                    .IsRequired()
                    .HasColumnName("claimantdetails")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimcategory)
                    .IsRequired()
                    .HasColumnName("claimcategory")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimno)
                    .IsRequired()
                    .HasColumnName("claimno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimsdetails)
                    .IsRequired()
                    .HasColumnName("claimsdetails")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimspaymentdetails)
                    .IsRequired()
                    .HasColumnName("claimspaymentdetails")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimsprocessingdetails)
                    .IsRequired()
                    .HasColumnName("claimsprocessingdetails")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimstatus).HasColumnName("claimstatus");

                entity.Property(e => e.ClaimstatusDate)
                    .HasColumnName("claimstatus_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Claimstatusdetails)
                    .IsRequired()
                    .HasColumnName("claimstatusdetails")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimstatushistory)
                    .HasColumnName("claimstatushistory")
                    .HasColumnType("character varying");

                entity.Property(e => e.Claimtpavalues)
                    .HasColumnName("claimtpavalues")
                    .HasColumnType("character varying");

                entity.Property(e => e.Converedpersondetails)
                    .IsRequired()
                    .HasColumnName("converedpersondetails")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Declaractionsandauthorization)
                    .IsRequired()
                    .HasColumnName("declaractionsandauthorization")
                    .HasColumnType("character varying");

                entity.Property(e => e.EstAmount)
                    .HasColumnName("est_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Lob)
                    .IsRequired()
                    .HasColumnName("lob")
                    .HasColumnType("character varying");

                entity.Property(e => e.PayoutAmount)
                    .HasColumnName("payout_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.Policynumbers)
                    .IsRequired()
                    .HasColumnName("policynumbers")
                    .HasColumnType("character varying");

                entity.Property(e => e.Questionsanswers)
                    .IsRequired()
                    .HasColumnName("questionsanswers")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("character varying");

                entity.Property(e => e.Submissionfor)
                    .IsRequired()
                    .HasColumnName("submissionfor")
                    .HasColumnType("character varying");

                entity.Property(e => e.Supportingdocuments)
                    .IsRequired()
                    .HasColumnName("supportingdocuments")
                    .HasColumnType("character varying");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Clinics>(entity =>
            {
                entity.ToTable("clinics");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("character varying");

                entity.Property(e => e.Clinicname)
                    .HasColumnName("clinicname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Clinictype)
                    .HasColumnName("clinictype")
                    .HasColumnType("character varying");

                entity.Property(e => e.Companyname)
                    .HasColumnName("companyname")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Distance)
                    .HasColumnName("distance")
                    .HasColumnType("character varying");

                entity.Property(e => e.Doctor)
                    .HasColumnName("doctor")
                    .HasColumnType("character varying");

                entity.Property(e => e.Employeename)
                    .HasColumnName("employeename")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("character varying");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("character varying");

                entity.Property(e => e.Memberid)
                    .HasColumnName("memberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Parentmemberid)
                    .HasColumnName("parentmemberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Phoiam)
                    .HasColumnName("phoiam")
                    .HasColumnType("character varying");

                entity.Property(e => e.Phoint)
                    .HasColumnName("phoint")
                    .HasColumnType("character varying");

                entity.Property(e => e.Phoipm)
                    .HasColumnName("phoipm")
                    .HasColumnType("character varying");

                entity.Property(e => e.Phoneno)
                    .HasColumnName("phoneno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sant)
                    .HasColumnName("sant")
                    .HasColumnType("character varying");

                entity.Property(e => e.Satam)
                    .HasColumnName("satam")
                    .HasColumnType("character varying");

                entity.Property(e => e.Satpm)
                    .HasColumnName("satpm")
                    .HasColumnType("character varying");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sunam)
                    .HasColumnName("sunam")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sunnt)
                    .HasColumnName("sunnt")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sunpm)
                    .HasColumnName("sunpm")
                    .HasColumnType("character varying");

                entity.Property(e => e.Wdayam)
                    .HasColumnName("wdayam")
                    .HasColumnType("character varying");

                entity.Property(e => e.Wdaynt)
                    .HasColumnName("wdaynt")
                    .HasColumnType("character varying");

                entity.Property(e => e.Wdaypm)
                    .HasColumnName("wdaypm")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ConsAdvancedRaw>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cons_advanced_raw");

                entity.Property(e => e.Acronym)
                    .HasColumnName("acronym")
                    .HasMaxLength(255);

                entity.Property(e => e.Aliastype)
                    .HasColumnName("aliastype")
                    .HasMaxLength(255);

                entity.Property(e => e.Aliastypeid)
                    .HasColumnName("aliastypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Approximate)
                    .HasColumnName("approximate")
                    .HasMaxLength(255);

                entity.Property(e => e.Approximate64)
                    .HasColumnName("approximate64")
                    .HasMaxLength(255);

                entity.Property(e => e.Areacode)
                    .HasColumnName("areacode")
                    .HasMaxLength(255);

                entity.Property(e => e.Areacodeid)
                    .HasColumnName("areacodeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Areacodetype)
                    .HasColumnName("areacodetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Areacodetypeid).HasColumnName("areacodetypeid");

                entity.Property(e => e.Calendartype)
                    .HasColumnName("calendartype")
                    .HasMaxLength(255);

                entity.Property(e => e.Calendartypeid).HasColumnName("calendartypeid");

                entity.Property(e => e.Calendartypeid54)
                    .HasColumnName("calendartypeid54")
                    .HasMaxLength(255);

                entity.Property(e => e.Calendartypeid80)
                    .HasColumnName("calendartypeid80")
                    .HasMaxLength(255);

                entity.Property(e => e.Calendartypeid85)
                    .HasColumnName("calendartypeid85")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment40)
                    .HasColumnName("comment40")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment41)
                    .HasColumnName("comment41")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment53)
                    .HasColumnName("comment53")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment76)
                    .HasColumnName("comment76")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment79)
                    .HasColumnName("comment79")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment89)
                    .HasColumnName("comment89")
                    .HasMaxLength(255);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.Countryid).HasColumnName("countryid");

                entity.Property(e => e.Countryid25).HasColumnName("countryid25");

                entity.Property(e => e.Countryid38)
                    .HasColumnName("countryid38")
                    .HasMaxLength(255);

                entity.Property(e => e.Countryrelevance)
                    .HasColumnName("countryrelevance")
                    .HasMaxLength(255);

                entity.Property(e => e.Countryrelevanceid)
                    .HasColumnName("countryrelevanceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Day).HasColumnName("day");

                entity.Property(e => e.Day60)
                    .HasColumnName("day60")
                    .HasMaxLength(255);

                entity.Property(e => e.Day63)
                    .HasColumnName("day63")
                    .HasMaxLength(255);

                entity.Property(e => e.Day70)
                    .HasColumnName("day70")
                    .HasMaxLength(255);

                entity.Property(e => e.Day73)
                    .HasColumnName("day73")
                    .HasMaxLength(255);

                entity.Property(e => e.Day83)
                    .HasColumnName("day83")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed)
                    .HasColumnName("dayfixed")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed57)
                    .HasColumnName("dayfixed57")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed67)
                    .HasColumnName("dayfixed67")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed88)
                    .HasColumnName("dayfixed88")
                    .HasMaxLength(255);

                entity.Property(e => e.Decisionmakingbody)
                    .HasColumnName("decisionmakingbody")
                    .HasMaxLength(255);

                entity.Property(e => e.Decisionmakingbodyid).HasColumnName("decisionmakingbodyid");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Detailreference)
                    .HasColumnName("detailreference")
                    .HasMaxLength(255);

                entity.Property(e => e.Detailreferenceid)
                    .HasColumnName("detailreferenceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Detailtype)
                    .HasColumnName("detailtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Detailtypeid)
                    .HasColumnName("detailtypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Docnamestatus)
                    .HasColumnName("docnamestatus")
                    .HasMaxLength(255);

                entity.Property(e => e.Docnamestatusid)
                    .HasColumnName("docnamestatusid")
                    .HasMaxLength(255);

                entity.Property(e => e.Documentednameid)
                    .HasColumnName("documentednameid")
                    .HasMaxLength(255);

                entity.Property(e => e.Entryeventtype)
                    .HasColumnName("entryeventtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Entryeventtypeid)
                    .HasColumnName("entryeventtypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Entrylinktypevalues)
                    .HasColumnName("entrylinktypevalues")
                    .HasMaxLength(255);

                entity.Property(e => e.Exreftypevalues)
                    .HasColumnName("exreftypevalues")
                    .HasMaxLength(255);

                entity.Property(e => e.Falsetext)
                    .HasColumnName("falsetext")
                    .HasMaxLength(255);

                entity.Property(e => e.Featuretype)
                    .HasColumnName("featuretype")
                    .HasMaxLength(255);

                entity.Property(e => e.Featuretypegroup)
                    .HasColumnName("featuretypegroup")
                    .HasMaxLength(255);

                entity.Property(e => e.Featuretypegroupid)
                    .HasColumnName("featuretypegroupid")
                    .HasMaxLength(255);

                entity.Property(e => e.Featuretypeid)
                    .HasColumnName("featuretypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Featureversionid)
                    .HasColumnName("featureversionid")
                    .HasMaxLength(255);

                entity.Property(e => e.Fixedref)
                    .HasColumnName("fixedref")
                    .HasMaxLength(255);

                entity.Property(e => e.Fixedref44)
                    .HasColumnName("fixedref44")
                    .HasMaxLength(255);

                entity.Property(e => e.Fixedref46)
                    .HasColumnName("fixedref46")
                    .HasMaxLength(255);

                entity.Property(e => e.Fixedref49)
                    .HasColumnName("fixedref49")
                    .HasMaxLength(255);

                entity.Property(e => e.Former)
                    .HasColumnName("former")
                    .HasMaxLength(255);

                entity.Property(e => e.Fromprofileid)
                    .HasColumnName("fromprofileid")
                    .HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Id10)
                    .HasColumnName("id10")
                    .HasMaxLength(255);

                entity.Property(e => e.Id11).HasColumnName("id11");

                entity.Property(e => e.Id12)
                    .HasColumnName("id12")
                    .HasMaxLength(255);

                entity.Property(e => e.Id13).HasColumnName("id13");

                entity.Property(e => e.Id14)
                    .HasColumnName("id14")
                    .HasMaxLength(255);

                entity.Property(e => e.Id15)
                    .HasColumnName("id15")
                    .HasMaxLength(255);

                entity.Property(e => e.Id16).HasColumnName("id16");

                entity.Property(e => e.Id17)
                    .HasColumnName("id17")
                    .HasMaxLength(255);

                entity.Property(e => e.Id18).HasColumnName("id18");

                entity.Property(e => e.Id19)
                    .HasColumnName("id19")
                    .HasMaxLength(255);

                entity.Property(e => e.Id2).HasColumnName("id2");

                entity.Property(e => e.Id20)
                    .HasColumnName("id20")
                    .HasMaxLength(255);

                entity.Property(e => e.Id21).HasColumnName("id21");

                entity.Property(e => e.Id22).HasColumnName("id22");

                entity.Property(e => e.Id23)
                    .HasColumnName("id23")
                    .HasMaxLength(255);

                entity.Property(e => e.Id24).HasColumnName("id24");

                entity.Property(e => e.Id26)
                    .HasColumnName("id26")
                    .HasMaxLength(255);

                entity.Property(e => e.Id27)
                    .HasColumnName("id27")
                    .HasMaxLength(255);

                entity.Property(e => e.Id28)
                    .HasColumnName("id28")
                    .HasMaxLength(255);

                entity.Property(e => e.Id29)
                    .HasColumnName("id29")
                    .HasMaxLength(255);

                entity.Property(e => e.Id3).HasColumnName("id3");

                entity.Property(e => e.Id30)
                    .HasColumnName("id30")
                    .HasMaxLength(255);

                entity.Property(e => e.Id31)
                    .HasColumnName("id31")
                    .HasMaxLength(255);

                entity.Property(e => e.Id32)
                    .HasColumnName("id32")
                    .HasMaxLength(255);

                entity.Property(e => e.Id33)
                    .HasColumnName("id33")
                    .HasMaxLength(255);

                entity.Property(e => e.Id34).HasColumnName("id34");

                entity.Property(e => e.Id35).HasColumnName("id35");

                entity.Property(e => e.Id36)
                    .HasColumnName("id36")
                    .HasMaxLength(255);

                entity.Property(e => e.Id37)
                    .HasColumnName("id37")
                    .HasMaxLength(255);

                entity.Property(e => e.Id39)
                    .HasColumnName("id39")
                    .HasMaxLength(255);

                entity.Property(e => e.Id4).HasColumnName("id4");

                entity.Property(e => e.Id42)
                    .HasColumnName("id42")
                    .HasMaxLength(255);

                entity.Property(e => e.Id43)
                    .HasColumnName("id43")
                    .HasMaxLength(255);

                entity.Property(e => e.Id48)
                    .HasColumnName("id48")
                    .HasMaxLength(255);

                entity.Property(e => e.Id5)
                    .HasColumnName("id5")
                    .HasMaxLength(255);

                entity.Property(e => e.Id50)
                    .HasColumnName("id50")
                    .HasMaxLength(255);

                entity.Property(e => e.Id51)
                    .HasColumnName("id51")
                    .HasMaxLength(255);

                entity.Property(e => e.Id52)
                    .HasColumnName("id52")
                    .HasMaxLength(255);

                entity.Property(e => e.Id6).HasColumnName("id6");

                entity.Property(e => e.Id7).HasColumnName("id7");

                entity.Property(e => e.Id75)
                    .HasColumnName("id75")
                    .HasMaxLength(255);

                entity.Property(e => e.Id77)
                    .HasColumnName("id77")
                    .HasMaxLength(255);

                entity.Property(e => e.Id78)
                    .HasColumnName("id78")
                    .HasMaxLength(255);

                entity.Property(e => e.Id8)
                    .HasColumnName("id8")
                    .HasMaxLength(255);

                entity.Property(e => e.Id84)
                    .HasColumnName("id84")
                    .HasMaxLength(255);

                entity.Property(e => e.Id9)
                    .HasColumnName("id9")
                    .HasMaxLength(255);

                entity.Property(e => e.Identityfeaturelinktype)
                    .HasColumnName("identityfeaturelinktype")
                    .HasMaxLength(255);

                entity.Property(e => e.Identityfeaturelinktypeid)
                    .HasColumnName("identityfeaturelinktypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Identityid)
                    .HasColumnName("identityid")
                    .HasMaxLength(255);

                entity.Property(e => e.Identityid74)
                    .HasColumnName("identityid74")
                    .HasMaxLength(255);

                entity.Property(e => e.Idregdocdatetype)
                    .HasColumnName("idregdocdatetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Idregdoctype)
                    .HasColumnName("idregdoctype")
                    .HasMaxLength(255);

                entity.Property(e => e.Idregdoctypeid)
                    .HasColumnName("idregdoctypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Idregdocumentid)
                    .HasColumnName("idregdocumentid")
                    .HasMaxLength(255);

                entity.Property(e => e.Idregistrationno)
                    .HasColumnName("idregistrationno")
                    .HasMaxLength(255);

                entity.Property(e => e.Iso2)
                    .HasColumnName("iso2")
                    .HasMaxLength(255);

                entity.Property(e => e.Issuedbycountryid)
                    .HasColumnName("issuedbycountryid")
                    .HasMaxLength(255);

                entity.Property(e => e.Issuedinlocationid)
                    .HasColumnName("issuedinlocationid")
                    .HasMaxLength(255);

                entity.Property(e => e.Issuingauthority)
                    .HasColumnName("issuingauthority")
                    .HasMaxLength(255);

                entity.Property(e => e.Legalbasis)
                    .HasColumnName("legalbasis")
                    .HasMaxLength(255);

                entity.Property(e => e.Legalbasisid)
                    .HasColumnName("legalbasisid")
                    .HasMaxLength(255);

                entity.Property(e => e.Legalbasisshortref)
                    .HasColumnName("legalbasisshortref")
                    .HasMaxLength(255);

                entity.Property(e => e.Legalbasistype)
                    .HasColumnName("legalbasistype")
                    .HasMaxLength(255);

                entity.Property(e => e.Legalbasistypeid)
                    .HasColumnName("legalbasistypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.List)
                    .HasColumnName("list")
                    .HasMaxLength(255);

                entity.Property(e => e.Listid)
                    .HasColumnName("listid")
                    .HasMaxLength(255);

                entity.Property(e => e.Locationid)
                    .HasColumnName("locationid")
                    .HasMaxLength(255);

                entity.Property(e => e.Locparttype)
                    .HasColumnName("locparttype")
                    .HasMaxLength(255);

                entity.Property(e => e.Locparttypeid)
                    .HasColumnName("locparttypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Locpartvaluestatus)
                    .HasColumnName("locpartvaluestatus")
                    .HasMaxLength(255);

                entity.Property(e => e.Locpartvaluestatusid)
                    .HasColumnName("locpartvaluestatusid")
                    .HasMaxLength(255);

                entity.Property(e => e.Locpartvaluetype)
                    .HasColumnName("locpartvaluetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Locpartvaluetypeid)
                    .HasColumnName("locpartvaluetypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Lowquality)
                    .HasColumnName("lowquality")
                    .HasMaxLength(255);

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Month59)
                    .HasColumnName("month59")
                    .HasMaxLength(255);

                entity.Property(e => e.Month62)
                    .HasColumnName("month62")
                    .HasMaxLength(255);

                entity.Property(e => e.Month69)
                    .HasColumnName("month69")
                    .HasMaxLength(255);

                entity.Property(e => e.Month72)
                    .HasColumnName("month72")
                    .HasMaxLength(255);

                entity.Property(e => e.Month82)
                    .HasColumnName("month82")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed)
                    .HasColumnName("monthfixed")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed56)
                    .HasColumnName("monthfixed56")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed66)
                    .HasColumnName("monthfixed66")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed87)
                    .HasColumnName("monthfixed87")
                    .HasMaxLength(255);

                entity.Property(e => e.Namepartgroupid)
                    .HasColumnName("namepartgroupid")
                    .HasMaxLength(255);

                entity.Property(e => e.Nameparttype)
                    .HasColumnName("nameparttype")
                    .HasMaxLength(255);

                entity.Property(e => e.Nameparttypeid)
                    .HasColumnName("nameparttypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Namepartvalue)
                    .HasColumnName("namepartvalue")
                    .HasMaxLength(255);

                entity.Property(e => e.Notional).HasColumnName("notional");

                entity.Property(e => e.Organisation)
                    .HasColumnName("organisation")
                    .HasMaxLength(255);

                entity.Property(e => e.Organisationid).HasColumnName("organisationid");

                entity.Property(e => e.Partysubtype)
                    .HasColumnName("partysubtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Partysubtypeid)
                    .HasColumnName("partysubtypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Partytype)
                    .HasColumnName("partytype")
                    .HasMaxLength(255);

                entity.Property(e => e.Partytypeid)
                    .HasColumnName("partytypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Primary45)
                    .HasColumnName("primary45")
                    .HasMaxLength(255);

                entity.Property(e => e.Primary47)
                    .HasColumnName("primary47")
                    .HasMaxLength(255);

                entity.Property(e => e.Primarytext)
                    .HasColumnName("primarytext")
                    .HasMaxLength(255);

                entity.Property(e => e.Profileid)
                    .HasColumnName("profileid")
                    .HasMaxLength(255);

                entity.Property(e => e.Relationquality)
                    .HasColumnName("relationquality")
                    .HasMaxLength(255);

                entity.Property(e => e.Relationqualityid)
                    .HasColumnName("relationqualityid")
                    .HasMaxLength(255);

                entity.Property(e => e.Relationtype)
                    .HasColumnName("relationtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Relationtypeid)
                    .HasColumnName("relationtypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Reliability)
                    .HasColumnName("reliability")
                    .HasMaxLength(255);

                entity.Property(e => e.Reliabilityid)
                    .HasColumnName("reliabilityid")
                    .HasMaxLength(255);

                entity.Property(e => e.Sanctionsentryid)
                    .HasColumnName("sanctionsentryid")
                    .HasMaxLength(255);

                entity.Property(e => e.Sanctionsentrylinks)
                    .HasColumnName("sanctionsentrylinks")
                    .HasMaxLength(255);

                entity.Property(e => e.Sanctionsprogram)
                    .HasColumnName("sanctionsprogram")
                    .HasMaxLength(255);

                entity.Property(e => e.Sanctionsprogramid)
                    .HasColumnName("sanctionsprogramid")
                    .HasMaxLength(255);

                entity.Property(e => e.Sanctionstype)
                    .HasColumnName("sanctionstype")
                    .HasMaxLength(255);

                entity.Property(e => e.Sanctionstypeid)
                    .HasColumnName("sanctionstypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Script)
                    .HasColumnName("script")
                    .HasMaxLength(255);

                entity.Property(e => e.Scriptcode)
                    .HasColumnName("scriptcode")
                    .HasMaxLength(255);

                entity.Property(e => e.Scriptid)
                    .HasColumnName("scriptid")
                    .HasMaxLength(255);

                entity.Property(e => e.Scriptstatus)
                    .HasColumnName("scriptstatus")
                    .HasMaxLength(255);

                entity.Property(e => e.Scriptstatusid)
                    .HasColumnName("scriptstatusid")
                    .HasMaxLength(255);

                entity.Property(e => e.Subsidiarybody)
                    .HasColumnName("subsidiarybody")
                    .HasMaxLength(255);

                entity.Property(e => e.Subsidiarybodyid)
                    .HasColumnName("subsidiarybodyid")
                    .HasMaxLength(255);

                entity.Property(e => e.Supinfotypevalues)
                    .HasColumnName("supinfotypevalues")
                    .HasMaxLength(255);

                entity.Property(e => e.Symmetrical)
                    .HasColumnName("symmetrical")
                    .HasMaxLength(255);

                entity.Property(e => e.Targettypevalues)
                    .HasColumnName("targettypevalues")
                    .HasMaxLength(255);

                entity.Property(e => e.Toprofileid)
                    .HasColumnName("toprofileid")
                    .HasMaxLength(255);

                entity.Property(e => e.Validity)
                    .HasColumnName("validity")
                    .HasMaxLength(255);

                entity.Property(e => e.Validityid)
                    .HasColumnName("validityid")
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255);

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.Versiondetail)
                    .HasColumnName("versiondetail")
                    .HasMaxLength(255);

                entity.Property(e => e.Year).HasColumnName("year");

                entity.Property(e => e.Year58)
                    .HasColumnName("year58")
                    .HasMaxLength(255);

                entity.Property(e => e.Year61)
                    .HasColumnName("year61")
                    .HasMaxLength(255);

                entity.Property(e => e.Year68)
                    .HasColumnName("year68")
                    .HasMaxLength(255);

                entity.Property(e => e.Year71)
                    .HasColumnName("year71")
                    .HasMaxLength(255);

                entity.Property(e => e.Year81)
                    .HasColumnName("year81")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed)
                    .HasColumnName("yearfixed")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed55)
                    .HasColumnName("yearfixed55")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed65)
                    .HasColumnName("yearfixed65")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed86)
                    .HasColumnName("yearfixed86")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Contactpersons>(entity =>
            {
                entity.ToTable("contactpersons");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Contacttype)
                    .HasColumnName("contacttype")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Designation)
                    .HasColumnName("designation")
                    .HasColumnType("character varying");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("character varying");

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Mobileno)
                    .HasColumnName("mobileno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nationalitycode)
                    .HasColumnName("nationalitycode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nric)
                    .HasColumnName("nric")
                    .HasColumnType("character varying");

                entity.Property(e => e.OtherId)
                    .HasColumnName("other_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.Passport)
                    .HasColumnName("passport")
                    .HasColumnType("character varying");

                entity.Property(e => e.Statusid).HasColumnName("statusid");
            });

            modelBuilder.Entity<CryptographyKeyFile>(entity =>
            {
                entity.ToTable("cryptography_key_file");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasColumnName("key_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<CustomerCredentials>(entity =>
            {
                entity.ToTable("customer_credentials");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Attempts).HasColumnName("attempts");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Credentialhistory)
                    .HasColumnName("credentialhistory")
                    .HasColumnType("json");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.IsLocked).HasColumnName("is_locked");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.LockDate).HasColumnName("lock_date");

                entity.Property(e => e.LockResetDate).HasColumnName("lock_reset_date");

                entity.Property(e => e.Logindetails)
                    .HasColumnName("logindetails")
                    .HasColumnType("json");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(30);

                entity.Property(e => e.NextLoginBefore)
                    .HasColumnName("next_login_before")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("character varying");

                entity.Property(e => e.Rsuserid).HasColumnName("rsuserid");

                entity.Property(e => e.Tpin)
                    .HasColumnName("tpin")
                    .HasMaxLength(10);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CustomerCredentials)
                    .HasForeignKey<CustomerCredentials>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customerid_fkey");
            });

            modelBuilder.Entity<CustomerDevices>(entity =>
            {
                entity.ToTable("customer_devices");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.Deviceno)
                    .HasColumnName("deviceno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Deviceos)
                    .HasColumnName("deviceos")
                    .HasColumnType("character varying");

                entity.Property(e => e.Deviceplatform)
                    .HasColumnName("deviceplatform")
                    .HasColumnType("character varying");

                entity.Property(e => e.Devicetype)
                    .HasColumnName("devicetype")
                    .HasColumnType("character varying");

                entity.Property(e => e.Deviceversion)
                    .HasColumnName("deviceversion")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.RsUserid).HasColumnName("rs_userid");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerDevices)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customerid_fkey");
            });

            modelBuilder.Entity<CustomerRisks>(entity =>
            {
                entity.ToTable("customer_risks");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Riskaccumulationmovement)
                    .HasColumnName("riskaccumulationmovement")
                    .HasColumnType("json");

                entity.Property(e => e.Riskaccumulationregular)
                    .HasColumnName("riskaccumulationregular")
                    .HasColumnType("numeric");

                entity.Property(e => e.Riskaccumulationsingle)
                    .HasColumnName("riskaccumulationsingle")
                    .HasColumnType("numeric");

                entity.Property(e => e.Riskindustry)
                    .HasColumnName("riskindustry")
                    .HasColumnType("character varying");

                entity.Property(e => e.Riskindustrymovement)
                    .HasColumnName("riskindustrymovement")
                    .HasColumnType("json");

                entity.Property(e => e.Riskprofile)
                    .HasColumnName("riskprofile")
                    .HasColumnType("character varying");

                entity.Property(e => e.Riskprofilemovement)
                    .HasColumnName("riskprofilemovement")
                    .HasColumnType("json");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerRisks)
                    .HasForeignKey(d => d.Customerid)
                    .HasConstraintName("customerid_fkeyy");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.ToTable("customers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Actions)
                    .HasColumnName("actions")
                    .HasColumnType("json");

                entity.Property(e => e.Activations)
                    .HasColumnName("activations")
                    .HasColumnType("json");

                entity.Property(e => e.Addresses)
                    .HasColumnName("addresses")
                    .HasColumnType("json");

                entity.Property(e => e.AgreeMarketing).HasColumnName("agree_marketing");

                entity.Property(e => e.AgreePdpa).HasColumnName("agree_pdpa");

                entity.Property(e => e.BankingAccounts)
                    .HasColumnName("banking_accounts")
                    .HasColumnType("json");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.EmailVerified).HasColumnName("email_verified");

                entity.Property(e => e.EmployerName).HasColumnType("character varying");

                entity.Property(e => e.Employments)
                    .HasColumnName("employments")
                    .HasColumnType("json");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("character varying");

                entity.Property(e => e.IncomeRange).HasColumnType("character varying");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.IsFirstTimeBuyer).HasColumnName("is_first_time_buyer");

                entity.Property(e => e.IsLocked).HasColumnName("is_locked");

                entity.Property(e => e.IsMuslim).HasColumnName("is_muslim");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("marital_status")
                    .HasColumnType("character varying");

                entity.Property(e => e.MobileCountryCode)
                    .HasColumnName("mobile_country_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.MobileNo)
                    .HasColumnName("mobile_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.MobileVerified).HasColumnName("mobile_verified");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasColumnType("character varying");

                entity.Property(e => e.NationalityCode)
                    .HasColumnName("nationality_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.NextLoginBefore)
                    .HasColumnName("next_login_before")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Nric)
                    .HasColumnName("nric")
                    .HasColumnType("character varying");

                entity.Property(e => e.Occupation).HasColumnType("character varying");

                entity.Property(e => e.OtherId)
                    .HasColumnName("other_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.OwnerCustomerid).HasColumnName("owner_customerid");

                entity.Property(e => e.Passport)
                    .HasColumnName("passport")
                    .HasColumnType("character varying");

                entity.Property(e => e.Policies)
                    .HasColumnName("policies")
                    .HasColumnType("json");

                entity.Property(e => e.PolicyNos)
                    .HasColumnName("policy_nos")
                    .HasColumnType("character varying");

                entity.Property(e => e.Race)
                    .HasColumnName("race")
                    .HasColumnType("character varying");

                entity.Property(e => e.RelationshipToOwner)
                    .HasColumnName("relationship_to_owner")
                    .HasColumnType("character varying");

                entity.Property(e => e.Religion)
                    .HasColumnName("religion")
                    .HasColumnType("character varying");

                entity.Property(e => e.RiskProfile)
                    .HasColumnName("risk_profile")
                    .HasColumnType("character varying");

                entity.Property(e => e.RsUserId).HasColumnName("rs_user_id");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("entityid_fkey");
            });

            modelBuilder.Entity<DebugLog>(entity =>
            {
                entity.ToTable("debug_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.ItemName)
                    .HasColumnName("item_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemValue)
                    .HasColumnName("item_value")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<DefaultSettings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("default_settings");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedOn).HasColumnName("modified_on");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.ToTable("documents");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Activestatus).HasColumnName("activestatus");

                entity.Property(e => e.Companyid)
                    .HasColumnName("companyid")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Documenturl)
                    .HasColumnName("documenturl")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Registeredto)
                    .HasColumnName("registeredto")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Ecards>(entity =>
            {
                entity.ToTable("ecards");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Ecardeligibility).HasColumnName("ecardeligibility");

                entity.Property(e => e.Format)
                    .HasColumnName("format")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Memberid)
                    .HasColumnName("memberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Parentmemberid)
                    .HasColumnName("parentmemberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remark1)
                    .HasColumnName("remark1")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remark2)
                    .HasColumnName("remark2")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remark3)
                    .HasColumnName("remark3")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remark4)
                    .HasColumnName("remark4")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remark5)
                    .HasColumnName("remark5")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remark6)
                    .HasColumnName("remark6")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remark7)
                    .HasColumnName("remark7")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remark8)
                    .HasColumnName("remark8")
                    .HasColumnType("character varying");

                entity.Property(e => e.Urlback)
                    .HasColumnName("urlback")
                    .HasColumnType("character varying");

                entity.Property(e => e.Urlfront)
                    .HasColumnName("urlfront")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Ecards)
                    .HasForeignKey(d => d.Memberid)
                    .HasConstraintName("memberid_fkey");
            });

            modelBuilder.Entity<EltBatchProcess>(entity =>
            {
                entity.ToTable("elt_batch_process");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EltProcessFlowId).HasColumnName("elt_process_flow_id");

                entity.Property(e => e.EltProcessFlowProcessParameter)
                    .IsRequired()
                    .HasColumnName("elt_process_flow_process_parameter")
                    .HasColumnType("character varying");

                entity.Property(e => e.EltSettinLogId).HasColumnName("elt_settin_log_id");

                entity.Property(e => e.FileContent).HasColumnName("file_content");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileType)
                    .HasColumnName("file_type")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<EltDataTable>(entity =>
            {
                entity.ToTable("elt_data_table");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EltSettingLogId).HasColumnName("elt_setting_log_id");

                entity.Property(e => e.TableColumns)
                    .HasColumnName("table_columns")
                    .HasColumnType("character varying");

                entity.Property(e => e.TableJson)
                    .IsRequired()
                    .HasColumnName("table_json")
                    .HasColumnType("json");

                entity.HasOne(d => d.EltSettingLog)
                    .WithMany(p => p.EltDataTable)
                    .HasForeignKey(d => d.EltSettingLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("elt_data_table_id_fk");
            });

            modelBuilder.Entity<EltProcessFlows>(entity =>
            {
                entity.ToTable("elt_process_flows");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EltSettingId).HasColumnName("elt_setting_id");

                entity.Property(e => e.ProcessName)
                    .IsRequired()
                    .HasColumnName("process_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProcessParameter)
                    .HasColumnName("process_parameter")
                    .HasColumnType("character varying");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.SkipException)
                    .HasColumnName("skip_exception")
                    .HasDefaultValueSql("false");

                entity.HasOne(d => d.EltSetting)
                    .WithMany(p => p.EltProcessFlows)
                    .HasForeignKey(d => d.EltSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("elt_process_flows_id_fk");
            });

            modelBuilder.Entity<EltSettingLog>(entity =>
            {
                entity.ToTable("elt_setting_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EltSettingId).HasColumnName("elt_setting_id");

                entity.Property(e => e.FileContent).HasColumnName("file_content");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsSuccess).HasColumnName("is_success");

                entity.HasOne(d => d.EltSetting)
                    .WithMany(p => p.EltSettingLog)
                    .HasForeignKey(d => d.EltSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("elt_setting_log_id_fk");
            });

            modelBuilder.Entity<EltSettingNotification>(entity =>
            {
                entity.ToTable("elt_setting_notification");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Bcc)
                    .HasColumnName("bcc")
                    .HasColumnType("character varying");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("body")
                    .HasColumnType("character varying");

                entity.Property(e => e.Cc)
                    .HasColumnName("cc")
                    .HasColumnType("character varying");

                entity.Property(e => e.EltSettingsId).HasColumnName("elt_settings_id");

                entity.Property(e => e.EmailType).HasColumnName("email_type");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasColumnType("character varying");

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasColumnName("to")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.EltSettings)
                    .WithMany(p => p.EltSettingNotification)
                    .HasForeignKey(d => d.EltSettingsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("elt_settings_id_fk");
            });

            modelBuilder.Entity<EltSettings>(entity =>
            {
                entity.ToTable("elt_settings");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.FileXferArchivePath)
                    .HasColumnName("file_xfer_archive_path")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileXferDelimiter)
                    .HasColumnName("file_xfer_delimiter")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileXferDestinationPath)
                    .IsRequired()
                    .HasColumnName("file_xfer_destination_path")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileXferDuplicate)
                    .HasColumnName("file_xfer_duplicate")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileXferFileStart)
                    .HasColumnName("file_xfer_file_start")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileXferFormat)
                    .HasColumnName("file_xfer_format")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileXferHost)
                    .IsRequired()
                    .HasColumnName("file_xfer_host")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileXferName)
                    .IsRequired()
                    .HasColumnName("file_xfer_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileXferPassword)
                    .IsRequired()
                    .HasColumnName("file_xfer_password")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileXferPattern)
                    .HasColumnName("file_xfer_pattern")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileXferPort)
                    .IsRequired()
                    .HasColumnName("file_xfer_port")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileXferPortocol)
                    .HasColumnName("file_xfer_portocol")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.FileXferRowStart)
                    .HasColumnName("file_xfer_row_start")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.FileXferSourcePath)
                    .IsRequired()
                    .HasColumnName("file_xfer_source_path")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileXferTable)
                    .HasColumnName("file_xfer_table")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileXferTableColumnType)
                    .HasColumnName("file_xfer_table_column_type")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileXferUser)
                    .IsRequired()
                    .HasColumnName("file_xfer_user")
                    .HasColumnType("character varying");

                entity.Property(e => e.FileXferedOption)
                    .HasColumnName("file_xfered_option")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("last_modified_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<Emailtemplate>(entity =>
            {
                entity.HasKey(e => e.Templateid)
                    .HasName("emailtemplate_pkey");

                entity.ToTable("emailtemplate");

                entity.Property(e => e.Templateid)
                    .HasColumnName("templateid")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Emailcontent)
                    .IsRequired()
                    .HasColumnName("emailcontent")
                    .HasColumnType("character varying");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Enquiry>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Details).HasColumnType("character varying");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Entities>(entity =>
            {
                entity.ToTable("entities");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("json");

                entity.Property(e => e.Businessentitycode)
                    .HasColumnName("businessentitycode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Businessentityname)
                    .HasColumnName("businessentityname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Businessentityno)
                    .HasColumnName("businessentityno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Contactdetails)
                    .HasColumnName("contactdetails")
                    .HasColumnType("json");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.Establishedyear).HasColumnName("establishedyear");

                entity.Property(e => e.Industrycode)
                    .HasColumnName("industrycode")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.IsLocked).HasColumnName("is_locked");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Partnercode)
                    .HasColumnName("partnercode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Partnertype)
                    .HasColumnName("partnertype")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sourceid).HasColumnName("sourceid");

                entity.Property(e => e.Startdate).HasColumnName("startdate");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Entitlements>(entity =>
            {
                entity.ToTable("entitlements");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Benefittype)
                    .HasColumnName("benefittype")
                    .HasColumnType("character varying");

                entity.Property(e => e.Coverage)
                    .HasColumnName("coverage")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Disclaimer)
                    .HasColumnName("disclaimer")
                    .HasColumnType("character varying");

                entity.Property(e => e.Documenturl)
                    .HasColumnName("documenturl")
                    .HasColumnType("character varying");

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.Entitlementamount)
                    .HasColumnName("entitlementamount")
                    .HasColumnType("numeric");

                entity.Property(e => e.Entitlementbalance)
                    .HasColumnName("entitlementbalance")
                    .HasColumnType("numeric");

                entity.Property(e => e.Entitlementyear).HasColumnName("entitlementyear");

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Memberid)
                    .HasColumnName("memberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Parententitlementid)
                    .HasColumnName("parententitlementid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Parentmemberid)
                    .HasColumnName("parentmemberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Planname)
                    .HasColumnName("planname")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyNo)
                    .HasColumnName("policy_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.Startdate).HasColumnName("startdate");

                entity.Property(e => e.Utilizationpaid)
                    .HasColumnName("utilizationpaid")
                    .HasColumnType("numeric");

                entity.Property(e => e.Utilizationpending)
                    .HasColumnName("utilizationpending")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<GenericApplicationLog>(entity =>
            {
                entity.ToTable("generic_application_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ApplicationModule)
                    .IsRequired()
                    .HasColumnName("application_module")
                    .HasColumnType("character varying");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasColumnName("application_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.IsError).HasColumnName("is_error");

                entity.Property(e => e.LogMessage)
                    .HasColumnName("log_message")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Guaranteeletters>(entity =>
            {
                entity.ToTable("guaranteeletters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Additionalremark)
                    .HasColumnName("additionalremark")
                    .HasColumnType("character varying");

                entity.Property(e => e.Attdoctor)
                    .HasColumnName("attdoctor")
                    .HasColumnType("character varying");

                entity.Property(e => e.Benefitid)
                    .HasColumnName("benefitid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Benefittype)
                    .HasColumnName("benefittype")
                    .HasColumnType("character varying");

                entity.Property(e => e.Benefittypedesc)
                    .HasColumnName("benefittypedesc")
                    .HasColumnType("character varying");

                entity.Property(e => e.Clmname)
                    .HasColumnName("clmname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Clmnric)
                    .HasColumnName("clmnric")
                    .HasColumnType("character varying");

                entity.Property(e => e.Clmrefno)
                    .HasColumnName("clmrefno")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Diagnosis)
                    .HasColumnName("diagnosis")
                    .HasColumnType("character varying");

                entity.Property(e => e.Empname)
                    .HasColumnName("empname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Empnric)
                    .HasColumnName("empnric")
                    .HasColumnType("character varying");

                entity.Property(e => e.Files)
                    .HasColumnName("files")
                    .HasColumnType("json");

                entity.Property(e => e.Glhistory)
                    .HasColumnName("glhistory")
                    .HasColumnType("json");

                entity.Property(e => e.Glid)
                    .HasColumnName("glid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Glno)
                    .HasColumnName("glno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Glstatus)
                    .HasColumnName("glstatus")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Memberid)
                    .HasColumnName("memberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Parentmemberid)
                    .HasColumnName("parentmemberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Plancode)
                    .HasColumnName("plancode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Policyno)
                    .HasColumnName("policyno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Providerid)
                    .HasColumnName("providerid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Providername)
                    .HasColumnName("providername")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("character varying");

                entity.Property(e => e.Requestdatetime).HasColumnName("requestdatetime");

                entity.Property(e => e.Rocno)
                    .HasColumnName("rocno")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.ToTable("hospital");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Distance)
                    .HasColumnName("distance")
                    .HasColumnType("character varying");

                entity.Property(e => e.Doctor)
                    .HasColumnName("doctor")
                    .HasColumnType("character varying");

                entity.Property(e => e.Hospitalname)
                    .HasColumnName("hospitalname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Hospitaltype)
                    .HasColumnName("hospitaltype")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("character varying");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("character varying");

                entity.Property(e => e.Phoiam)
                    .HasColumnName("phoiam")
                    .HasColumnType("character varying");

                entity.Property(e => e.Phoint)
                    .HasColumnName("phoint")
                    .HasColumnType("character varying");

                entity.Property(e => e.Phoipm)
                    .HasColumnName("phoipm")
                    .HasColumnType("character varying");

                entity.Property(e => e.Phoneno)
                    .HasColumnName("phoneno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sant)
                    .HasColumnName("sant")
                    .HasColumnType("character varying");

                entity.Property(e => e.Satam)
                    .HasColumnName("satam")
                    .HasColumnType("character varying");

                entity.Property(e => e.Satpm)
                    .HasColumnName("satpm")
                    .HasColumnType("character varying");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sunam)
                    .HasColumnName("sunam")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sunnt)
                    .HasColumnName("sunnt")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sunpm)
                    .HasColumnName("sunpm")
                    .HasColumnType("character varying");

                entity.Property(e => e.Wdayam)
                    .HasColumnName("wdayam")
                    .HasColumnType("character varying");

                entity.Property(e => e.Wdaynt)
                    .HasColumnName("wdaynt")
                    .HasColumnType("character varying");

                entity.Property(e => e.Wdaypm)
                    .HasColumnName("wdaypm")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Industries>(entity =>
            {
                entity.ToTable("industries");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.IndustryClass)
                    .IsRequired()
                    .HasColumnName("industry_class")
                    .HasColumnType("character varying");

                entity.Property(e => e.IndustryCode)
                    .IsRequired()
                    .HasColumnName("industry_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.IndustryNameExternal)
                    .IsRequired()
                    .HasColumnName("industry_name_external")
                    .HasColumnType("character varying");

                entity.Property(e => e.IndustryNameInternal)
                    .IsRequired()
                    .HasColumnName("industry_name_internal")
                    .HasColumnType("character varying");

                entity.Property(e => e.IndustryValue)
                    .HasColumnName("industry_value")
                    .HasColumnType("numeric");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<IndustryGroups>(entity =>
            {
                entity.ToTable("industry_groups");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.IndustryGroupCode)
                    .IsRequired()
                    .HasColumnName("industry_group_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.IndustryGroupName)
                    .IsRequired()
                    .HasColumnName("industry_group_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");
            });

            modelBuilder.Entity<IndustryGroupsMap>(entity =>
            {
                entity.ToTable("industry_groups_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.IndustryGroupId).HasColumnName("industry_group_id");

                entity.Property(e => e.IndustryId).HasColumnName("industry_id");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.IndustryGroup)
                    .WithMany(p => p.IndustryGroupsMap)
                    .HasForeignKey(d => d.IndustryGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("industry_group_id_fkey");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.IndustryGroupsMap)
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("industry_id_fkey");
            });

            modelBuilder.Entity<IndustryOccupationMap>(entity =>
            {
                entity.ToTable("industry_occupation_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.IndustryId).HasColumnName("industry_id");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.OccupationId).HasColumnName("occupation_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.IndustryOccupationMap)
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("industry_id_fkey");

                entity.HasOne(d => d.Occupation)
                    .WithMany(p => p.IndustryOccupationMap)
                    .HasForeignKey(d => d.OccupationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("occupation_id_fkey");
            });

            modelBuilder.Entity<InsBookingclass>(entity =>
            {
                entity.HasKey(e => e.Bookingclassuuid)
                    .HasName("ins_bookingclass_pkey");

                entity.ToTable("ins_bookingclass");

                entity.Property(e => e.Bookingclassuuid)
                    .HasColumnName("bookingclassuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Bookingclass)
                    .HasColumnName("bookingclass")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Bookingclassdesc)
                    .HasColumnName("bookingclassdesc")
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsBookingclassCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_bookingclass_crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsBookingclassUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_bookingclass_upby_fk");
            });

            modelBuilder.Entity<InsCampaigns>(entity =>
            {
                entity.HasKey(e => e.Campaignuuid)
                    .HasName("ins_campaigns_pkey");

                entity.ToTable("ins_campaigns");

                entity.Property(e => e.Campaignuuid)
                    .HasColumnName("campaignuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Activestatus).HasColumnName("activestatus");

                entity.Property(e => e.Campaign)
                    .IsRequired()
                    .HasColumnName("campaign")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Campaigndesc)
                    .HasColumnName("campaigndesc")
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsCampaignsCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_campaigns_crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsCampaignsUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_campaigns_upby_fk");
            });

            modelBuilder.Entity<InsCarrierBookings>(entity =>
            {
                entity.HasKey(e => e.Carrierbookinguuid)
                    .HasName("ins_carrier_bookings_pk");

                entity.ToTable("ins_carrier_bookings");

                entity.Property(e => e.Carrierbookinguuid)
                    .HasColumnName("carrierbookinguuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Activestatus).HasColumnName("activestatus");

                entity.Property(e => e.Bookingclassuuid).HasColumnName("bookingclassuuid");

                entity.Property(e => e.Carrieruuid).HasColumnName("carrieruuid");

                entity.Property(e => e.Coeffvalue).HasColumnName("coeffvalue");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Qualityvalue).HasColumnName("qualityvalue");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.Bookingclassuu)
                    .WithMany(p => p.InsCarrierBookings)
                    .HasForeignKey(d => d.Bookingclassuuid)
                    .HasConstraintName("ins_carrier_bookings_bookingclassuuid_fk");

                entity.HasOne(d => d.Carrieruu)
                    .WithMany(p => p.InsCarrierBookings)
                    .HasForeignKey(d => d.Carrieruuid)
                    .HasConstraintName("ins_carrier_bookings_carrieruuid_fk");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsCarrierBookingsCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_carrier_bookings_crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsCarrierBookingsUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_carrier_bookings_upby_fk");
            });

            modelBuilder.Entity<InsCarrierFares>(entity =>
            {
                entity.HasKey(e => e.Carrierfareuuid)
                    .HasName("ins_carrier_fares_pk");

                entity.ToTable("ins_carrier_fares");

                entity.Property(e => e.Carrierfareuuid)
                    .HasColumnName("carrierfareuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Activestatus).HasColumnName("activestatus");

                entity.Property(e => e.Carrieruuid).HasColumnName("carrieruuid");

                entity.Property(e => e.Coeffvalue).HasColumnName("coeffvalue");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Fareclassuuid).HasColumnName("fareclassuuid");

                entity.Property(e => e.Qualityvalue).HasColumnName("qualityvalue");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.Carrieruu)
                    .WithMany(p => p.InsCarrierFares)
                    .HasForeignKey(d => d.Carrieruuid)
                    .HasConstraintName("ins_carrier_fares_carrieruuid_fk");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsCarrierFaresCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_carrier_fares_crby_fk");

                entity.HasOne(d => d.Fareclassuu)
                    .WithMany(p => p.InsCarrierFares)
                    .HasForeignKey(d => d.Fareclassuuid)
                    .HasConstraintName("ins_carrier_fares_fareclassuuid_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsCarrierFaresUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_carrier_fares_upby_fk");
            });

            modelBuilder.Entity<InsCarrierFaretiers>(entity =>
            {
                entity.HasKey(e => e.Carrierfaretieruuid)
                    .HasName("ins_carrier_faretiers_pk");

                entity.ToTable("ins_carrier_faretiers");

                entity.Property(e => e.Carrierfaretieruuid)
                    .HasColumnName("carrierfaretieruuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Activestatus).HasColumnName("activestatus");

                entity.Property(e => e.Carrieruuid).HasColumnName("carrieruuid");

                entity.Property(e => e.Coeffvalue).HasColumnName("coeffvalue");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Faretieruuid).HasColumnName("faretieruuid");

                entity.Property(e => e.Qualityvalue).HasColumnName("qualityvalue");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.Carrieruu)
                    .WithMany(p => p.InsCarrierFaretiers)
                    .HasForeignKey(d => d.Carrieruuid)
                    .HasConstraintName("ins_carrier_faretiers_carrieruuid_fk");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsCarrierFaretiersCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_carrier_faretiers_crby_fk");

                entity.HasOne(d => d.Faretieruu)
                    .WithMany(p => p.InsCarrierFaretiers)
                    .HasForeignKey(d => d.Faretieruuid)
                    .HasConstraintName("ins_carrier_faretiers_faretieruuid_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsCarrierFaretiersUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_carrier_faretiers_upby_fk");
            });

            modelBuilder.Entity<InsCarriers>(entity =>
            {
                entity.HasKey(e => e.Carrieruuid)
                    .HasName("ins_carriers_pkey");

                entity.ToTable("ins_carriers");

                entity.HasIndex(e => e.Carriercode)
                    .HasName("uc_carrier_code")
                    .IsUnique();

                entity.Property(e => e.Carrieruuid)
                    .HasColumnName("carrieruuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Carriercode)
                    .HasColumnName("carriercode")
                    .HasMaxLength(5);

                entity.Property(e => e.Carrierdesc)
                    .HasColumnName("carrierdesc")
                    .HasMaxLength(250);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Currencycode)
                    .HasColumnName("currencycode")
                    .HasMaxLength(5);

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsCarriersCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_carriers_crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsCarriersUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_carriers_upby_fk");
            });

            modelBuilder.Entity<InsCiTemplates>(entity =>
            {
                entity.HasKey(e => e.Citemplateuuid)
                    .HasName("ins_ci_templates_pkey");

                entity.ToTable("ins_ci_templates");

                entity.Property(e => e.Citemplateuuid)
                    .HasColumnName("citemplateuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Culturecode)
                    .HasColumnName("culturecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Efffromdate)
                    .HasColumnName("efffromdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Efftodate)
                    .HasColumnName("efftodate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Planuuid).HasColumnName("planuuid");

                entity.Property(e => e.Templatebody1).HasColumnName("templatebody1");

                entity.Property(e => e.Templatebody2).HasColumnName("templatebody2");

                entity.Property(e => e.Templatebody3).HasColumnName("templatebody3");

                entity.Property(e => e.Templatebody4).HasColumnName("templatebody4");

                entity.Property(e => e.Templatebody5).HasColumnName("templatebody5");

                entity.Property(e => e.Templatedesc)
                    .HasColumnName("templatedesc")
                    .HasMaxLength(500);

                entity.Property(e => e.Templatename)
                    .IsRequired()
                    .HasColumnName("templatename")
                    .HasMaxLength(250);

                entity.Property(e => e.Templatepages).HasColumnName("templatepages");

                entity.Property(e => e.Templateurl)
                    .HasColumnName("templateurl")
                    .HasMaxLength(500);

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsCiTemplatesCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_ci_templates_crby_fk");

                entity.HasOne(d => d.Planuu)
                    .WithMany(p => p.InsCiTemplates)
                    .HasForeignKey(d => d.Planuuid)
                    .HasConstraintName("ins_ci_templates_planuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsCiTemplatesUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_ci_templates_upby_fk");
            });

            modelBuilder.Entity<InsEmails>(entity =>
            {
                entity.HasKey(e => e.Emailuuid)
                    .HasName("ins_emails_pkey");

                entity.ToTable("ins_emails");

                entity.Property(e => e.Emailuuid)
                    .HasColumnName("emailuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Culturecode)
                    .HasColumnName("culturecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Emailbcc)
                    .HasColumnName("emailbcc")
                    .HasMaxLength(4000);

                entity.Property(e => e.Emailbody).HasColumnName("emailbody");

                entity.Property(e => e.Emaildescription)
                    .HasColumnName("emaildescription")
                    .HasMaxLength(4000);

                entity.Property(e => e.Emailname)
                    .HasColumnName("emailname")
                    .HasMaxLength(500);

                entity.Property(e => e.Emailsubject)
                    .HasColumnName("emailsubject")
                    .HasMaxLength(800);

                entity.Property(e => e.Planuuid).HasColumnName("planuuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsEmailsCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_emails_crby_fk");

                entity.HasOne(d => d.Planuu)
                    .WithMany(p => p.InsEmails)
                    .HasForeignKey(d => d.Planuuid)
                    .HasConstraintName("ins_emails_planuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsEmailsUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_emails_upby_fk");
            });

            modelBuilder.Entity<InsFareclass>(entity =>
            {
                entity.HasKey(e => e.Fareclassuuid)
                    .HasName("ins_fareclass_pkey");

                entity.ToTable("ins_fareclass");

                entity.Property(e => e.Fareclassuuid)
                    .HasColumnName("fareclassuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Fareclass)
                    .HasColumnName("fareclass")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Fareclassdesc)
                    .HasColumnName("fareclassdesc")
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsFareclassCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_fareclass_crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsFareclassUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_fareclass_upby_fk");
            });

            modelBuilder.Entity<InsFaretierRanges>(entity =>
            {
                entity.HasKey(e => e.Faretierrangeuuid)
                    .HasName("ins_faretier_ranges_pkey");

                entity.ToTable("ins_faretier_ranges");

                entity.Property(e => e.Faretierrangeuuid)
                    .HasColumnName("faretierrangeuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Activestatus).HasColumnName("activestatus");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Currencycode)
                    .IsRequired()
                    .HasColumnName("currencycode")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Faretieruuid).HasColumnName("faretieruuid");

                entity.Property(e => e.Faretype).HasColumnName("faretype");

                entity.Property(e => e.Maxamount).HasColumnName("maxamount");

                entity.Property(e => e.Minamount).HasColumnName("minamount");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsFaretierRangesCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_faretier_ranges_crby_fk");

                entity.HasOne(d => d.Faretieruu)
                    .WithMany(p => p.InsFaretierRanges)
                    .HasForeignKey(d => d.Faretieruuid)
                    .HasConstraintName("ins_faretier_ranges_faretieruuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsFaretierRangesUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_faretier_ranges_upby_fk");
            });

            modelBuilder.Entity<InsFaretiers>(entity =>
            {
                entity.HasKey(e => e.Faretieruuid)
                    .HasName("ins_faretiers_pkey");

                entity.ToTable("ins_faretiers");

                entity.Property(e => e.Faretieruuid)
                    .HasColumnName("faretieruuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Faretier)
                    .HasColumnName("faretier")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Faretierdesc)
                    .HasColumnName("faretierdesc")
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsFaretiersCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_faretiers_crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsFaretiersUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_faretiers_upby_fk");
            });

            modelBuilder.Entity<InsJourneys>(entity =>
            {
                entity.HasKey(e => e.Journeyuuid)
                    .HasName("ins_journeys_pkey");

                entity.ToTable("ins_journeys");

                entity.Property(e => e.Journeyuuid)
                    .HasColumnName("journeyuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Arrivalairportcode)
                    .HasColumnName("arrivalairportcode")
                    .HasMaxLength(5);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Departureairportcode)
                    .HasColumnName("departureairportcode")
                    .HasMaxLength(5);

                entity.Property(e => e.Efffromdate)
                    .HasColumnName("efffromdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Efftodate)
                    .HasColumnName("efftodate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Routeuuid).HasColumnName("routeuuid");

                entity.Property(e => e.Transitairportcode)
                    .HasColumnName("transitairportcode")
                    .HasMaxLength(5);

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(0) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsJourneysCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Routeuu)
                    .WithMany(p => p.InsJourneys)
                    .HasForeignKey(d => d.Routeuuid)
                    .HasConstraintName("ins_journeys_routeuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsJourneysUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsPartnerKeys>(entity =>
            {
                entity.HasKey(e => e.Partnerkeyuuid)
                    .HasName("ins_partner_keys_pkey");

                entity.ToTable("ins_partner_keys");

                entity.Property(e => e.Partnerkeyuuid)
                    .HasColumnName("partnerkeyuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Keydesc)
                    .HasColumnName("keydesc")
                    .HasMaxLength(800);

                entity.Property(e => e.Keyname)
                    .IsRequired()
                    .HasColumnName("keyname")
                    .HasMaxLength(250);

                entity.Property(e => e.Keyvalue)
                    .IsRequired()
                    .HasColumnName("keyvalue");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Underwriteruuid).HasColumnName("underwriteruuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Versionno).HasColumnName("versionno");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPartnerKeysCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_partner_keys_crby_fk");

                entity.HasOne(d => d.Underwriteruu)
                    .WithMany(p => p.InsPartnerKeys)
                    .HasForeignKey(d => d.Underwriteruuid)
                    .HasConstraintName("ins_partner_keys_underwriteruuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPartnerKeysUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_partner_keys_upby_fk");
            });

            modelBuilder.Entity<InsPlans>(entity =>
            {
                entity.HasKey(e => e.Planuuid)
                    .HasName("ins_plans_pkey");

                entity.ToTable("ins_plans");

                entity.Property(e => e.Planuuid)
                    .HasColumnName("planuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Chargetype)
                    .HasColumnName("chargetype")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Plancode)
                    .IsRequired()
                    .HasColumnName("plancode")
                    .HasMaxLength(50);

                entity.Property(e => e.Plandesc)
                    .HasColumnName("plandesc")
                    .HasMaxLength(500);

                entity.Property(e => e.Plandesc2)
                    .HasColumnName("plandesc2")
                    .HasMaxLength(4000);

                entity.Property(e => e.Planname)
                    .IsRequired()
                    .HasColumnName("planname")
                    .HasMaxLength(250);

                entity.Property(e => e.Planstatus).HasColumnName("planstatus");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Underwriteruuid).HasColumnName("underwriteruuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_plans_crby_fk");

                entity.HasOne(d => d.Underwriteruu)
                    .WithMany(p => p.InsPlans)
                    .HasForeignKey(d => d.Underwriteruuid)
                    .HasConstraintName("ins_plans_underwriteruuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPlansUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_plans_upby_fk");
            });

            modelBuilder.Entity<InsPlansCategories>(entity =>
            {
                entity.HasKey(e => e.Plancatuuid)
                    .HasName("ins_plans_categories_pkey");

                entity.ToTable("ins_plans_categories");

                entity.Property(e => e.Plancatuuid)
                    .HasColumnName("plancatuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Isweathercheck).HasColumnName("isweathercheck");

                entity.Property(e => e.Plancat)
                    .IsRequired()
                    .HasColumnName("plancat")
                    .HasMaxLength(50);

                entity.Property(e => e.Reportsequenceno).HasColumnName("reportsequenceno");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansCategoriesCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_plans_categories_crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPlansCategoriesUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_plans_categories_upby_fk");
            });

            modelBuilder.Entity<InsPlansCategoriesPlans>(entity =>
            {
                entity.HasKey(e => e.Plancatplanuuid)
                    .HasName("ins_plans_categories_plans_pkey");

                entity.ToTable("ins_plans_categories_plans");

                entity.Property(e => e.Plancatplanuuid)
                    .HasColumnName("plancatplanuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(400);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Efffromdate)
                    .HasColumnName("efffromdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Efftodate)
                    .HasColumnName("efftodate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Plancatuuid).HasColumnName("plancatuuid");

                entity.Property(e => e.Planuuid).HasColumnName("planuuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansCategoriesPlansCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Plancatuu)
                    .WithMany(p => p.InsPlansCategoriesPlans)
                    .HasForeignKey(d => d.Plancatuuid)
                    .HasConstraintName("ins_plans_categories_plans_plancatuuid_fk");

                entity.HasOne(d => d.Planuu)
                    .WithMany(p => p.InsPlansCategoriesPlans)
                    .HasForeignKey(d => d.Planuuid)
                    .HasConstraintName("ins_plans_categories_plans_planuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPlansCategoriesPlansUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsPlansCategoriesPlansLog>(entity =>
            {
                entity.HasKey(e => e.Plancatplanloguuid)
                    .HasName("ins_plans_categories_plans_log_pkey");

                entity.ToTable("ins_plans_categories_plans_log");

                entity.Property(e => e.Plancatplanloguuid)
                    .HasColumnName("plancatplanloguuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(400);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(0) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Efffromdate)
                    .HasColumnName("efffromdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Efftodate)
                    .HasColumnName("efftodate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Plancatplanuuid).HasColumnName("plancatplanuuid");

                entity.Property(e => e.Plancatuuid).HasColumnName("plancatuuid");

                entity.Property(e => e.Planuuid).HasColumnName("planuuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansCategoriesPlansLogCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Plancatplanuu)
                    .WithMany(p => p.InsPlansCategoriesPlansLog)
                    .HasForeignKey(d => d.Plancatplanuuid)
                    .HasConstraintName("ins_plans_categories_plans_log_plancatplanuuid_fkey");

                entity.HasOne(d => d.Plancatuu)
                    .WithMany(p => p.InsPlansCategoriesPlansLog)
                    .HasForeignKey(d => d.Plancatuuid)
                    .HasConstraintName("ins_plans_categories_plans_log_plancatuuid_fkey");

                entity.HasOne(d => d.Planuu)
                    .WithMany(p => p.InsPlansCategoriesPlansLog)
                    .HasForeignKey(d => d.Planuuid)
                    .HasConstraintName("ins_plans_categories_plans_log_planuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPlansCategoriesPlansLogUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsPlansMarketing>(entity =>
            {
                entity.HasKey(e => e.Planmarketinguuid)
                    .HasName("ins_plans_marketing_pkey");

                entity.ToTable("ins_plans_marketing");

                entity.Property(e => e.Planmarketinguuid)
                    .HasColumnName("planmarketinguuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Coreorpush)
                    .HasColumnName("coreorpush")
                    .HasMaxLength(1);

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Culturecode)
                    .HasColumnName("culturecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Efffromdate)
                    .HasColumnName("efffromdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Efftodate)
                    .HasColumnName("efftodate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Familyorgroup)
                    .HasColumnName("familyorgroup")
                    .HasMaxLength(1);

                entity.Property(e => e.Marketingpointers)
                    .HasColumnName("marketingpointers")
                    .HasMaxLength(4000);

                entity.Property(e => e.Marketingtitle)
                    .HasColumnName("marketingtitle")
                    .HasMaxLength(250);

                entity.Property(e => e.Planadditionalinfodesc)
                    .HasColumnName("planadditionalinfodesc")
                    .HasMaxLength(4000);

                entity.Property(e => e.Planadditionalinfotitle)
                    .HasColumnName("planadditionalinfotitle")
                    .HasMaxLength(800);

                entity.Property(e => e.Plancontent).HasColumnName("plancontent");

                entity.Property(e => e.Plandefault).HasColumnName("plandefault");

                entity.Property(e => e.Plandesc)
                    .HasColumnName("plandesc")
                    .HasMaxLength(800);

                entity.Property(e => e.Plannoconsideration)
                    .HasColumnName("plannoconsideration")
                    .HasMaxLength(4000);

                entity.Property(e => e.Plannodesc).HasColumnName("plannodesc");

                entity.Property(e => e.Plantitle)
                    .HasColumnName("plantitle")
                    .HasMaxLength(800);

                entity.Property(e => e.Plantnc)
                    .HasColumnName("plantnc")
                    .HasMaxLength(4000);

                entity.Property(e => e.Planyesdesc).HasColumnName("planyesdesc");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansMarketingCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ins_plans_marketing_crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPlansMarketingUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("ins_plans_marketing_upby_fk");
            });

            modelBuilder.Entity<InsPlansMarketingOwn>(entity =>
            {
                entity.HasKey(e => e.Planmarketingownuuid)
                    .HasName("ins_plans_marketing_own_pk");

                entity.ToTable("ins_plans_marketing_own");

                entity.Property(e => e.Planmarketingownuuid)
                    .HasColumnName("planmarketingownuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Overwritedefaultmarketing).HasColumnName("overwritedefaultmarketing");

                entity.Property(e => e.Planmarketinguuid).HasColumnName("planmarketinguuid");

                entity.Property(e => e.Planuuid).HasColumnName("planuuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansMarketingOwnCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Planmarketinguu)
                    .WithMany(p => p.InsPlansMarketingOwn)
                    .HasForeignKey(d => d.Planmarketinguuid)
                    .HasConstraintName("ins_plans_marketing_own_planmarketinguuid_fkey");

                entity.HasOne(d => d.Planuu)
                    .WithMany(p => p.InsPlansMarketingOwn)
                    .HasForeignKey(d => d.Planuuid)
                    .HasConstraintName("ins_plans_marketing_own_planuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPlansMarketingOwnUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsPlansMarketingPointers>(entity =>
            {
                entity.HasKey(e => e.Planmarketingpointeruuid)
                    .HasName("ins_plans_marketing_pointers_pkey");

                entity.ToTable("ins_plans_marketing_pointers");

                entity.Property(e => e.Planmarketingpointeruuid)
                    .HasColumnName("planmarketingpointeruuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Marketingpointerdesc)
                    .HasColumnName("marketingpointerdesc")
                    .HasMaxLength(800);

                entity.Property(e => e.Planmarketinguuid).HasColumnName("planmarketinguuid");

                entity.Property(e => e.Sequenceno).HasColumnName("sequenceno");

                entity.HasOne(d => d.Planmarketinguu)
                    .WithMany(p => p.InsPlansMarketingPointers)
                    .HasForeignKey(d => d.Planmarketinguuid)
                    .HasConstraintName("ins_plans_marketing_pointers_planmarketinguuid_fkey");
            });

            modelBuilder.Entity<InsPlansMarketingSub>(entity =>
            {
                entity.HasKey(e => e.Planmarketingsubuuid)
                    .HasName("ins_plans_marketing_sub_pkey");

                entity.ToTable("ins_plans_marketing_sub");

                entity.Property(e => e.Planmarketingsubuuid)
                    .HasColumnName("planmarketingsubuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Culturecode)
                    .HasColumnName("culturecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Marketingpointers)
                    .HasColumnName("marketingpointers")
                    .HasMaxLength(4000);

                entity.Property(e => e.Planadditionalinfodesc)
                    .HasColumnName("planadditionalinfodesc")
                    .HasMaxLength(4000);

                entity.Property(e => e.Planadditionalinfotitle)
                    .HasColumnName("planadditionalinfotitle")
                    .HasMaxLength(800);

                entity.Property(e => e.Plancontent).HasColumnName("plancontent");

                entity.Property(e => e.Plandesc)
                    .HasColumnName("plandesc")
                    .HasMaxLength(800);

                entity.Property(e => e.Planmarketinguuid).HasColumnName("planmarketinguuid");

                entity.Property(e => e.Plannoconsideration)
                    .HasColumnName("plannoconsideration")
                    .HasMaxLength(4000);

                entity.Property(e => e.Plannodesc).HasColumnName("plannodesc");

                entity.Property(e => e.Plantitle)
                    .HasColumnName("plantitle")
                    .HasMaxLength(800);

                entity.Property(e => e.Plantnc)
                    .HasColumnName("plantnc")
                    .HasMaxLength(4000);

                entity.Property(e => e.Planyesdesc).HasColumnName("planyesdesc");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansMarketingSubCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Planmarketinguu)
                    .WithMany(p => p.InsPlansMarketingSub)
                    .HasForeignKey(d => d.Planmarketinguuid)
                    .HasConstraintName("ins_plans_marketing_sub_planmarketinguuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPlansMarketingSubUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsPlansProfiles>(entity =>
            {
                entity.HasKey(e => e.Planprofileuuid)
                    .HasName("ins_plans_profiles_pkey");

                entity.ToTable("ins_plans_profiles");

                entity.Property(e => e.Planprofileuuid)
                    .HasColumnName("planprofileuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Adultcountmax).HasColumnName("adultcountmax");

                entity.Property(e => e.Adultcountmin).HasColumnName("adultcountmin");

                entity.Property(e => e.Carrieruuid).HasColumnName("carrieruuid");

                entity.Property(e => e.Childcountmax).HasColumnName("childcountmax");

                entity.Property(e => e.Childcountmin).HasColumnName("childcountmin");

                entity.Property(e => e.Core2messageconfig)
                    .HasColumnName("core2messageconfig")
                    .HasMaxLength(250);

                entity.Property(e => e.Core2planuuid).HasColumnName("core2planuuid");

                entity.Property(e => e.Coreplanuuid).HasColumnName("coreplanuuid");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Departuredayoftheweek)
                    .HasColumnName("departuredayoftheweek")
                    .HasMaxLength(50);

                entity.Property(e => e.Directioncount).HasColumnName("directioncount");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Infantcountmax).HasColumnName("infantcountmax");

                entity.Property(e => e.Infantcountmin).HasColumnName("infantcountmin");

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.Mindeparturetimeminutes).HasColumnName("mindeparturetimeminutes");

                entity.Property(e => e.Nationalitysamedestination)
                    .HasColumnName("nationalitysamedestination")
                    .HasMaxLength(3);

                entity.Property(e => e.Probabilitypct).HasColumnName("probabilitypct");

                entity.Property(e => e.Probabilitypctstart).HasColumnName("probabilitypctstart");

                entity.Property(e => e.Profilename)
                    .HasColumnName("profilename")
                    .HasMaxLength(250);

                entity.Property(e => e.Push2messageconfig)
                    .HasColumnName("push2messageconfig")
                    .HasMaxLength(250);

                entity.Property(e => e.Push2planuuid).HasColumnName("push2planuuid");

                entity.Property(e => e.Pushplanuuid).HasColumnName("pushplanuuid");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Stopover)
                    .HasColumnName("stopover")
                    .HasMaxLength(3);

                entity.Property(e => e.Stopovermaxhours).HasColumnName("stopovermaxhours");

                entity.Property(e => e.Stopoverminhours).HasColumnName("stopoverminhours");

                entity.Property(e => e.Tripdurationdaysmax).HasColumnName("tripdurationdaysmax");

                entity.Property(e => e.Tripdurationdaysmin).HasColumnName("tripdurationdaysmin");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansProfilesCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPlansProfilesUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsPlansProfilesMarketing>(entity =>
            {
                entity.HasKey(e => e.Planprofilemarketinguuid)
                    .HasName("ins_plans_profiles_marketing_pkey");

                entity.ToTable("ins_plans_profiles_marketing");

                entity.Property(e => e.Planprofilemarketinguuid)
                    .HasColumnName("planprofilemarketinguuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Messagefamilycorea).HasColumnName("messagefamilycorea");

                entity.Property(e => e.Messagefamilycoreb).HasColumnName("messagefamilycoreb");

                entity.Property(e => e.Messagefamilycorec).HasColumnName("messagefamilycorec");

                entity.Property(e => e.Messagefamilycored).HasColumnName("messagefamilycored");

                entity.Property(e => e.Messagefamilycoree).HasColumnName("messagefamilycoree");

                entity.Property(e => e.Messagefamilycorepcta)
                    .HasColumnName("messagefamilycorepcta")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagefamilycorepctb)
                    .HasColumnName("messagefamilycorepctb")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagefamilycorepctc)
                    .HasColumnName("messagefamilycorepctc")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagefamilycorepctd)
                    .HasColumnName("messagefamilycorepctd")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagefamilycorepcte)
                    .HasColumnName("messagefamilycorepcte")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagefamilypusha).HasColumnName("messagefamilypusha");

                entity.Property(e => e.Messagefamilypushb).HasColumnName("messagefamilypushb");

                entity.Property(e => e.Messagefamilypushc).HasColumnName("messagefamilypushc");

                entity.Property(e => e.Messagefamilypushd).HasColumnName("messagefamilypushd");

                entity.Property(e => e.Messagefamilypushe).HasColumnName("messagefamilypushe");

                entity.Property(e => e.Messagefamilypushpcta)
                    .HasColumnName("messagefamilypushpcta")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagefamilypushpctb)
                    .HasColumnName("messagefamilypushpctb")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagefamilypushpctc)
                    .HasColumnName("messagefamilypushpctc")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagefamilypushpctd)
                    .HasColumnName("messagefamilypushpctd")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagefamilypushpcte)
                    .HasColumnName("messagefamilypushpcte")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagegroupcorea).HasColumnName("messagegroupcorea");

                entity.Property(e => e.Messagegroupcoreb).HasColumnName("messagegroupcoreb");

                entity.Property(e => e.Messagegroupcorec).HasColumnName("messagegroupcorec");

                entity.Property(e => e.Messagegroupcored).HasColumnName("messagegroupcored");

                entity.Property(e => e.Messagegroupcoree).HasColumnName("messagegroupcoree");

                entity.Property(e => e.Messagegroupcorepcta)
                    .HasColumnName("messagegroupcorepcta")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagegroupcorepctb)
                    .HasColumnName("messagegroupcorepctb")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagegroupcorepctc)
                    .HasColumnName("messagegroupcorepctc")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagegroupcorepctd)
                    .HasColumnName("messagegroupcorepctd")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagegroupcorepcte)
                    .HasColumnName("messagegroupcorepcte")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagegrouppusha).HasColumnName("messagegrouppusha");

                entity.Property(e => e.Messagegrouppushb).HasColumnName("messagegrouppushb");

                entity.Property(e => e.Messagegrouppushc).HasColumnName("messagegrouppushc");

                entity.Property(e => e.Messagegrouppushd).HasColumnName("messagegrouppushd");

                entity.Property(e => e.Messagegrouppushe).HasColumnName("messagegrouppushe");

                entity.Property(e => e.Messagegrouppushpcta)
                    .HasColumnName("messagegrouppushpcta")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagegrouppushpctb)
                    .HasColumnName("messagegrouppushpctb")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagegrouppushpctc)
                    .HasColumnName("messagegrouppushpctc")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagegrouppushpctd)
                    .HasColumnName("messagegrouppushpctd")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Messagegrouppushpcte)
                    .HasColumnName("messagegrouppushpcte")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Planprofileuuid).HasColumnName("planprofileuuid");

                entity.Property(e => e.Segmentstatus).HasColumnName("segmentstatus");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Targetarrivalcountrycode)
                    .HasColumnName("targetarrivalcountrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.Targetdeparturecountrycode)
                    .HasColumnName("targetdeparturecountrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansProfilesMarketingCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Planprofileuu)
                    .WithMany(p => p.InsPlansProfilesMarketing)
                    .HasForeignKey(d => d.Planprofileuuid)
                    .HasConstraintName("ins_plans_profiles_marketing_planprofileuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPlansProfilesMarketingUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsPlansProfilesSub>(entity =>
            {
                entity.HasKey(e => e.Planprofilesubuuid)
                    .HasName("ins_plans_profiles_sub_pkey");

                entity.ToTable("ins_plans_profiles_sub");

                entity.Property(e => e.Planprofilesubuuid)
                    .HasColumnName("planprofilesubuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Core2messageconfig)
                    .HasColumnName("core2messageconfig")
                    .HasMaxLength(250);

                entity.Property(e => e.Core2plancategoryuuid).HasColumnName("core2plancategoryuuid");

                entity.Property(e => e.Coreplancategoryuuid).HasColumnName("coreplancategoryuuid");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Planprofileuuid).HasColumnName("planprofileuuid");

                entity.Property(e => e.Probabilityend).HasColumnName("probabilityend");

                entity.Property(e => e.Probabilitystart).HasColumnName("probabilitystart");

                entity.Property(e => e.Push2messageconfig)
                    .HasColumnName("push2messageconfig")
                    .HasMaxLength(250);

                entity.Property(e => e.Push2plancategoryuuid).HasColumnName("push2plancategoryuuid");

                entity.Property(e => e.Pushplancategoryuuid).HasColumnName("pushplancategoryuuid");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.Core2plancategoryuu)
                    .WithMany(p => p.InsPlansProfilesSubCore2plancategoryuu)
                    .HasForeignKey(d => d.Core2plancategoryuuid)
                    .HasConstraintName("ins_plans_profiles_sub_core2plancategoryuuid_fkey");

                entity.HasOne(d => d.Coreplancategoryuu)
                    .WithMany(p => p.InsPlansProfilesSubCoreplancategoryuu)
                    .HasForeignKey(d => d.Coreplancategoryuuid)
                    .HasConstraintName("ins_plans_profiles_sub_coreplancategoryuuid_fkey");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansProfilesSubCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Planprofileuu)
                    .WithMany(p => p.InsPlansProfilesSub)
                    .HasForeignKey(d => d.Planprofileuuid)
                    .HasConstraintName("ins_plans_profiles_sub_planprofileuuid_fkey");

                entity.HasOne(d => d.Push2plancategoryuu)
                    .WithMany(p => p.InsPlansProfilesSubPush2plancategoryuu)
                    .HasForeignKey(d => d.Push2plancategoryuuid)
                    .HasConstraintName("ins_plans_profiles_sub_push2plancategoryuuid_fkey");

                entity.HasOne(d => d.Pushplancategoryuu)
                    .WithMany(p => p.InsPlansProfilesSubPushplancategoryuu)
                    .HasForeignKey(d => d.Pushplancategoryuuid)
                    .HasConstraintName("ins_plans_profiles_sub_pushplancategoryuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPlansProfilesSubUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsPlansProfilesUpsell>(entity =>
            {
                entity.HasKey(e => e.Planprofileupselluuid)
                    .HasName("ins_plans_profiles_upsell_pkey");

                entity.ToTable("ins_plans_profiles_upsell");

                entity.Property(e => e.Planprofileupselluuid)
                    .HasColumnName("planprofileupselluuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Plancat)
                    .HasColumnName("plancat")
                    .HasMaxLength(50);

                entity.Property(e => e.Plancategoryuuid).HasColumnName("plancategoryuuid");

                entity.Property(e => e.Planprofilesubuuid).HasColumnName("planprofilesubuuid");

                entity.Property(e => e.Planprofileuuid).HasColumnName("planprofileuuid");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansProfilesUpsell)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Plancategoryuu)
                    .WithMany(p => p.InsPlansProfilesUpsell)
                    .HasForeignKey(d => d.Plancategoryuuid)
                    .HasConstraintName("ins_plans_profiles_upsell_plancategoryuuid_fkey");

                entity.HasOne(d => d.Planprofilesubuu)
                    .WithMany(p => p.InsPlansProfilesUpsell)
                    .HasForeignKey(d => d.Planprofilesubuuid)
                    .HasConstraintName("ins_plans_profiles_upsell_planprofilesubuuid_fkey");

                entity.HasOne(d => d.Planprofileuu)
                    .WithMany(p => p.InsPlansProfilesUpsell)
                    .HasForeignKey(d => d.Planprofileuuid)
                    .HasConstraintName("ins_plans_profiles_upsell_planprofileuuid_fkey");
            });

            modelBuilder.Entity<InsPlansRestrictions>(entity =>
            {
                entity.HasKey(e => e.Planrestrictionuuid)
                    .HasName("ins_plans_restrictions_pkey");

                entity.ToTable("ins_plans_restrictions");

                entity.Property(e => e.Planrestrictionuuid)
                    .HasColumnName("planrestrictionuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Activestatus).HasColumnName("activestatus");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Isallowed).HasColumnName("isallowed");

                entity.Property(e => e.Planuuid).HasColumnName("planuuid");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansRestrictionsCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Planuu)
                    .WithMany(p => p.InsPlansRestrictions)
                    .HasForeignKey(d => d.Planuuid)
                    .HasConstraintName("ins_plans_restrictions_planuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPlansRestrictionsUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsPlansRoutes>(entity =>
            {
                entity.HasKey(e => e.Planrouteuuid)
                    .HasName("ins_plans_routes_pkey");

                entity.ToTable("ins_plans_routes");

                entity.Property(e => e.Planrouteuuid)
                    .HasColumnName("planrouteuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(0) without time zone")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Planuuid).HasColumnName("planuuid");

                entity.Property(e => e.Routeuuid).HasColumnName("routeuuid");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansRoutes)
                    .HasForeignKey(d => d.Crby)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Planuu)
                    .WithMany(p => p.InsPlansRoutes)
                    .HasForeignKey(d => d.Planuuid)
                    .HasConstraintName("ins_plans_routes_planuuid_fkey");
            });

            modelBuilder.Entity<InsPlansSerialRange>(entity =>
            {
                entity.HasKey(e => e.Planserialrangeuuid)
                    .HasName("ins_plans_serial_range_pkey");

                entity.ToTable("ins_plans_serial_range");

                entity.Property(e => e.Planserialrangeuuid)
                    .HasColumnName("planserialrangeuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Planuuid).HasColumnName("planuuid");

                entity.Property(e => e.Policyserialrangeuuid).HasColumnName("policyserialrangeuuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPlansSerialRangeCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Planuu)
                    .WithMany(p => p.InsPlansSerialRange)
                    .HasForeignKey(d => d.Planuuid)
                    .HasConstraintName("ins_plans_serial_range_planuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPlansSerialRangeUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsPolicyContactPersonZeus>(entity =>
            {
                entity.HasKey(e => e.Policycontactpersonuuid)
                    .HasName("ins_policy_contact_person_zeus_pkey");

                entity.ToTable("ins_policy_contact_person_zeus");

                entity.Property(e => e.Policycontactpersonuuid)
                    .HasColumnName("policycontactpersonuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Addressline1)
                    .HasColumnName("addressline1")
                    .HasMaxLength(250);

                entity.Property(e => e.Addressline2)
                    .HasColumnName("addressline2")
                    .HasMaxLength(250);

                entity.Property(e => e.Addressline3)
                    .HasColumnName("addressline3")
                    .HasMaxLength(250);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(250);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(250);

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250);

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasMaxLength(500);

                entity.Property(e => e.Homephone)
                    .HasColumnName("homephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Mobilephone)
                    .HasColumnName("mobilephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Otherphone)
                    .HasColumnName("otherphone")
                    .HasMaxLength(50);

                entity.Property(e => e.Policydetailuuid).HasColumnName("policydetailuuid");

                entity.Property(e => e.Postcode)
                    .HasColumnName("postcode")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Policydetailuu)
                    .WithMany(p => p.InsPolicyContactPersonZeus)
                    .HasForeignKey(d => d.Policydetailuuid)
                    .HasConstraintName("ins_policy_contact_person_zeus_policydetailuuid_fkey");
            });

            modelBuilder.Entity<InsPolicyCoverageEncrypted>(entity =>
            {
                entity.ToTable("ins_policy_coverage_encrypted");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("time without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EncryptedData).IsRequired();

                entity.Property(e => e.EncryptedKey).IsRequired();

                entity.Property(e => e.PolicyUuid).HasColumnName("PolicyUUID");
            });

            modelBuilder.Entity<InsPolicyCoveragePersonZeus>(entity =>
            {
                entity.HasKey(e => e.Policycoveragepersonuuid)
                    .HasName("ins_policy_coverage_person_zeus_pkey");

                entity.ToTable("ins_policy_coverage_person_zeus");

                entity.Property(e => e.Policycoveragepersonuuid)
                    .HasColumnName("policycoveragepersonuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Aafeecode)
                    .HasColumnName("aafeecode")
                    .HasMaxLength(50);

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Cor)
                    .HasColumnName("cor")
                    .HasMaxLength(2);

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Currencycode)
                    .HasColumnName("currencycode")
                    .HasMaxLength(3);

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(200);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(1);

                entity.Property(e => e.Idno)
                    .HasColumnName("idno")
                    .HasMaxLength(50);

                entity.Property(e => e.Isqualified).HasColumnName("isqualified");

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(200);

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasMaxLength(2);

                entity.Property(e => e.Paxpremiumamount)
                    .HasColumnName("paxpremiumamount")
                    .HasColumnType("numeric");

                entity.Property(e => e.Paxtype).HasColumnName("paxtype");

                entity.Property(e => e.Plancode)
                    .HasColumnName("plancode")
                    .HasMaxLength(50);

                entity.Property(e => e.Policydetailuuid).HasColumnName("policydetailuuid");

                entity.HasOne(d => d.Policydetailuu)
                    .WithMany(p => p.InsPolicyCoveragePersonZeus)
                    .HasForeignKey(d => d.Policydetailuuid)
                    .HasConstraintName("ins_policy_coverage_person_zeus_policydetailuuid_fkey");
            });

            modelBuilder.Entity<InsPolicyDetailActionsZeus>(entity =>
            {
                entity.HasKey(e => e.Policydetailactionuuid)
                    .HasName("ins_policy_detail_actions_zeus_pkey");

                entity.ToTable("ins_policy_detail_actions_zeus");

                entity.Property(e => e.Policydetailactionuuid)
                    .HasColumnName("policydetailactionuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Cancelledcrdt)
                    .HasColumnName("cancelledcrdt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Cancelledflag).HasColumnName("cancelledflag");

                entity.Property(e => e.Cisentcrdt)
                    .HasColumnName("cisentcrdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Cisentflag).HasColumnName("cisentflag");

                entity.Property(e => e.Policydetailuuid).HasColumnName("policydetailuuid");

                entity.Property(e => e.Uwsentcrdt)
                    .HasColumnName("uwsentcrdt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Uwsentflag).HasColumnName("uwsentflag");

                entity.HasOne(d => d.Policydetailuu)
                    .WithMany(p => p.InsPolicyDetailActionsZeus)
                    .HasForeignKey(d => d.Policydetailuuid)
                    .HasConstraintName("ins_policy_detail_actions_zeus_policydetailuuid_fk");
            });

            modelBuilder.Entity<InsPolicyDetailZeus>(entity =>
            {
                entity.HasKey(e => e.Policydetailuuid)
                    .HasName("ins_policy_detail_zeus_pkey");

                entity.ToTable("ins_policy_detail_zeus");

                entity.Property(e => e.Policydetailuuid)
                    .HasColumnName("policydetailuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Aafeecode)
                    .HasColumnName("aafeecode")
                    .HasMaxLength(50);

                entity.Property(e => e.Arrivalcountrycode)
                    .HasColumnName("arrivalcountrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.Arrivalstationcode)
                    .HasColumnName("arrivalstationcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Channel)
                    .HasColumnName("channel")
                    .HasMaxLength(50);

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Culturecode)
                    .HasColumnName("culturecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Currencycode)
                    .HasColumnName("currencycode")
                    .HasMaxLength(3);

                entity.Property(e => e.Departureairlinecode)
                    .HasColumnName("departureairlinecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Departurecountrycode)
                    .HasColumnName("departurecountrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.Departuredatetime)
                    .HasColumnName("departuredatetime")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Departureflightno)
                    .HasColumnName("departureflightno")
                    .HasMaxLength(5);

                entity.Property(e => e.Departurestationcode)
                    .HasColumnName("departurestationcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Isflight1way).HasColumnName("isflight1way");

                entity.Property(e => e.Isflight2way).HasColumnName("isflight2way");

                entity.Property(e => e.Isflightconnecting).HasColumnName("isflightconnecting");

                entity.Property(e => e.Itinerarystate).HasColumnName("itinerarystate");

                entity.Property(e => e.Plancode)
                    .HasColumnName("plancode")
                    .HasMaxLength(50);

                entity.Property(e => e.Planuuid).HasColumnName("planuuid");

                entity.Property(e => e.Pnr)
                    .HasColumnName("pnr")
                    .HasMaxLength(20);

                entity.Property(e => e.Policyno)
                    .HasColumnName("policyno")
                    .HasMaxLength(50);

                entity.Property(e => e.Pseudoagentcode)
                    .HasColumnName("pseudoagentcode")
                    .HasMaxLength(50);

                entity.Property(e => e.Pseudocitycode)
                    .HasColumnName("pseudocitycode")
                    .HasMaxLength(50);

                entity.Property(e => e.Returnairlinecode)
                    .HasColumnName("returnairlinecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Returndatetime)
                    .HasColumnName("returndatetime")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Returnflightno)
                    .HasColumnName("returnflightno")
                    .HasMaxLength(5);

                entity.Property(e => e.Totaladults).HasColumnName("totaladults");

                entity.Property(e => e.Totalchild).HasColumnName("totalchild");

                entity.Property(e => e.Totalinfants).HasColumnName("totalinfants");

                entity.Property(e => e.Totalpaxes).HasColumnName("totalpaxes");

                entity.Property(e => e.Totalpremiumamount)
                    .HasColumnName("totalpremiumamount")
                    .HasColumnType("numeric");

                entity.Property(e => e.Transactiondate)
                    .HasColumnName("transactiondate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Tripdurationdays).HasColumnName("tripdurationdays");

                entity.Property(e => e.Underwriteruuid).HasColumnName("underwriteruuid");

                entity.HasOne(d => d.Planuu)
                    .WithMany(p => p.InsPolicyDetailZeus)
                    .HasForeignKey(d => d.Planuuid)
                    .HasConstraintName("ins_policy_detail_zeus_planuuid_fkey");

                entity.HasOne(d => d.Underwriteruu)
                    .WithMany(p => p.InsPolicyDetailZeus)
                    .HasForeignKey(d => d.Underwriteruuid)
                    .HasConstraintName("ins_policy_detail_zeus_underwriteruuid_fkey");
            });

            modelBuilder.Entity<InsPolicyPaymentStatus>(entity =>
            {
                entity.HasKey(e => e.Policypaymentstatusuuid)
                    .HasName("ins_policy_payment_status_pkey");

                entity.ToTable("ins_policy_payment_status");

                entity.Property(e => e.Policypaymentstatusuuid)
                    .HasColumnName("policypaymentstatusuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Attempt).HasColumnName("attempt");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Paymentstatus)
                    .HasColumnName("paymentstatus")
                    .HasMaxLength(1);

                entity.Property(e => e.Pnr)
                    .HasColumnName("pnr")
                    .HasMaxLength(10);

                entity.Property(e => e.Proccessedstatus)
                    .HasColumnName("proccessedstatus")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<InsPolicyPaymentStatusLog>(entity =>
            {
                entity.HasKey(e => e.Policypaymentstatusloguuid)
                    .HasName("ins_policy_payment_status_log_pkey");

                entity.ToTable("ins_policy_payment_status_log");

                entity.Property(e => e.Policypaymentstatusloguuid)
                    .HasColumnName("policypaymentstatusloguuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Paymentstatus)
                    .HasColumnName("paymentstatus")
                    .HasMaxLength(1);

                entity.Property(e => e.Pnr)
                    .HasColumnName("pnr")
                    .HasMaxLength(10);

                entity.Property(e => e.Policypaymentstatusuuid).HasColumnName("policypaymentstatusuuid");

                entity.Property(e => e.Proccessedstatus)
                    .HasColumnName("proccessedstatus")
                    .HasMaxLength(1);

                entity.HasOne(d => d.Policypaymentstatusuu)
                    .WithMany(p => p.InsPolicyPaymentStatusLog)
                    .HasForeignKey(d => d.Policypaymentstatusuuid)
                    .HasConstraintName("ins_policy_payment_status_log_policypaymentstatusuuid_fkey");
            });

            modelBuilder.Entity<InsPolicyPremiumLoad>(entity =>
            {
                entity.HasKey(e => e.Loaduuid)
                    .HasName("ins_policy_premium_load_pkey");

                entity.ToTable("ins_policy_premium_load");

                entity.Property(e => e.Loaduuid)
                    .HasColumnName("loaduuid")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnName("createdDate");

                entity.Property(e => e.DepartureLoad).HasColumnType("numeric");

                entity.Property(e => e.DepartureStation)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.FeeCode)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanCode)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Pnr)
                    .HasColumnName("pnr")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReturnLoad).HasColumnType("numeric");

                entity.Property(e => e.ReturnStation)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.TotalPremium).HasColumnType("money");

                entity.Property(e => e.TotalPremiumWithWeather).HasColumnType("money");
            });

            modelBuilder.Entity<InsPolicySent>(entity =>
            {
                entity.ToTable("ins_policy_sent");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("time without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InsPolicySerialRange>(entity =>
            {
                entity.HasKey(e => e.Policyserialrangeuuid)
                    .HasName("ins_policy_serial_range_pkey");

                entity.ToTable("ins_policy_serial_range");

                entity.Property(e => e.Policyserialrangeuuid)
                    .HasColumnName("policyserialrangeuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Efffromdate)
                    .HasColumnName("efffromdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Efftodate)
                    .HasColumnName("efftodate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Lastusedno)
                    .HasColumnName("lastusedno")
                    .HasMaxLength(50);

                entity.Property(e => e.Policynofrom)
                    .IsRequired()
                    .HasColumnName("policynofrom")
                    .HasMaxLength(50);

                entity.Property(e => e.Policynoheader)
                    .HasColumnName("policynoheader")
                    .HasMaxLength(50);

                entity.Property(e => e.Policynoto)
                    .IsRequired()
                    .HasColumnName("policynoto")
                    .HasMaxLength(50);

                entity.Property(e => e.Underwriteruuid).HasColumnName("underwriteruuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPolicySerialRangeCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Underwriteruu)
                    .WithMany(p => p.InsPolicySerialRange)
                    .HasForeignKey(d => d.Underwriteruuid)
                    .HasConstraintName("ins_policy_serial_range_underwriteruuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsPolicySerialRangeUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsPolicyStates>(entity =>
            {
                entity.HasKey(e => e.Policystateid)
                    .HasName("ins_policy_states_pkey");

                entity.ToTable("ins_policy_states");

                entity.Property(e => e.Policystateid)
                    .HasColumnName("policystateid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Itinerarystatedesc)
                    .HasColumnName("itinerarystatedesc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InsPolicyUnsentZeus>(entity =>
            {
                entity.HasKey(e => e.Policyunsentuuid)
                    .HasName("ins_policy_unsent_zeus_pkey");

                entity.ToTable("ins_policy_unsent_zeus");

                entity.Property(e => e.Policyunsentuuid)
                    .HasColumnName("policyunsentuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Arrivalstationcode)
                    .HasColumnName("arrivalstationcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.Coveragepersons)
                    .HasColumnName("coveragepersons")
                    .HasMaxLength(4000);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Culturecode)
                    .HasColumnName("culturecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Departuredatetime)
                    .HasColumnName("departuredatetime")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Departurestationcode)
                    .HasColumnName("departurestationcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250);

                entity.Property(e => e.Isflight1way).HasColumnName("isflight1way");

                entity.Property(e => e.Isflight2way).HasColumnName("isflight2way");

                entity.Property(e => e.Planuuid).HasColumnName("planuuid");

                entity.Property(e => e.Pnr)
                    .HasColumnName("pnr")
                    .HasMaxLength(20);

                entity.Property(e => e.Policydetailuuid).HasColumnName("policydetailuuid");

                entity.Property(e => e.Policyno)
                    .HasColumnName("policyno")
                    .HasMaxLength(50);

                entity.Property(e => e.Returndatetime)
                    .HasColumnName("returndatetime")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsPolicyUnsentZeus)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Planuu)
                    .WithMany(p => p.InsPolicyUnsentZeus)
                    .HasForeignKey(d => d.Planuuid)
                    .HasConstraintName("ins_policy_unsent_zeus_planuuid_fkey");

                entity.HasOne(d => d.Policydetailuu)
                    .WithMany(p => p.InsPolicyUnsentZeus)
                    .HasForeignKey(d => d.Policydetailuuid)
                    .HasConstraintName("ins_policy_unsent_zeus_policydetailuuid_fkey");
            });

            modelBuilder.Entity<InsRaces>(entity =>
            {
                entity.HasKey(e => e.Raceuuid)
                    .HasName("ins_races_pkey");

                entity.ToTable("ins_races");

                entity.Property(e => e.Raceuuid)
                    .HasColumnName("raceuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Racedesc)
                    .IsRequired()
                    .HasColumnName("racedesc")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<InsRatings>(entity =>
            {
                entity.HasKey(e => e.Ratinguuid)
                    .HasName("ins_ratings_pkey");

                entity.ToTable("ins_ratings");

                entity.Property(e => e.Ratinguuid)
                    .HasColumnName("ratinguuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Aafeecode)
                    .HasColumnName("aafeecode")
                    .HasMaxLength(50);

                entity.Property(e => e.Agemax).HasColumnName("agemax");

                entity.Property(e => e.Agemin).HasColumnName("agemin");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Currencycode)
                    .HasColumnName("currencycode")
                    .HasMaxLength(5);

                entity.Property(e => e.Directioncount).HasColumnName("directioncount");

                entity.Property(e => e.Efffromdate)
                    .HasColumnName("efffromdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Efftodate)
                    .HasColumnName("efftodate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(3);

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.Isweeklyrate).HasColumnName("isweeklyrate");

                entity.Property(e => e.Maxduration).HasColumnName("maxduration");

                entity.Property(e => e.Maxpaxcount).HasColumnName("maxpaxcount");

                entity.Property(e => e.Mindeparturetimeminutes).HasColumnName("mindeparturetimeminutes");

                entity.Property(e => e.Minduration).HasColumnName("minduration");

                entity.Property(e => e.Minpaxcount).HasColumnName("minpaxcount");

                entity.Property(e => e.Planuuid).HasColumnName("planuuid");

                entity.Property(e => e.Premiumamount)
                    .HasColumnName("premiumamount")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Stampdutyamount)
                    .HasColumnName("stampdutyamount")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Suminsured)
                    .HasColumnName("suminsured")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Tierno).HasColumnName("tierno");

                entity.Property(e => e.Totalduration).HasColumnName("totalduration");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Vattaxamount)
                    .HasColumnName("vattaxamount")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Vattaxrate)
                    .HasColumnName("vattaxrate")
                    .HasColumnType("numeric(18,2)");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsRatingsCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Planuu)
                    .WithMany(p => p.InsRatings)
                    .HasForeignKey(d => d.Planuuid)
                    .HasConstraintName("ins_ratings_planuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsRatingsUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsRoutes>(entity =>
            {
                entity.HasKey(e => e.Routeuuid)
                    .HasName("ins_routes_pkey");

                entity.ToTable("ins_routes");

                entity.Property(e => e.Routeuuid)
                    .HasColumnName("routeuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Carrieruuid).HasColumnName("carrieruuid");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) with time zone");

                entity.Property(e => e.Routedesc)
                    .HasColumnName("routedesc")
                    .HasMaxLength(500);

                entity.Property(e => e.Routename)
                    .HasColumnName("routename")
                    .HasMaxLength(250);

                entity.Property(e => e.Routetype)
                    .HasColumnName("routetype")
                    .HasMaxLength(50);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) with time zone");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(0) without time zone");

                entity.HasOne(d => d.Carrieruu)
                    .WithMany(p => p.InsRoutes)
                    .HasForeignKey(d => d.Carrieruuid)
                    .HasConstraintName("ins_routes_carrieruuid_fkey");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsRoutesCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsRoutesUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsUnderwriters>(entity =>
            {
                entity.HasKey(e => e.Underwriteruuid)
                    .HasName("ins_underwriters_pkey");

                entity.ToTable("ins_underwriters");

                entity.Property(e => e.Underwriteruuid)
                    .HasColumnName("underwriteruuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Countrycode)
                    .IsRequired()
                    .HasColumnName("countrycode")
                    .HasMaxLength(3);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Underwritercode)
                    .IsRequired()
                    .HasColumnName("underwritercode")
                    .HasMaxLength(10);

                entity.Property(e => e.Underwriterdesc)
                    .IsRequired()
                    .HasColumnName("underwriterdesc")
                    .HasMaxLength(100);

                entity.Property(e => e.Underwriterlogo)
                    .HasColumnName("underwriterlogo")
                    .HasMaxLength(250);

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsUnderwritersCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsUnderwritersUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<InsUnderwritersReports>(entity =>
            {
                entity.HasKey(e => e.Underwriterreportuuid)
                    .HasName("ins_underwriters_reports_pkey");

                entity.ToTable("ins_underwriters_reports");

                entity.Property(e => e.Underwriterreportuuid)
                    .HasColumnName("underwriterreportuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Reportdetails)
                    .HasColumnName("reportdetails")
                    .HasMaxLength(800);

                entity.Property(e => e.Reportendpoint)
                    .HasColumnName("reportendpoint")
                    .HasMaxLength(50);

                entity.Property(e => e.Reportfilename)
                    .HasColumnName("reportfilename")
                    .HasMaxLength(100);

                entity.Property(e => e.Reportgentype).HasColumnName("reportgentype");

                entity.Property(e => e.Reporttype)
                    .HasColumnName("reporttype")
                    .HasMaxLength(50);

                entity.Property(e => e.Underwriteruuid).HasColumnName("underwriteruuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InsUnderwritersReportsCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Underwriteruu)
                    .WithMany(p => p.InsUnderwritersReports)
                    .HasForeignKey(d => d.Underwriteruuid)
                    .HasConstraintName("ins_underwriters_reports_underwriteruuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InsUnderwritersReportsUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<Insurers>(entity =>
            {
                entity.ToTable("insurers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.InsurerCode)
                    .IsRequired()
                    .HasColumnName("insurer_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.InsurerName)
                    .IsRequired()
                    .HasColumnName("insurer_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<InsurersExpenseGroups>(entity =>
            {
                entity.ToTable("insurers_expense_groups");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.ExpensegroupCode)
                    .IsRequired()
                    .HasColumnName("expensegroup_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.ExpensegroupName)
                    .IsRequired()
                    .HasColumnName("expensegroup_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.InsurerId).HasColumnName("insurer_id");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Insurer)
                    .WithMany(p => p.InsurersExpenseGroups)
                    .HasForeignKey(d => d.InsurerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("insurer_id_fkey");
            });

            modelBuilder.Entity<InsurersExpenses>(entity =>
            {
                entity.ToTable("insurers_expenses");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.ExpenseAmount)
                    .HasColumnName("expense_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.ExpenseBasis)
                    .IsRequired()
                    .HasColumnName("expense_basis")
                    .HasColumnType("character varying");

                entity.Property(e => e.ExpenseCode)
                    .IsRequired()
                    .HasColumnName("expense_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.ExpenseName)
                    .IsRequired()
                    .HasColumnName("expense_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ExpensePercentage)
                    .HasColumnName("expense_percentage")
                    .HasColumnType("numeric");

                entity.Property(e => e.ExpensegroupId).HasColumnName("expensegroup_id");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Expensegroup)
                    .WithMany(p => p.InsurersExpenses)
                    .HasForeignKey(d => d.ExpensegroupId)
                    .HasConstraintName("expensegroup_id_fkey");
            });

            modelBuilder.Entity<LookupReference>(entity =>
            {
                entity.ToTable("lookup_reference");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.ReferenceGroup)
                    .IsRequired()
                    .HasColumnName("reference_group")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReferenceName)
                    .IsRequired()
                    .HasColumnName("reference_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReferenceTable)
                    .IsRequired()
                    .HasColumnName("reference_table")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReferenceValue)
                    .IsRequired()
                    .HasColumnName("reference_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("sequence_no")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.LookupReferenceCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lookup_reference_created_by_fkey");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.LookupReferenceModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lookup_reference_modified_by_fkey");
            });

            modelBuilder.Entity<Medcards>(entity =>
            {
                entity.ToTable("medcards");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Activestatus).HasColumnName("activestatus");

                entity.Property(e => e.Cardformat)
                    .HasColumnName("cardformat")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Dependantcount).HasColumnName("dependantcount");

                entity.Property(e => e.Dependants)
                    .HasColumnName("dependants")
                    .HasColumnType("character varying");

                entity.Property(e => e.Designatedclinics)
                    .HasColumnName("designatedclinics")
                    .HasColumnType("character varying");

                entity.Property(e => e.Fontcolor)
                    .HasColumnName("fontcolor")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Memberid)
                    .HasColumnName("memberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Registeredto)
                    .HasColumnName("registeredto")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remarksdependant)
                    .HasColumnName("remarksdependant")
                    .HasColumnType("character varying");

                entity.Property(e => e.Remarksemployee)
                    .HasColumnName("remarksemployee")
                    .HasColumnType("character varying");

                entity.Property(e => e.Urlback)
                    .HasColumnName("urlback")
                    .HasColumnType("character varying");

                entity.Property(e => e.Urlfront)
                    .HasColumnName("urlfront")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Medcards)
                    .HasForeignKey(d => d.Memberid)
                    .HasConstraintName("memberid_fkey");
            });

            modelBuilder.Entity<Members>(entity =>
            {
                entity.HasKey(e => e.Memberid)
                    .HasName("memberid_pkey");

                entity.ToTable("members");

                entity.Property(e => e.Memberid)
                    .HasColumnName("memberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.AllowClaimattachments).HasColumnName("allow_claimattachments");

                entity.Property(e => e.AllowClaimsubmission).HasColumnName("allow_claimsubmission");

                entity.Property(e => e.AllowOtp).HasColumnName("allow_otp");

                entity.Property(e => e.AllowPdpa).HasColumnName("allow_pdpa");

                entity.Property(e => e.Bankaccountnumber)
                    .HasColumnName("bankaccountnumber")
                    .HasColumnType("character varying");

                entity.Property(e => e.Clinictype)
                    .HasColumnName("clinictype")
                    .HasColumnType("character varying");

                entity.Property(e => e.Companyid)
                    .HasColumnName("companyid")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Defaultpinnumber)
                    .HasColumnName("defaultpinnumber")
                    .HasColumnType("character varying");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("character varying");

                entity.Property(e => e.Ecardeligibility).HasColumnName("ecardeligibility");

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Hotlinenumber)
                    .HasColumnName("hotlinenumber")
                    .HasColumnType("character varying");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Mobilenum)
                    .HasColumnName("mobilenum")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nric)
                    .HasColumnName("nric")
                    .HasColumnType("character varying");

                entity.Property(e => e.Parentmemberid)
                    .HasColumnName("parentmemberid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Registeredto)
                    .HasColumnName("registeredto")
                    .HasColumnType("character varying");

                entity.Property(e => e.Relation).HasColumnName("relation");

                entity.Property(e => e.Startdate).HasColumnName("startdate");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Bccto)
                    .HasColumnName("BCCTo")
                    .HasColumnType("character varying");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Ccto)
                    .HasColumnName("CCTo")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Receipent)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Subject).HasColumnType("character varying");
            });

            modelBuilder.Entity<Occupations>(entity =>
            {
                entity.ToTable("occupations");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.OccClass)
                    .IsRequired()
                    .HasColumnName("occ_class")
                    .HasColumnType("character varying");

                entity.Property(e => e.OccCode)
                    .IsRequired()
                    .HasColumnName("occ_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.OccNameExternal)
                    .IsRequired()
                    .HasColumnName("occ_name_external")
                    .HasColumnType("character varying");

                entity.Property(e => e.OccNameInternal)
                    .IsRequired()
                    .HasColumnName("occ_name_internal")
                    .HasColumnType("character varying");

                entity.Property(e => e.OccScore)
                    .HasColumnName("occ_score")
                    .HasColumnType("numeric");

                entity.Property(e => e.OccValue)
                    .HasColumnName("occ_value")
                    .HasColumnType("numeric");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<OrganizationEmployee>(entity =>
            {
                entity.ToTable("organization_employee");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(100);

                entity.Property(e => e.BlacklistId).HasColumnName("blacklist_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Designation)
                    .HasColumnName("designation")
                    .HasMaxLength(30);

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(1);

                entity.Property(e => e.Ghsyrt)
                    .HasColumnName("ghsyrt")
                    .HasMaxLength(14);

                entity.Property(e => e.GhsyrtThree)
                    .HasColumnName("ghsyrt_three")
                    .HasMaxLength(14);

                entity.Property(e => e.Gpsp)
                    .HasColumnName("gpsp")
                    .HasMaxLength(14);

                entity.Property(e => e.Gtl)
                    .HasColumnName("gtl")
                    .HasMaxLength(14);

                entity.Property(e => e.IcId)
                    .IsRequired()
                    .HasColumnName("ic_id")
                    .HasMaxLength(14);

                entity.Property(e => e.JoiningDate).HasColumnName("joining_date");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(90);

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasColumnName("nationality")
                    .HasMaxLength(30);

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.Relationship)
                    .IsRequired()
                    .HasColumnName("relationship")
                    .HasMaxLength(30);

                entity.Property(e => e.StaffId)
                    .HasColumnName("staff_id")
                    .HasMaxLength(14);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.OrganizationEmployeeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("organization_employee_created_by_fkey");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.OrganizationEmployeeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("organization_employee_modified_by_fkey");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrganizationEmployee)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("organization_employee_organization_id_fkey");
            });

            modelBuilder.Entity<OrganizationEmployeeDocuments>(entity =>
            {
                entity.ToTable("organization_employee_documents");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.DocumentCode)
                    .IsRequired()
                    .HasColumnName("document_code")
                    .HasMaxLength(90);

                entity.Property(e => e.FileContentBase64)
                    .IsRequired()
                    .HasColumnName("file_content_base64");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasMaxLength(60);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.OrganizationEmployeeDocumentsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("organization_employee_documents_created_by_fkey");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.OrganizationEmployeeDocumentsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("organization_employee_documents_modified_by_fkey");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrganizationEmployeeDocuments)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("organization_employee_documents_organization_id_fkey");
            });

            modelBuilder.Entity<Otps>(entity =>
            {
                entity.ToTable("otps");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.SendType).HasColumnType("character varying");
            });

            modelBuilder.Entity<PartnerIncentive>(entity =>
            {
                entity.ToTable("partner_incentive");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.IncentiveCalculationTypeId).HasColumnName("incentive_calculation_type_id");

                entity.Property(e => e.IncentiveStructureTypeId).HasColumnName("incentive_structure_type_id");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(60);

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PartnerIncentiveCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partner_incentive_created_by_fkey");

                entity.HasOne(d => d.IncentiveCalculationType)
                    .WithMany(p => p.PartnerIncentiveIncentiveCalculationType)
                    .HasForeignKey(d => d.IncentiveCalculationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partner_incentive_incentive_calculation_type_fkey");

                entity.HasOne(d => d.IncentiveStructureType)
                    .WithMany(p => p.PartnerIncentiveIncentiveStructureType)
                    .HasForeignKey(d => d.IncentiveStructureTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partner_incentive_incentive_type_fkey");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PartnerIncentiveModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("partner_incentive_modified_by_fkey");
            });

            modelBuilder.Entity<PartnerIncentiveJournal>(entity =>
            {
                entity.ToTable("partner_incentive_journal");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CalcRemarks)
                    .HasColumnName("calc_remarks")
                    .HasMaxLength(512);

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.DateCode)
                    .IsRequired()
                    .HasColumnName("date_code")
                    .HasMaxLength(4);

                entity.Property(e => e.GrossPolicyCount).HasColumnName("gross_policy_count");

                entity.Property(e => e.GrossPremiumAmount)
                    .HasColumnName("gross_premium_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.IncentiveAmount)
                    .HasColumnName("incentive_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");
            });

            modelBuilder.Entity<PartnerIncentiveStructure>(entity =>
            {
                entity.ToTable("partner_incentive_structure");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AllocationTypeId).HasColumnName("allocation_type_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Incentive)
                    .HasColumnName("incentive")
                    .HasColumnType("numeric(20,4)");

                entity.Property(e => e.MaxValue)
                    .HasColumnName("max_value")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.MinValue)
                    .HasColumnName("min_value")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.PartnerIncentiveId).HasColumnName("partner_incentive_id");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.AllocationType)
                    .WithMany(p => p.PartnerIncentiveStructure)
                    .HasForeignKey(d => d.AllocationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partner_incentive_structure_allocation_type_id_fkey");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PartnerIncentiveStructureCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partner_incentive_structure_created_by_fkey");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PartnerIncentiveStructureModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("partner_incentive_structure_modified_by_fkey");

                entity.HasOne(d => d.PartnerIncentive)
                    .WithMany(p => p.PartnerIncentiveStructure)
                    .HasForeignKey(d => d.PartnerIncentiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partner_incentive_structure_partner_incentive_id_fkey");
            });

            modelBuilder.Entity<PartnerManagement>(entity =>
            {
                entity.ToTable("partner_management");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_Date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(200);

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.StartDate).HasColumnName("start_Date");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.PartnerManagement)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("partner_organization_id_fkey");
            });

            modelBuilder.Entity<PartnerOrganization>(entity =>
            {
                entity.ToTable("partner_organization");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.OrganizationName)
                    .IsRequired()
                    .HasColumnName("organization_name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PartnerOrganizationIncentive>(entity =>
            {
                entity.ToTable("partner_organization_incentive");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.PartnerIncentiveId).HasColumnName("partner_incentive_id");

                entity.Property(e => e.PartnerOrganizationId).HasColumnName("partner_organization_id");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PartnerOrganizationIncentiveCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partner_organization_incentive_created_by_fkey");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PartnerOrganizationIncentiveModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("partner_organization_incentive_modified_by_fkey");

                entity.HasOne(d => d.PartnerIncentive)
                    .WithMany(p => p.PartnerOrganizationIncentive)
                    .HasForeignKey(d => d.PartnerIncentiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partner_organization_incentive_partner_incentive_id_fkey");

                entity.HasOne(d => d.PartnerOrganization)
                    .WithMany(p => p.PartnerOrganizationIncentive)
                    .HasForeignKey(d => d.PartnerOrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partner_organization_incentive_partner_organization_id_fkey");
            });

            modelBuilder.Entity<PartnerPlanMapping>(entity =>
            {
                entity.ToTable("partner_plan_mapping");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnerPlanMapping)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partner_management_partner_id_fkey");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PartnerPlanMapping)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_Setting_id_fkey");
            });

            modelBuilder.Entity<Partners>(entity =>
            {
                entity.ToTable("partners");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("json");

                entity.Property(e => e.Businessentityname)
                    .HasColumnName("businessentityname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Businessentityno)
                    .HasColumnName("businessentityno")
                    .HasColumnType("character varying");

                entity.Property(e => e.Contactdetails)
                    .HasColumnName("contactdetails")
                    .HasColumnType("json");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.Establishedyear).HasColumnName("establishedyear");

                entity.Property(e => e.Industrycode)
                    .HasColumnName("industrycode")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.IsLocked).HasColumnName("is_locked");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Partnercode)
                    .HasColumnName("partnercode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Partnertype)
                    .HasColumnName("partnertype")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sourceid).HasColumnName("sourceid");

                entity.Property(e => e.Startdate).HasColumnName("startdate");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<PaymentBatchLog>(entity =>
            {
                entity.ToTable("payment_batch_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentOptionId).HasColumnName("payment_option_id");

                entity.Property(e => e.PaymentProviderId).HasColumnName("payment_provider_id");

                entity.Property(e => e.PostOutStatus).HasColumnName("post_out_status");

                entity.Property(e => e.PreOutStatus).HasColumnName("pre_out_status");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasColumnName("prefix")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<PaymentOptions>(entity =>
            {
                entity.ToTable("payment_options");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PayoptionCode)
                    .IsRequired()
                    .HasColumnName("payoption_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.PayoptionName)
                    .IsRequired()
                    .HasColumnName("payoption_name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<PaymentProcess>(entity =>
            {
                entity.ToTable("payment_process");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Channel)
                    .HasColumnName("channel")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.GatewayUrl)
                    .IsRequired()
                    .HasColumnName("gateway_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsPost).HasColumnName("is_post");

                entity.Property(e => e.PaymentProviderId).HasColumnName("payment_provider_id");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("transaction_type")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.PaymentProvider)
                    .WithMany(p => p.PaymentProcess)
                    .HasForeignKey(d => d.PaymentProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("payment_provider_id");
            });

            modelBuilder.Entity<PaymentProcessItem>(entity =>
            {
                entity.ToTable("payment_process_item");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Delimeter)
                    .HasColumnName("delimeter")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsSecure).HasColumnName("is_secure");

                entity.Property(e => e.IsUsedForSecureKey).HasColumnName("is_used_for_secure_key");

                entity.Property(e => e.ItemDataDesc)
                    .HasColumnName("item_data_desc")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemDataFormat)
                    .HasColumnName("item_data_format")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemName)
                    .HasColumnName("item_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentProcessId).HasColumnName("payment_process_id");

                entity.Property(e => e.SecureKey)
                    .HasColumnName("secure_key")
                    .HasColumnType("character varying");

                entity.Property(e => e.SecureKeySequence).HasColumnName("secure_key_sequence");

                entity.Property(e => e.SecureType).HasColumnName("secure_type");

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.TrueValue)
                    .HasColumnName("true_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.PaymentProcess)
                    .WithMany(p => p.PaymentProcessItem)
                    .HasForeignKey(d => d.PaymentProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("payment_process_id");
            });

            modelBuilder.Entity<PaymentProviders>(entity =>
            {
                entity.ToTable("payment_providers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PayproviderCode)
                    .IsRequired()
                    .HasColumnName("payprovider_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.PayproviderName)
                    .IsRequired()
                    .HasColumnName("payprovider_name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<PaymentRequest>(entity =>
            {
                entity.HasKey(e => e.MerchantTransid)
                    .HasName("payment_request_pkey");

                entity.ToTable("payment_request");

                entity.Property(e => e.MerchantTransid)
                    .HasColumnName("merchant_transid")
                    .ValueGeneratedNever();

                entity.Property(e => e.PaymentCriteria)
                    .HasColumnName("payment_criteria")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentGateway)
                    .IsRequired()
                    .HasColumnName("payment_gateway")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentIndicator)
                    .HasColumnName("payment_indicator")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentInfo)
                    .HasColumnName("payment_info")
                    .HasColumnType("json");

                entity.Property(e => e.RequestJson)
                    .HasColumnName("request_json")
                    .HasColumnType("json");

                entity.Property(e => e.ResponseJson)
                    .HasColumnName("response_json")
                    .HasColumnType("json");

                entity.Property(e => e.SaleChannel)
                    .IsRequired()
                    .HasColumnName("sale_channel")
                    .HasColumnType("character varying");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("transaction_type")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<PaymentRequestValidation>(entity =>
            {
                entity.ToTable("payment_request_validation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.PaymentRequestId).HasColumnName("payment_request_id");

                entity.Property(e => e.RequestJson)
                    .HasColumnName("request_json")
                    .HasColumnType("json");

                entity.Property(e => e.ResponseJaon)
                    .HasColumnName("response_jaon")
                    .HasColumnType("json");
            });

            modelBuilder.Entity<PaymentTransactionProvider>(entity =>
            {
                entity.ToTable("payment_transaction_provider");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.PaymentProviderId).HasColumnName("payment_provider_id");

                entity.Property(e => e.PaymentRecurringId).HasColumnName("payment_recurring_id");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.TransactionReference)
                    .IsRequired()
                    .HasColumnName("transaction_reference")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.PaymentProvider)
                    .WithMany(p => p.PaymentTransactionProvider)
                    .HasForeignKey(d => d.PaymentProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transaction_provider_fk");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PaymentTransactionProvider)
                    .HasForeignKey(d => d.PolicyId)
                    .HasConstraintName("transaction_policy_fk");
            });

            modelBuilder.Entity<PgStatStatements>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pg_stat_statements");

                entity.Property(e => e.BlkReadTime).HasColumnName("blk_read_time");

                entity.Property(e => e.BlkWriteTime).HasColumnName("blk_write_time");

                entity.Property(e => e.Calls).HasColumnName("calls");

                entity.Property(e => e.Dbid)
                    .HasColumnName("dbid")
                    .HasColumnType("oid");

                entity.Property(e => e.LocalBlksDirtied).HasColumnName("local_blks_dirtied");

                entity.Property(e => e.LocalBlksHit).HasColumnName("local_blks_hit");

                entity.Property(e => e.LocalBlksRead).HasColumnName("local_blks_read");

                entity.Property(e => e.LocalBlksWritten).HasColumnName("local_blks_written");

                entity.Property(e => e.MaxExecTime).HasColumnName("max_exec_time");

                entity.Property(e => e.MaxPlanTime).HasColumnName("max_plan_time");

                entity.Property(e => e.MeanExecTime).HasColumnName("mean_exec_time");

                entity.Property(e => e.MeanPlanTime).HasColumnName("mean_plan_time");

                entity.Property(e => e.MinExecTime).HasColumnName("min_exec_time");

                entity.Property(e => e.MinPlanTime).HasColumnName("min_plan_time");

                entity.Property(e => e.Plans).HasColumnName("plans");

                entity.Property(e => e.Query).HasColumnName("query");

                entity.Property(e => e.Queryid).HasColumnName("queryid");

                entity.Property(e => e.Rows).HasColumnName("rows");

                entity.Property(e => e.SharedBlksDirtied).HasColumnName("shared_blks_dirtied");

                entity.Property(e => e.SharedBlksHit).HasColumnName("shared_blks_hit");

                entity.Property(e => e.SharedBlksRead).HasColumnName("shared_blks_read");

                entity.Property(e => e.SharedBlksWritten).HasColumnName("shared_blks_written");

                entity.Property(e => e.StddevExecTime).HasColumnName("stddev_exec_time");

                entity.Property(e => e.StddevPlanTime).HasColumnName("stddev_plan_time");

                entity.Property(e => e.TempBlksRead).HasColumnName("temp_blks_read");

                entity.Property(e => e.TempBlksWritten).HasColumnName("temp_blks_written");

                entity.Property(e => e.Toplevel).HasColumnName("toplevel");

                entity.Property(e => e.TotalExecTime).HasColumnName("total_exec_time");

                entity.Property(e => e.TotalPlanTime).HasColumnName("total_plan_time");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("oid");

                entity.Property(e => e.WalBytes)
                    .HasColumnName("wal_bytes")
                    .HasColumnType("numeric");

                entity.Property(e => e.WalFpi).HasColumnName("wal_fpi");

                entity.Property(e => e.WalRecords).HasColumnName("wal_records");
            });

            modelBuilder.Entity<PgStatStatementsInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pg_stat_statements_info");

                entity.Property(e => e.Dealloc).HasColumnName("dealloc");

                entity.Property(e => e.StatsReset)
                    .HasColumnName("stats_reset")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<PlanBenefit>(entity =>
            {
                entity.ToTable("plan_benefit");

                entity.HasIndex(e => new { e.CurrencyCode, e.StatusId, e.Category })
                    .HasName("plan_benefit_index")
                    .HasOperators(new[] { "varchar_ops", null, null });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Claimtpasetting)
                    .HasColumnName("claimtpasetting")
                    .HasColumnType("character varying");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.GracePeriod)
                    .HasColumnName("grace_period")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsAmountorpercentage).HasColumnName("is_amountorpercentage");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.MaxAge).HasColumnName("max_age");

                entity.Property(e => e.MaxPercentage)
                    .HasColumnName("max_percentage")
                    .HasColumnType("numeric");

                entity.Property(e => e.MaxSumInsured)
                    .HasColumnName("max_sum_insured")
                    .HasColumnType("numeric");

                entity.Property(e => e.MinAge).HasColumnName("min_age");

                entity.Property(e => e.MinPercentage)
                    .HasColumnName("min_percentage")
                    .HasColumnType("numeric");

                entity.Property(e => e.Percentage)
                    .HasColumnName("percentage")
                    .HasColumnType("numeric");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.SumInsuredRelation)
                    .HasColumnName("sum_insured_relation")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PlanBenefitCategory>(entity =>
            {
                entity.ToTable("plan_benefit_category");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");
            });

            modelBuilder.Entity<PlanBenefitConfig>(entity =>
            {
                entity.ToTable("plan_benefit_config");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.LimitTypeId).HasColumnName("limit_type_id");

                entity.Property(e => e.MaxAmount)
                    .HasColumnName("max_amount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinAmount)
                    .HasColumnName("min_amount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlanBenefitId).HasColumnName("plan_benefit_id");

                entity.HasOne(d => d.PlanBenefit)
                    .WithMany(p => p.PlanBenefitConfig)
                    .HasForeignKey(d => d.PlanBenefitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_id_pk");
            });

            modelBuilder.Entity<PlanBenefitCustomInput>(entity =>
            {
                entity.ToTable("plan_benefit_custom_input");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.InputDescription)
                    .IsRequired()
                    .HasColumnName("input_description")
                    .HasColumnType("character varying");

                entity.Property(e => e.InputName)
                    .IsRequired()
                    .HasColumnName("input_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.InputTypeId).HasColumnName("input_type_id");

                entity.Property(e => e.IsRequired).HasColumnName("is_required");

                entity.Property(e => e.RegexExpression)
                    .HasColumnName("regex_expression")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.InputType)
                    .WithMany(p => p.PlanBenefitCustomInput)
                    .HasForeignKey(d => d.InputTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("input_type_fk");
            });

            modelBuilder.Entity<PlanBenefitCustomInputList>(entity =>
            {
                entity.ToTable("plan_benefit_custom_input_list");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.ListItemName)
                    .IsRequired()
                    .HasColumnName("list_item_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ListItemValue)
                    .IsRequired()
                    .HasColumnName("list_item_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanBenefitCustomInputId).HasColumnName("plan_benefit_custom_input_id");

                entity.HasOne(d => d.PlanBenefitCustomInput)
                    .WithMany(p => p.PlanBenefitCustomInputList)
                    .HasForeignKey(d => d.PlanBenefitCustomInputId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_custom_input_id_fk");
            });

            modelBuilder.Entity<PlanBenefitCustomInputTemplate>(entity =>
            {
                entity.ToTable("plan_benefit_custom_input_template");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<PlanBenefitCustomInputTemplateItem>(entity =>
            {
                entity.ToTable("plan_benefit_custom_input_template_item");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.PlanBenefitCustomInputId).HasColumnName("plan_benefit_custom_input_id");

                entity.Property(e => e.PlanBenefitCustomInputTemplateId).HasColumnName("plan_benefit_custom_input_template_id");

                entity.HasOne(d => d.PlanBenefitCustomInput)
                    .WithMany(p => p.PlanBenefitCustomInputTemplateItem)
                    .HasForeignKey(d => d.PlanBenefitCustomInputId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_custom_input_id_fk");

                entity.HasOne(d => d.PlanBenefitCustomInputTemplate)
                    .WithMany(p => p.PlanBenefitCustomInputTemplateItem)
                    .HasForeignKey(d => d.PlanBenefitCustomInputTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_custom_input_template_id_fk");
            });

            modelBuilder.Entity<PlanBenefitCustomInputTemplateMap>(entity =>
            {
                entity.ToTable("plan_benefit_custom_input_template_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.PlanBenefitCustomInputTemplateId).HasColumnName("plan_benefit_custom_input_template_id");

                entity.Property(e => e.PlanBenefitId).HasColumnName("plan_benefit_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updated_date")
                    .HasColumnType("time without time zone");

                entity.HasOne(d => d.PlanBenefitCustomInputTemplate)
                    .WithMany(p => p.PlanBenefitCustomInputTemplateMap)
                    .HasForeignKey(d => d.PlanBenefitCustomInputTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_custom_input_template_id_fk");

                entity.HasOne(d => d.PlanBenefit)
                    .WithMany(p => p.PlanBenefitCustomInputTemplateMap)
                    .HasForeignKey(d => d.PlanBenefitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_id_fk");
            });

            modelBuilder.Entity<PlanBenefitCustomInputType>(entity =>
            {
                entity.ToTable("plan_benefit_custom_input_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.DecimalRounding).HasColumnName("decimal_rounding");

                entity.Property(e => e.IsDecimal).HasColumnName("is_decimal");

                entity.Property(e => e.IsNumeric).HasColumnName("is_numeric");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("type_name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<PlanBenefitGroup>(entity =>
            {
                entity.ToTable("plan_benefit_group");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ClaimCode).HasColumnName("claim_code");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("last_modified_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.MaxSumInsured)
                    .HasColumnName("max_sum_insured")
                    .HasColumnType("numeric");

                entity.Property(e => e.PlanClaimGroupDesc)
                    .IsRequired()
                    .HasColumnName("plan_claim_group_desc")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanClaimGroupName)
                    .IsRequired()
                    .HasColumnName("plan_claim_group_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanClaimTypeId).HasColumnName("plan_claim_type_id");

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.SumInsuredRelation)
                    .HasColumnName("sum_insured_relation")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PlanBenefitGroupConfig>(entity =>
            {
                entity.ToTable("plan_benefit_group_config");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_Date");

                entity.Property(e => e.LimitTypeId).HasColumnName("limit_type_id");

                entity.Property(e => e.MaxAmount)
                    .HasColumnName("max_amount")
                    .HasColumnType("money");

                entity.Property(e => e.MinAmount)
                    .HasColumnName("min_amount")
                    .HasColumnType("money");

                entity.Property(e => e.PlanBenefitGroupId).HasColumnName("plan_benefit_group_id");

                entity.HasOne(d => d.PlanBenefitGroup)
                    .WithMany(p => p.PlanBenefitGroupConfig)
                    .HasForeignKey(d => d.PlanBenefitGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_group_id_fk");
            });

            modelBuilder.Entity<PlanBenefitGroupMap>(entity =>
            {
                entity.ToTable("plan_benefit_group_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.PlanBenefitGroupId).HasColumnName("plan_benefit_group_id");

                entity.Property(e => e.PlanBenefitId).HasColumnName("plan_benefit_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.HasOne(d => d.PlanBenefitGroup)
                    .WithMany(p => p.PlanBenefitGroupMap)
                    .HasForeignKey(d => d.PlanBenefitGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_group_id_fk");

                entity.HasOne(d => d.PlanBenefit)
                    .WithMany(p => p.PlanBenefitGroupMap)
                    .HasForeignKey(d => d.PlanBenefitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_id_fk");
            });

            modelBuilder.Entity<PlanBenefitMap>(entity =>
            {
                entity.ToTable("plan_benefit_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PlanBenefitGroupId).HasColumnName("plan_benefit_group_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.HasOne(d => d.PlanBenefitGroup)
                    .WithMany(p => p.PlanBenefitMap)
                    .HasForeignKey(d => d.PlanBenefitGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_group_id_fk");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanBenefitMap)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fkey");
            });

            modelBuilder.Entity<PlanBenefitRate>(entity =>
            {
                entity.ToTable("plan_benefit_rate");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.LimitType).HasColumnName("limit_type");

                entity.Property(e => e.MaxAmount)
                    .HasColumnName("max_amount")
                    .HasColumnType("money");

                entity.Property(e => e.MinAmount)
                    .HasColumnName("min_amount")
                    .HasColumnType("money");

                entity.Property(e => e.PlanBenefitId).HasColumnName("plan_benefit_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.HasOne(d => d.PlanBenefit)
                    .WithMany(p => p.PlanBenefitRate)
                    .HasForeignKey(d => d.PlanBenefitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_id_pk");
            });

            modelBuilder.Entity<PlanBenefitSupportingDocuments>(entity =>
            {
                entity.ToTable("plan_benefit_supporting_documents");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsRequired).HasColumnName("is_required");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<PlanBenefitSupportingDocumentsMap>(entity =>
            {
                entity.ToTable("plan_benefit_supporting_documents_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.PlanBenefitId).HasColumnName("plan_benefit_id");

                entity.Property(e => e.PlanBenefitSupportingDocumentsId).HasColumnName("plan_benefit_supporting_documents_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.HasOne(d => d.PlanBenefit)
                    .WithMany(p => p.PlanBenefitSupportingDocumentsMap)
                    .HasForeignKey(d => d.PlanBenefitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_id_fk");

                entity.HasOne(d => d.PlanBenefitSupportingDocuments)
                    .WithMany(p => p.PlanBenefitSupportingDocumentsMap)
                    .HasForeignKey(d => d.PlanBenefitSupportingDocumentsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_supporting_document_id_fk");
            });

            modelBuilder.Entity<PlanBenefitSupportingDocumentsTranslation>(entity =>
            {
                entity.ToTable("plan_benefit_supporting_documents_translation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasColumnName("locale")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanBenefitSupportingDocumentsId).HasColumnName("plan_benefit_supporting_documents_id");

                entity.HasOne(d => d.PlanBenefitSupportingDocuments)
                    .WithMany(p => p.PlanBenefitSupportingDocumentsTranslation)
                    .HasForeignKey(d => d.PlanBenefitSupportingDocumentsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_supporting_documents_id_fk");
            });

            modelBuilder.Entity<PlanBenefitTranslation>(entity =>
            {
                entity.ToTable("plan_benefit_translation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasColumnName("locale")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanBenefitId).HasColumnName("plan_benefit_id");

                entity.HasOne(d => d.PlanBenefit)
                    .WithMany(p => p.PlanBenefitTranslation)
                    .HasForeignKey(d => d.PlanBenefitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_benefit_id_fk");
            });

            modelBuilder.Entity<PlanCategory>(entity =>
            {
                entity.ToTable("plan_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");
            });

            modelBuilder.Entity<PlanCertificate>(entity =>
            {
                entity.ToTable("plan_certificate");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CertificateContent)
                    .IsRequired()
                    .HasColumnName("certificate_content")
                    .HasColumnType("character varying");

                entity.Property(e => e.CertificateDescription)
                    .HasColumnName("certificate_description")
                    .HasColumnType("character varying");

                entity.Property(e => e.CertificateName)
                    .IsRequired()
                    .HasColumnName("certificate_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<PlanCertificateMap>(entity =>
            {
                entity.ToTable("plan_certificate_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.DocFilename)
                    .HasColumnName("doc_filename")
                    .HasColumnType("character varying");

                entity.Property(e => e.DocumentAction)
                    .HasColumnName("document_action")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DocumentType)
                    .HasColumnName("document_type")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.IsPasswordProtected).HasColumnName("is_password_protected");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanCertificateId).HasColumnName("plan_certificate_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.HasOne(d => d.PlanCertificate)
                    .WithMany(p => p.PlanCertificateMap)
                    .HasForeignKey(d => d.PlanCertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_certificate_id_fk");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanCertificateMap)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fk");
            });

            modelBuilder.Entity<PlanCertificateTranslation>(entity =>
            {
                entity.ToTable("plan_certificate_translation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("		 created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("		 created_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasColumnName("locale")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanCertificateId).HasColumnName("plan_certificate_id");

                entity.HasOne(d => d.PlanCertificate)
                    .WithMany(p => p.PlanCertificateTranslation)
                    .HasForeignKey(d => d.PlanCertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_certificate_id_fk");
            });

            modelBuilder.Entity<PlanClaimBenefit>(entity =>
            {
                entity.ToTable("plan_claim_benefit");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BenefitCode)
                    .IsRequired()
                    .HasColumnName("benefit_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.BenefitDescription)
                    .IsRequired()
                    .HasColumnName("benefit_description")
                    .HasColumnType("character varying");

                entity.Property(e => e.BenefitName)
                    .IsRequired()
                    .HasColumnName("benefit_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ClaimCountMax).HasColumnName("claim_count_max");

                entity.Property(e => e.CoverageAmount)
                    .HasColumnName("coverage_amount")
                    .HasColumnType("money");

                entity.Property(e => e.CoverageAmountMin)
                    .HasColumnName("coverage_amount_min")
                    .HasColumnType("money");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.IsBasedOnSuminsured).HasColumnName("is_based_on_suminsured");

                entity.Property(e => e.IsMedical).HasColumnName("is_medical");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.MultiplierSuminsured)
                    .HasColumnName("multiplier_suminsured")
                    .HasColumnType("money");

                entity.Property(e => e.PayoutType)
                    .IsRequired()
                    .HasColumnName("payout_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Weightage).HasColumnName("weightage");
            });

            modelBuilder.Entity<PlanClaimBenefitRates>(entity =>
            {
                entity.ToTable("plan_claim_benefit_rates");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BenefitRateDesc)
                    .IsRequired()
                    .HasColumnName("benefit_rate_desc")
                    .HasColumnType("character varying");

                entity.Property(e => e.BenefitRateName)
                    .IsRequired()
                    .HasColumnName("benefit_rate_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsBasedOnSuminsured).HasColumnName("is_based_on_suminsured");

                entity.Property(e => e.IsFixedAmount).HasColumnName("is_fixed_amount");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PlanClaimBenefitId).HasColumnName("plan_claim_benefit_id");

                entity.Property(e => e.RateAmount)
                    .HasColumnName("rate_amount")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<PlanCommencement>(entity =>
            {
                entity.ToTable("plan_commencement");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Commencementdayvalue).HasColumnName("commencementdayvalue");

                entity.Property(e => e.Currentdayvalueend).HasColumnName("currentdayvalueend");

                entity.Property(e => e.Currentdayvaluestart).HasColumnName("currentdayvaluestart");

                entity.Property(e => e.PlanCommencementGroupId).HasColumnName("plan_commencement_group_id");

                entity.HasOne(d => d.PlanCommencementGroup)
                    .WithMany(p => p.PlanCommencement)
                    .HasForeignKey(d => d.PlanCommencementGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_commencement_group_id_fkey");
            });

            modelBuilder.Entity<PlanCommencementGroup>(entity =>
            {
                entity.ToTable("plan_commencement_group");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PlanCommencementDesc)
                    .IsRequired()
                    .HasColumnName("plan_commencement_desc")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanCommencementName)
                    .IsRequired()
                    .HasColumnName("plan_commencement_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Statusid).HasColumnName("statusid");
            });

            modelBuilder.Entity<PlanCriteria>(entity =>
            {
                entity.ToTable("plan_criteria");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasColumnName("condition")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.FixedValue)
                    .HasColumnName("fixed_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.Input)
                    .IsRequired()
                    .HasColumnName("input")
                    .HasColumnType("character varying");

                entity.Property(e => e.Jsoncolumn)
                    .IsRequired()
                    .HasColumnName("jsoncolumn")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanFormulaMasterId).HasColumnName("plan_formula_master_id");

                entity.HasOne(d => d.PlanFormulaMaster)
                    .WithMany(p => p.PlanCriteria)
                    .HasForeignKey(d => d.PlanFormulaMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_master_formula_id_fk");
            });

            modelBuilder.Entity<PlanCriteriaPremiumMap>(entity =>
            {
                entity.ToTable("plan_criteria_premium_map");

                entity.HasIndex(e => e.PlanFormulaPremiumMapId)
                    .HasName("plan_criteria_premium_map_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasColumnName("condition")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Input)
                    .IsRequired()
                    .HasColumnName("input")
                    .HasColumnType("character varying");

                entity.Property(e => e.Jsoncolumn)
                    .IsRequired()
                    .HasColumnName("jsoncolumn")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanFormulaPremiumMapId).HasColumnName("plan_formula_premium_map_id");

                entity.HasOne(d => d.PlanFormulaPremiumMap)
                    .WithMany(p => p.PlanCriteriaPremiumMap)
                    .HasForeignKey(d => d.PlanFormulaPremiumMapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_criteria_premium_fk");
            });

            modelBuilder.Entity<PlanCustomInput>(entity =>
            {
                entity.ToTable("plan_custom_input");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.InputDescription)
                    .HasColumnName("input_description")
                    .HasColumnType("character varying");

                entity.Property(e => e.InputName)
                    .IsRequired()
                    .HasColumnName("input_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.InputTypeId).HasColumnName("input_type_id");

                entity.Property(e => e.IsCustomValidation).HasColumnName("is_custom_validation");

                entity.Property(e => e.IsInsured).HasColumnName("is_insured");

                entity.Property(e => e.IsMandatory).HasColumnName("is_mandatory");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.RegexExpression)
                    .HasColumnName("regex_expression")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.InputType)
                    .WithMany(p => p.PlanCustomInput)
                    .HasForeignKey(d => d.InputTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("input_type_id_fk");
            });

            modelBuilder.Entity<PlanCustomInputList>(entity =>
            {
                entity.ToTable("plan_custom_input_list");

                entity.HasIndex(e => e.PlanCustomInputId)
                    .HasName("plan_custom_input_list_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.ListItemName)
                    .IsRequired()
                    .HasColumnName("list_item_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ListItemValue)
                    .IsRequired()
                    .HasColumnName("list_item_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanCustomInputId).HasColumnName("plan_custom_input_id");

                entity.HasOne(d => d.PlanCustomInput)
                    .WithMany(p => p.PlanCustomInputList)
                    .HasForeignKey(d => d.PlanCustomInputId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_custom_input_id_fk");
            });

            modelBuilder.Entity<PlanCustomInputTemplate>(entity =>
            {
                entity.ToTable("plan_custom_input_template");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<PlanCustomInputTemplateItem>(entity =>
            {
                entity.ToTable("plan_custom_input_template_item");

                entity.HasIndex(e => new { e.PlanCustomInputTemplateId, e.PlanCustomInputId })
                    .HasName("custom_input_template_item_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.PlanCustomInputId).HasColumnName("plan_custom_input_id");

                entity.Property(e => e.PlanCustomInputTemplateId).HasColumnName("plan_custom_input_template_id");

                entity.HasOne(d => d.PlanCustomInput)
                    .WithMany(p => p.PlanCustomInputTemplateItem)
                    .HasForeignKey(d => d.PlanCustomInputId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_custom_input_id_fk");

                entity.HasOne(d => d.PlanCustomInputTemplate)
                    .WithMany(p => p.PlanCustomInputTemplateItem)
                    .HasForeignKey(d => d.PlanCustomInputTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_custom_input_template_id_fk");
            });

            modelBuilder.Entity<PlanCustomInputTemplateMap>(entity =>
            {
                entity.ToTable("plan_custom_input_template_map");

                entity.HasIndex(e => new { e.Planid, e.PlanCustomInputTemplateId, e.StartDate, e.EndDate })
                    .HasName("plan_custom_input_map_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.PlanCustomInputTemplateId).HasColumnName("plan_custom_input_template_id");

                entity.Property(e => e.Planid).HasColumnName("planid");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.HasOne(d => d.PlanCustomInputTemplate)
                    .WithMany(p => p.PlanCustomInputTemplateMap)
                    .HasForeignKey(d => d.PlanCustomInputTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_custom_input_template_id_fk");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanCustomInputTemplateMap)
                    .HasForeignKey(d => d.Planid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fk");
            });

            modelBuilder.Entity<PlanExternalApi>(entity =>
            {
                entity.ToTable("plan_external_api");

                entity.HasIndex(e => new { e.PlanId, e.StatusId, e.IsBilling })
                    .HasName("plan_external_api_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AuthorizationType).HasColumnName("authorization_type");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.IsBilling).HasColumnName("is_billing");

                entity.Property(e => e.IsFirstOnly).HasColumnName("is_first_only");

                entity.Property(e => e.IsPriority).HasColumnName("is_priority");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PolicyReferenceColumn)
                    .HasColumnName("policy_reference_column")
                    .HasColumnType("character varying");

                entity.Property(e => e.RequestBody)
                    .IsRequired()
                    .HasColumnName("request_body")
                    .HasColumnType("json");

                entity.Property(e => e.RequestUrl)
                    .IsRequired()
                    .HasColumnName("request_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanExternalApi)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_external_api_plan");
            });

            modelBuilder.Entity<PlanFormula>(entity =>
            {
                entity.ToTable("plan_formula");

                entity.HasIndex(e => new { e.PlanFormulaMasterId, e.PlanVariableId, e.StartDate, e.EndDate })
                    .HasName("plan_formula_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CalculationFormula)
                    .HasColumnName("calculation_formula")
                    .HasColumnType("character varying");

                entity.Property(e => e.CalculationType).HasColumnName("calculation_type");

                entity.Property(e => e.ChargeType)
                    .HasColumnName("charge_type")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.DisplayCalc).HasColumnName("display_calc");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.IsAddFactorPayment).HasColumnName("is_add_factor_payment");

                entity.Property(e => e.JsonColumn)
                    .HasColumnName("json_column")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PlanFormulaMasterId).HasColumnName("plan_formula_master_id");

                entity.Property(e => e.PlanVariableId).HasColumnName("plan_variable_id");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.ValueSign)
                    .HasColumnName("value_sign")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.PlanFormulaMaster)
                    .WithMany(p => p.PlanFormula)
                    .HasForeignKey(d => d.PlanFormulaMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_formula_master_id");

                entity.HasOne(d => d.PlanVariable)
                    .WithMany(p => p.PlanFormula)
                    .HasForeignKey(d => d.PlanVariableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_variable_id_fk");
            });

            modelBuilder.Entity<PlanFormulaMaster>(entity =>
            {
                entity.ToTable("plan_formula_master");

                entity.HasIndex(e => new { e.PlanId, e.StartDate, e.EndDate, e.StatusId })
                    .HasName("plan_formula_master_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.EndDateReference).HasColumnName("end_date_reference");

                entity.Property(e => e.EndDateValueType)
                    .HasColumnName("end_date_value_type")
                    .HasMaxLength(20);

                entity.Property(e => e.FixedValue).HasColumnName("fixed_value");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.EndDateReferenceNavigation)
                    .WithMany(p => p.PlanFormulaMaster)
                    .HasForeignKey(d => d.EndDateReference)
                    .HasConstraintName("formula_master_custom_input_fk");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanFormulaMaster)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fk");
            });

            modelBuilder.Entity<PlanFormulaPremiumMap>(entity =>
            {
                entity.ToTable("plan_formula_premium_map");

                entity.HasIndex(e => new { e.PlanFormulaMasterId, e.PlanPremiumTableId })
                    .HasName("plan_formula_premium_map_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.PlanFormulaMasterId).HasColumnName("plan_formula_master_id");

                entity.Property(e => e.PlanPremiumTableId).HasColumnName("plan_premium_table_id");

                entity.HasOne(d => d.PlanFormulaMaster)
                    .WithMany(p => p.PlanFormulaPremiumMap)
                    .HasForeignKey(d => d.PlanFormulaMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_formula_id_fk");

                entity.HasOne(d => d.PlanPremiumTable)
                    .WithMany(p => p.PlanFormulaPremiumMap)
                    .HasForeignKey(d => d.PlanPremiumTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_premium_table_id_fk");
            });

            modelBuilder.Entity<PlanInputType>(entity =>
            {
                entity.ToTable("plan_input_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DecimalRounding).HasColumnName("decimal_rounding");

                entity.Property(e => e.IsDecimal).HasColumnName("is_decimal");

                entity.Property(e => e.IsNumeric).HasColumnName("is_numeric");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("type_name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<PlanMajorClass>(entity =>
            {
                entity.ToTable("plan_major_class");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("last_modified_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.MajorClassName)
                    .IsRequired()
                    .HasColumnName("major_class_name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PlanMarketing>(entity =>
            {
                entity.ToTable("plan_marketing");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.HtmlBody)
                    .IsRequired()
                    .HasColumnName("html_body")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("last_modified_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.MarketingDescription)
                    .HasColumnName("marketing_description")
                    .HasColumnType("character varying");

                entity.Property(e => e.MarketingName)
                    .IsRequired()
                    .HasColumnName("marketing_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<PlanMarketingMap>(entity =>
            {
                entity.ToTable("plan_marketing_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PlanMarketingId).HasColumnName("plan_marketing_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanMarketingMap)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fk");

                entity.HasOne(d => d.PlanMarketing)
                    .WithMany(p => p.PlanMarketingMap)
                    .HasForeignKey(d => d.PlanMarketingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_marketing_id_fk");
            });

            modelBuilder.Entity<PlanMarketingTranslation>(entity =>
            {
                entity.ToTable("plan_marketing_translation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.LastModifedBy).HasColumnName("last_modifed_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasColumnName("locale")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanMarketingId).HasColumnName("plan_marketing_id");

                entity.HasOne(d => d.PlanMarketing)
                    .WithMany(p => p.PlanMarketingTranslation)
                    .HasForeignKey(d => d.PlanMarketingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_marketing_id_fk");
            });

            modelBuilder.Entity<PlanMessage>(entity =>
            {
                entity.ToTable("plan_message");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.IsBodyHtml).HasColumnName("is_body_html");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.MessageBody)
                    .HasColumnName("message_body")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageDescription)
                    .IsRequired()
                    .HasColumnName("message_description")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageName)
                    .IsRequired()
                    .HasColumnName("message_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageTitle)
                    .HasColumnName("message_title")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageTypeId).HasColumnName("message_type_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PlanMessageMap>(entity =>
            {
                entity.ToTable("plan_message_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("last_modified_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PlanMessageId).HasColumnName("plan_message_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanMessageMap)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fk");

                entity.HasOne(d => d.PlanMessage)
                    .WithMany(p => p.PlanMessageMap)
                    .HasForeignKey(d => d.PlanMessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_message_id_fk");
            });

            modelBuilder.Entity<PlanMessageTranslation>(entity =>
            {
                entity.ToTable("plan_message_translation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasColumnName("locale")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanMessageId).HasColumnName("plan_message_id");

                entity.HasOne(d => d.PlanMessage)
                    .WithMany(p => p.PlanMessageTranslation)
                    .HasForeignKey(d => d.PlanMessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_message_id_fk");
            });

            modelBuilder.Entity<PlanPaymentFreq>(entity =>
            {
                entity.ToTable("plan_payment_freq");

                entity.HasIndex(e => new { e.Statusid, e.StartDate, e.EndDate })
                    .HasName("plan_payment_freq_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.FreqValue).HasColumnName("freq_value");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PayFreqDescription)
                    .IsRequired()
                    .HasColumnName("pay_freq_description")
                    .HasColumnType("character varying");

                entity.Property(e => e.PayFreqTerm)
                    .IsRequired()
                    .HasColumnName("pay_freq_term")
                    .HasColumnType("character varying");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Statusid).HasColumnName("statusid");
            });

            modelBuilder.Entity<PlanPremiumTable>(entity =>
            {
                entity.ToTable("plan_premium_table");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.DocName)
                    .HasColumnName("doc_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TableColumns)
                    .HasColumnName("table_columns")
                    .HasColumnType("character varying");

                entity.Property(e => e.TableJson)
                    .IsRequired()
                    .HasColumnName("table_json")
                    .HasColumnType("json");
            });

            modelBuilder.Entity<PlanPromoCodeMap>(entity =>
            {
                entity.ToTable("plan_promo_code_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.IsLimited).HasColumnName("is_limited");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PlanVariableId).HasColumnName("plan_variable_id");

                entity.Property(e => e.PromoCodeId).HasColumnName("promo_code_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.UsedQuantity).HasColumnName("used_quantity");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanPromoCodeMap)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_promo_plan_fk");

                entity.HasOne(d => d.PlanVariable)
                    .WithMany(p => p.PlanPromoCodeMap)
                    .HasForeignKey(d => d.PlanVariableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_promo_variable_fk");

                entity.HasOne(d => d.PromoCode)
                    .WithMany(p => p.PlanPromoCodeMap)
                    .HasForeignKey(d => d.PromoCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_promo_code_fk");
            });

            modelBuilder.Entity<PlanRandomNumber>(entity =>
            {
                entity.ToTable("plan_random_number");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.MaxNumber).HasColumnName("max_number");

                entity.Property(e => e.MinNumber).HasColumnName("min_number");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasColumnName("position")
                    .HasColumnType("character varying");

                entity.Property(e => e.RandomNumberName)
                    .IsRequired()
                    .HasColumnName("random_number_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PlanSerial>(entity =>
            {
                entity.ToTable("plan_serial");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndNumber).HasColumnName("end_number");

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasColumnName("format")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.NextNumber).HasColumnName("next_number");

                entity.Property(e => e.PlanPostfix)
                    .HasColumnName("plan_postfix")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanPrefix)
                    .HasColumnName("plan_prefix")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanSerialName)
                    .IsRequired()
                    .HasColumnName("plan_serial_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.RandomNumberId).HasColumnName("random_number_id");

                entity.Property(e => e.StartNumber).HasColumnName("start_number");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.RandomNumber)
                    .WithMany(p => p.PlanSerial)
                    .HasForeignKey(d => d.RandomNumberId)
                    .HasConstraintName("random_number_id_fk");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PlanSerial)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("status_id_fk");
            });

            modelBuilder.Entity<PlanSetting>(entity =>
            {
                entity.ToTable("plan_setting");

                entity.HasIndex(e => e.PlanCode)
                    .HasName("planCode")
                    .IsUnique();

                entity.HasIndex(e => new { e.PlanCode, e.StatusId, e.CurrencyCode, e.StartDate, e.EndDate, e.Category })
                    .HasName("plan_setting_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.ClaimActionFullLimit).HasColumnName("claim_action_full_limit");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.InsurerId).HasColumnName("insurer_id");

                entity.Property(e => e.IsMasterPolicy).HasColumnName("is_master_policy");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.MaxInsuredPerson)
                    .HasColumnName("max_insured_person")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MaxPolicyHolder)
                    .HasColumnName("max_policy_holder")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MaxSumInsured)
                    .HasColumnName("max_sum_insured")
                    .HasColumnType("numeric");

                entity.Property(e => e.MinInsuredPerson).HasColumnName("min_insured_person");

                entity.Property(e => e.MinPolicyHolder).HasColumnName("min_policy_holder");

                entity.Property(e => e.MinSumInsured)
                    .HasColumnName("min_sum_insured")
                    .HasColumnType("numeric");

                entity.Property(e => e.OverallAnnualLimit)
                    .HasColumnName("overall_annual_limit")
                    .HasColumnType("numeric");

                entity.Property(e => e.PlanAgeRestrictions)
                    .HasColumnName("plan_age_restrictions")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanCode)
                    .IsRequired()
                    .HasColumnName("plan_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanDescription)
                    .HasColumnName("plan_description")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanMajorClassId).HasColumnName("plan_major_class_id");

                entity.Property(e => e.PlanParentId).HasColumnName("plan_parent_id");

                entity.Property(e => e.PlanSubClassId).HasColumnName("plan_sub_class_id");

                entity.Property(e => e.QuoteSerialId).HasColumnName("quote_serial_id");

                entity.Property(e => e.RenewalActionLimit).HasColumnName("renewal_action_limit");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusEncryptdata).HasColumnName("status_encryptdata");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StatusPurgedata).HasColumnName("status_purgedata");

                entity.Property(e => e.SumInsured)
                    .HasColumnName("sum_insured")
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.PlanParent)
                    .WithMany(p => p.InversePlanParent)
                    .HasForeignKey(d => d.PlanParentId)
                    .HasConstraintName("plan_parent_id");

                entity.HasOne(d => d.QuoteSerial)
                    .WithMany(p => p.PlanSetting)
                    .HasForeignKey(d => d.QuoteSerialId)
                    .HasConstraintName("plan_quote_serial");
            });

            modelBuilder.Entity<PlanSettingBillingRetryRules>(entity =>
            {
                entity.ToTable("plan_setting_billing_retry_rules");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("last_modified_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.MaxMonthlyPremiumAmount)
                    .HasColumnName("max_monthly_premium_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.MaxRetriesAnnually).HasColumnName("max_retries_annually");

                entity.Property(e => e.MaxRetriesLifetime).HasColumnName("max_retries_lifetime");

                entity.Property(e => e.MaxRetriesMonthly).HasColumnName("max_retries_monthly");

                entity.Property(e => e.MinMonthlyPremiumAmount)
                    .HasColumnName("min_monthly_premium_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanSettingBillingRetryRules)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fk");
            });

            modelBuilder.Entity<PlanSettingCommencementGroupMap>(entity =>
            {
                entity.ToTable("plan_setting_commencement_group_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PlanCommencementGroupId).HasColumnName("plan_commencement_group_id");

                entity.Property(e => e.PlanCommencementName)
                    .HasColumnName("plan_commencement_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.PlanCommencementGroup)
                    .WithMany(p => p.PlanSettingCommencementGroupMap)
                    .HasForeignKey(d => d.PlanCommencementGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_commencement_group_id_fk");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanSettingCommencementGroupMap)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fk");
            });

            modelBuilder.Entity<PlanSettingCommissions>(entity =>
            {
                entity.ToTable("plan_setting_commissions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AllocationTypeId).HasColumnName("allocation_type_id");

                entity.Property(e => e.Commission)
                    .HasColumnName("commission")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.CommissionStructureTypeId).HasColumnName("commission_structure_type_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.MaxValue)
                    .HasColumnName("max_value")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.MinValue)
                    .HasColumnName("min_value")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(60);

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.AllocationType)
                    .WithMany(p => p.PlanSettingCommissionsAllocationType)
                    .HasForeignKey(d => d.AllocationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_setting_commissions_commission_type_value_lookup_refe_fkey");

                entity.HasOne(d => d.CommissionStructureType)
                    .WithMany(p => p.PlanSettingCommissionsCommissionStructureType)
                    .HasForeignKey(d => d.CommissionStructureTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_setting_commissions_commission_type_lookup_reference__fkey");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanSettingCommissionsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_setting_commissions_created_by_fkey");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanSettingCommissionsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("plan_setting_commissions_modified_by_fkey");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanSettingCommissions)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_setting_commissions_plan_id_fkey");
            });

            modelBuilder.Entity<PlanSettingConfig>(entity =>
            {
                entity.ToTable("plan_setting_config");

                entity.HasIndex(e => e.PlanId)
                    .HasName("setting_config_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AdditionalRules)
                    .HasColumnName("additional_rules")
                    .HasColumnType("json");

                entity.Property(e => e.AdvanceBillingNotificationTemplateEmail).HasColumnName("advance_billing_notification_template_email");

                entity.Property(e => e.AdvanceBillingNotificationTemplateSms).HasColumnName("advance_billing_notification_template_sms");

                entity.Property(e => e.AdvancedBillingReminder).HasColumnName("advanced_billing_reminder");

                entity.Property(e => e.AllowClaimsDuringGracePeriod).HasColumnName("allow_claims_during_grace_period");

                entity.Property(e => e.AllowRevival).HasColumnName("allow_revival");

                entity.Property(e => e.BillingCycleDay)
                    .HasColumnName("billing_cycle_day")
                    .HasColumnType("character varying");

                entity.Property(e => e.CancellationPeriodDays).HasColumnName("cancellation_period_days");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.FailedBillingNotification).HasColumnName("failed_billing_notification");

                entity.Property(e => e.FailedBillingNotificationTemplateEmail).HasColumnName("failed_billing_notification_template_email");

                entity.Property(e => e.FailedBillingNotificationTemplateSms).HasColumnName("failed_billing_notification_template_sms");

                entity.Property(e => e.FailedBillingReminder).HasColumnName("failed_billing_reminder");

                entity.Property(e => e.GracePeriodDays).HasColumnName("grace_period_days");

                entity.Property(e => e.IsAllowCancellation)
                    .HasColumnName("is_allow_cancellation")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IsAllowRefund)
                    .HasColumnName("is_allow_refund")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.LapsedBillingNotificationTemplateEmail).HasColumnName("lapsed_billing_notification_template_email");

                entity.Property(e => e.LapsedBillingNotificationTemplateEmailJson)
                    .HasColumnName("lapsed_billing_notification_template_email_json")
                    .HasColumnType("json");

                entity.Property(e => e.LapsedBillingNotificationTemplateSms).HasColumnName("lapsed_billing_notification_template_sms");

                entity.Property(e => e.LapsedNotification).HasColumnName("lapsed_notification");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("last_modified_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.MaxLapsedBillingDays).HasColumnName("max_lapsed_billing_days");

                entity.Property(e => e.MaxOutstandingAmountCharged)
                    .HasColumnName("max_outstanding_amount_charged")
                    .HasColumnType("numeric");

                entity.Property(e => e.MaxOutstandingMonthsCharged).HasColumnName("max_outstanding_months_charged");

                entity.Property(e => e.PlanDurationYears).HasColumnName("plan_duration_years");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.RefundRate)
                    .HasColumnName("refund_rate")
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SuccessBillingNotificationTemplateEmail).HasColumnName("success_billing_notification_template_email");

                entity.Property(e => e.WaitingPeriodDays).HasColumnName("waiting_period_days");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanSettingConfig)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fk");
            });

            modelBuilder.Entity<PlanSettingExchangeRate>(entity =>
            {
                entity.ToTable("plan_setting_exchange_rate");

                entity.HasIndex(e => new { e.PlanSettingId, e.CurrencyCode })
                    .HasName("setting_exchange_rate_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CurrencyRate)
                    .HasColumnName("currency_rate")
                    .HasColumnType("numeric");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.PlanSettingId).HasColumnName("plan_setting_id");

                entity.HasOne(d => d.PlanSetting)
                    .WithMany(p => p.PlanSettingExchangeRate)
                    .HasForeignKey(d => d.PlanSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("exchange_rate_plan_setting_fk");
            });

            modelBuilder.Entity<PlanSettingExchangeRateLog>(entity =>
            {
                entity.ToTable("plan_setting_exchange_rate_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CurrencyRate)
                    .HasColumnName("currency_rate")
                    .HasColumnType("money");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.PlanSettingId).HasColumnName("plan_setting_id");

                entity.HasOne(d => d.PlanSetting)
                    .WithMany(p => p.PlanSettingExchangeRateLog)
                    .HasForeignKey(d => d.PlanSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("exchange_rate_log_plan_setting_fk");
            });

            modelBuilder.Entity<PlanSettingExchangeRateSchedule>(entity =>
            {
                entity.ToTable("plan_setting_exchange_rate_schedule");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CurrencyRate)
                    .HasColumnName("currency_rate")
                    .HasColumnType("money")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.PlanSettingId).HasColumnName("plan_setting_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.HasOne(d => d.PlanSetting)
                    .WithMany(p => p.PlanSettingExchangeRateSchedule)
                    .HasForeignKey(d => d.PlanSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_setting_id_fk");
            });

            modelBuilder.Entity<PlanSettingIndustriesMap>(entity =>
            {
                entity.ToTable("plan_setting_industries_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.IndustryGroupId).HasColumnName("industry_group_id");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.HasOne(d => d.IndustryGroup)
                    .WithMany(p => p.PlanSettingIndustriesMap)
                    .HasForeignKey(d => d.IndustryGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("industry_group_id_fkey");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanSettingIndustriesMap)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fkey");
            });

            modelBuilder.Entity<PlanSettingMap>(entity =>
            {
                entity.ToTable("plan_setting_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ChildPlanId).HasColumnName("child_plan_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.ParentPlanId).HasColumnName("parent_plan_id");

                entity.HasOne(d => d.ChildPlan)
                    .WithMany(p => p.PlanSettingMapChildPlan)
                    .HasForeignKey(d => d.ChildPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_child_plan_id_plan_setting_map");

                entity.HasOne(d => d.ParentPlan)
                    .WithMany(p => p.PlanSettingMapParentPlan)
                    .HasForeignKey(d => d.ParentPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_parent_plan_id_plan_setting_map");
            });

            modelBuilder.Entity<PlanSettingModule>(entity =>
            {
                entity.ToTable("plan_setting_module");

                entity.HasIndex(e => e.PlanId)
                    .HasName("setting_module_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.ModuleType).HasColumnName("module_type");

                entity.Property(e => e.ModuleValue).HasColumnName("module_value");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanSettingModule)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_setting_module_plan_fk");
            });

            modelBuilder.Entity<PlanSettingPaymentFreqMap>(entity =>
            {
                entity.ToTable("plan_setting_payment_freq_map");

                entity.HasIndex(e => new { e.PlanId, e.PlanPayFreqId, e.StartDate, e.EndDate })
                    .HasName("setting_payment_freq_map_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.FirstPaymentAdvance)
                    .HasColumnName("first_payment_advance")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsApplyToFormula).HasColumnName("is_apply_to_formula");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PayFactorValue)
                    .HasColumnName("pay_factor_value")
                    .HasColumnType("numeric");

                entity.Property(e => e.PayFreqTerm)
                    .HasColumnName("pay_freq_term")
                    .HasColumnType("character varying");

                entity.Property(e => e.PayFreqValue).HasColumnName("pay_freq_value");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PlanPayFreqId).HasColumnName("plan_pay_freq_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanSettingPaymentFreqMap)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fk");

                entity.HasOne(d => d.PlanPayFreq)
                    .WithMany(p => p.PlanSettingPaymentFreqMap)
                    .HasForeignKey(d => d.PlanPayFreqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_pay_freq_id_fkey");
            });

            modelBuilder.Entity<PlanSettingPaymentOptions>(entity =>
            {
                entity.ToTable("plan_setting_payment_options");

                entity.HasIndex(e => new { e.PlanId, e.StartDate, e.EndDate })
                    .HasName("setting_payment_option_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("last_modified_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.MaxMonthlyPremiumAmount)
                    .HasColumnName("max_monthly_premium_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.MinMonthlyPremiumAmount)
                    .HasColumnName("min_monthly_premium_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.PayoptionId).HasColumnName("payoption_id");

                entity.Property(e => e.PayproviderId).HasColumnName("payprovider_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TokenJson)
                    .HasColumnName("token_json")
                    .HasColumnType("character varying");

                entity.Property(e => e.TokenTypeId).HasColumnName("token_type_id");

                entity.HasOne(d => d.Payoption)
                    .WithMany(p => p.PlanSettingPaymentOptions)
                    .HasForeignKey(d => d.PayoptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("payoption_id_fk");

                entity.HasOne(d => d.Payprovider)
                    .WithMany(p => p.PlanSettingPaymentOptions)
                    .HasForeignKey(d => d.PayproviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("payprovider_id_fk");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanSettingPaymentOptions)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fk");
            });

            modelBuilder.Entity<PlanSettingReinsuranceCommissions>(entity =>
            {
                entity.ToTable("plan_setting_reinsurance_commissions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.ReinsuranceCommissionId).HasColumnName("reinsurance_commission_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanSettingReinsuranceCommissionsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_setting_reinsurance_commissions_created_by_fkey");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanSettingReinsuranceCommissionsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("plan_setting_reinsurance_commissions_modified_by_fkey");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanSettingReinsuranceCommissions)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_setting_reinsurance_commissions_plan_id_fkey");

                entity.HasOne(d => d.ReinsuranceCommission)
                    .WithMany(p => p.PlanSettingReinsuranceCommissions)
                    .HasForeignKey(d => d.ReinsuranceCommissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_setting_reinsurance_commiss_reinsurance_commission_id_fkey");
            });

            modelBuilder.Entity<PlanSettingRevivalRules>(entity =>
            {
                entity.ToTable("plan_setting_revival_rules");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("last_modified_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.MaxDays)
                    .HasColumnName("max_days")
                    .HasColumnType("numeric");

                entity.Property(e => e.MinDays)
                    .HasColumnName("min_days")
                    .HasColumnType("numeric");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.RequireFullUnderwriting).HasColumnName("require_full_underwriting");

                entity.Property(e => e.RequireIndebtness).HasColumnName("require_indebtness");

                entity.Property(e => e.RequireInterest).HasColumnName("require_interest");

                entity.Property(e => e.RequirePersonalDeclarations).HasColumnName("require_personal_declarations");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanSettingRevivalRules)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fk");
            });

            modelBuilder.Entity<PlanSettingSerial>(entity =>
            {
                entity.ToTable("plan_setting_serial");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PlanSerialId).HasColumnName("plan_serial_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanSettingSerial)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fk");

                entity.HasOne(d => d.PlanSerial)
                    .WithMany(p => p.PlanSettingSerial)
                    .HasForeignKey(d => d.PlanSerialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_serial_id_fk");
            });

            modelBuilder.Entity<PlanSubClass>(entity =>
            {
                entity.ToTable("plan_sub_class");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.MajorClassId).HasColumnName("major_class_id");

                entity.Property(e => e.SubClassName)
                    .IsRequired()
                    .HasColumnName("sub_class_name")
                    .HasMaxLength(200);

                entity.HasOne(d => d.MajorClass)
                    .WithMany(p => p.PlanSubClass)
                    .HasForeignKey(d => d.MajorClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_sub_class_major_class_id_fkey");
            });

            modelBuilder.Entity<PlanUwAnswers>(entity =>
            {
                entity.ToTable("plan_uw_answers");

                entity.HasIndex(e => new { e.PlanUwQuestionId, e.NextQuestionId, e.AnswerCode })
                    .HasName("uw_answers_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AnswerCode)
                    .IsRequired()
                    .HasColumnName("answer_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.AnswerDesc)
                    .IsRequired()
                    .HasColumnName("answer_desc")
                    .HasColumnType("character varying");

                entity.Property(e => e.AnswerTranslation)
                    .HasColumnName("answer_translation")
                    .HasColumnType("character varying");

                entity.Property(e => e.AnswerValue)
                    .IsRequired()
                    .HasColumnName("answer_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.NextQuestionId).HasColumnName("next_question_id");

                entity.Property(e => e.PlanUwQuestionId).HasColumnName("plan_uw_question_id");

                entity.Property(e => e.Weightage)
                    .HasColumnName("weightage")
                    .HasColumnType("numeric");

                entity.HasOne(d => d.NextQuestion)
                    .WithMany(p => p.PlanUwAnswersNextQuestion)
                    .HasForeignKey(d => d.NextQuestionId)
                    .HasConstraintName("next_question_id_fk");

                entity.HasOne(d => d.PlanUwQuestion)
                    .WithMany(p => p.PlanUwAnswersPlanUwQuestion)
                    .HasForeignKey(d => d.PlanUwQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_uw_question_id_fkey");
            });

            modelBuilder.Entity<PlanUwGroup>(entity =>
            {
                entity.ToTable("plan_uw_group");

                entity.HasIndex(e => new { e.StatusId, e.StartDate, e.EndDate })
                    .HasName("uw_groups_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasColumnName("group_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.GroupDesc)
                    .IsRequired()
                    .HasColumnName("group_desc")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Weightage).HasColumnName("weightage");
            });

            modelBuilder.Entity<PlanUwGroupMap>(entity =>
            {
                entity.ToTable("plan_uw_group_map");

                entity.HasIndex(e => new { e.PlanId, e.PlanUwGroupId, e.StartDate, e.EndDate })
                    .HasName("uw_group_map_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PlanUwGroupId).HasColumnName("plan_uw_group_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanUwGroupMap)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fkey");

                entity.HasOne(d => d.PlanUwGroup)
                    .WithMany(p => p.PlanUwGroupMap)
                    .HasForeignKey(d => d.PlanUwGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_uw_group_id_fk");
            });

            modelBuilder.Entity<PlanUwPermutationFormulaMap>(entity =>
            {
                entity.ToTable("plan_uw_permutation_formula_map");

                entity.HasIndex(e => new { e.PlanUwPermutationId, e.PlanFormulaId, e.StatusId, e.StartDate, e.EndDate })
                    .HasName("uw_permutation_map_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PlanFormulaId).HasColumnName("plan_formula_id");

                entity.Property(e => e.PlanUwPermutationId).HasColumnName("plan_uw_permutation_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.PlanFormula)
                    .WithMany(p => p.PlanUwPermutationFormulaMap)
                    .HasForeignKey(d => d.PlanFormulaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_formula_id_fkey");

                entity.HasOne(d => d.PlanUwPermutation)
                    .WithMany(p => p.PlanUwPermutationFormulaMap)
                    .HasForeignKey(d => d.PlanUwPermutationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_uw_permutation_id_fkey");
            });

            modelBuilder.Entity<PlanUwPermutations>(entity =>
            {
                entity.ToTable("plan_uw_permutations");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PlanUwPermutations1)
                    .IsRequired()
                    .HasColumnName("plan_uw_permutations")
                    .HasColumnType("json");

                entity.Property(e => e.PlanVariables)
                    .IsRequired()
                    .HasColumnName("plan_variables")
                    .HasColumnType("json");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanUwPermutations)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fkey");
            });

            modelBuilder.Entity<PlanUwQuestions>(entity =>
            {
                entity.ToTable("plan_uw_questions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ComparisonType)
                    .HasColumnName("comparison_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.DefaultAnswer)
                    .HasColumnName("default_answer")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.QuestionCode)
                    .IsRequired()
                    .HasColumnName("question_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.QuestionDesc)
                    .IsRequired()
                    .HasColumnName("question_desc")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Weightage).HasColumnName("weightage");
            });

            modelBuilder.Entity<PlanUwQuestionsMap>(entity =>
            {
                entity.ToTable("plan_uw_questions_map");

                entity.HasIndex(e => new { e.PlanUwGroupId, e.PlanUwQuestionId })
                    .HasName("uw_questions_map_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.PlanUwGroupId).HasColumnName("plan_uw_group_id");

                entity.Property(e => e.PlanUwQuestionId).HasColumnName("plan_uw_question_id");

                entity.Property(e => e.Weightage).HasColumnName("weightage");

                entity.HasOne(d => d.PlanUwGroup)
                    .WithMany(p => p.PlanUwQuestionsMap)
                    .HasForeignKey(d => d.PlanUwGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_uw_group_id_fkey");

                entity.HasOne(d => d.PlanUwQuestion)
                    .WithMany(p => p.PlanUwQuestionsMap)
                    .HasForeignKey(d => d.PlanUwQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_uw_question_id_fkey");
            });

            modelBuilder.Entity<PlanUwQuestionsTranslation>(entity =>
            {
                entity.ToTable("plan_uw_questions_translation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasColumnName("locale")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanUwQuestionsId).HasColumnName("plan_uw_questions_id");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnName("question")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate).HasColumnName("updated_date");

                entity.HasOne(d => d.PlanUwQuestions)
                    .WithMany(p => p.PlanUwQuestionsTranslation)
                    .HasForeignKey(d => d.PlanUwQuestionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_uw_question_id_fk");
            });

            modelBuilder.Entity<PlanVariable>(entity =>
            {
                entity.ToTable("plan_variable");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.DefaultValueSign)
                    .HasColumnName("default_value_sign")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.VariableDescription)
                    .HasColumnName("variable_description")
                    .HasColumnType("character varying");

                entity.Property(e => e.VariableName)
                    .IsRequired()
                    .HasColumnName("variable_name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Policy>(entity =>
            {
                entity.ToTable("policy");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Channel)
                    .HasColumnName("channel")
                    .HasColumnType("character varying");

                entity.Property(e => e.ConfirmRequest)
                    .HasColumnName("confirm_request")
                    .HasColumnType("json");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.DependentPolicyId).HasColumnName("dependent_policy_id");

                entity.Property(e => e.DistributionpartnerId).HasColumnName("distributionpartner_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.ExtensionJson)
                    .HasColumnName("extension_json")
                    .HasColumnType("json");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("invoice_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsMasterPolicy).HasColumnName("is_master_policy");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.ParentPolicyId).HasColumnName("parent_policy_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.PolicyNo)
                    .HasColumnName("policy_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyRequestId).HasColumnName("policy_request_id");

                entity.Property(e => e.PremiumAmount)
                    .HasColumnName("premium_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.RefPolicyNo)
                    .HasColumnName("ref_policy_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusCoiSent).HasColumnName("status_coi_sent");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.SumInsured)
                    .HasColumnName("sum_insured")
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TpaInfo)
                    .HasColumnName("tpa_info")
                    .HasColumnType("json");

                entity.Property(e => e.Treatment)
                    .HasColumnName("treatment")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.ParentPolicy)
                    .WithMany(p => p.InverseParentPolicy)
                    .HasForeignKey(d => d.ParentPolicyId)
                    .HasConstraintName("policy_policy_parent_fk");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("policy_plan_setting_fk");
            });

            modelBuilder.Entity<PolicyAttachmentLog>(entity =>
            {
                entity.ToTable("policy_attachment_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Description).HasColumnType("character varying");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemContent)
                    .IsRequired()
                    .HasColumnName("item_content")
                    .HasColumnType("character varying");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyAttachmentLog)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("policy_log_fk");
            });

            modelBuilder.Entity<PolicyCancellation>(entity =>
            {
                entity.ToTable("policy_cancellation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CancelledBy).HasColumnName("cancelled_by");

                entity.Property(e => e.CancelledDate)
                    .HasColumnName("cancelled_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.PolicyDuration).HasColumnName("policy_duration");

                entity.Property(e => e.PolicyDurationWhenCancel).HasColumnName("policy_duration_when_cancel");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasColumnName("policy_no")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.RefundAmount)
                    .HasColumnName("refund_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.RefundRate)
                    .HasColumnName("refund_rate")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<PolicyCommunication>(entity =>
            {
                entity.ToTable("policy_communication");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContentHeader)
                    .HasColumnName("content_header")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContentType).HasColumnName("content_type");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyCommunication)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("policy_com_policy_fk");
            });

            modelBuilder.Entity<PolicyCompanyWitness>(entity =>
            {
                entity.ToTable("policy_company_witness");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.IdentityType).HasColumnName("identity_type");

                entity.Property(e => e.IdentityValue)
                    .HasColumnName("identity_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.InsurerId).HasColumnName("insurer_id");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Insurer)
                    .WithMany(p => p.PolicyCompanyWitness)
                    .HasForeignKey(d => d.InsurerId)
                    .HasConstraintName("insurer_id_fkey");
            });

            modelBuilder.Entity<PolicyDependent>(entity =>
            {
                entity.ToTable("policy_dependent");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.DependentPolicyId).HasColumnName("dependent_policy_id");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.RelationshipToParent).HasColumnName("relationship_to_parent");
            });

            modelBuilder.Entity<PolicyHolder>(entity =>
            {
                entity.ToTable("policy_holder");

                entity.HasIndex(e => e.IdNo)
                    .HasName("idno_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("character varying");

                entity.Property(e => e.AddressCity)
                    .HasColumnName("address_city")
                    .HasColumnType("character varying");

                entity.Property(e => e.AddressCountry)
                    .HasColumnName("address_country")
                    .HasColumnType("character varying");

                entity.Property(e => e.AddressPostalcode)
                    .HasColumnName("address_postalcode")
                    .HasColumnType("character varying");

                entity.Property(e => e.AddressState)
                    .HasColumnName("address_state")
                    .HasColumnType("character varying");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.ExtensionJson)
                    .HasColumnName("extension_json")
                    .HasColumnType("json");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("character varying");

                entity.Property(e => e.IdNo)
                    .HasColumnName("id_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.InsuredType)
                    .HasColumnName("insured_type")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyHolder)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_policy_holder_policy");
            });

            modelBuilder.Entity<PolicyHolderContact>(entity =>
            {
                entity.ToTable("policy_holder_contact");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasColumnName("contact_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasColumnName("contact_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.MobileCountryCode)
                    .HasColumnName("mobile_country_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyHolderId).HasColumnName("policy_holder_id");

                entity.HasOne(d => d.PolicyHolder)
                    .WithMany(p => p.PolicyHolderContact)
                    .HasForeignKey(d => d.PolicyHolderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contact_policy_holder");
            });

            modelBuilder.Entity<PolicyHolderEndorsement>(entity =>
            {
                entity.ToTable("policy_holder_endorsement");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ActionDate).HasColumnName("action_date");

                entity.Property(e => e.ActionSection)
                    .IsRequired()
                    .HasColumnName("action_section")
                    .HasMaxLength(30);

                entity.Property(e => e.ActionTask)
                    .IsRequired()
                    .HasColumnName("action_task")
                    .HasMaxLength(20);

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyHolderEndorsement)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("policy_holder_endorsement_policy_id_fkey");
            });

            modelBuilder.Entity<PolicyJournal>(entity =>
            {
                entity.ToTable("policy_journal");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.PaymentProjectionId).HasColumnName("payment_projection_id");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.PremiumAmount)
                    .HasColumnName("premium_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.PremiumBreakdown)
                    .HasColumnName("premium_breakdown")
                    .HasColumnType("json");

                entity.Property(e => e.ReferenceRemark)
                    .HasColumnName("reference_remark")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.PaymentProjection)
                    .WithMany(p => p.PolicyJournal)
                    .HasForeignKey(d => d.PaymentProjectionId)
                    .HasConstraintName("policy_journal_projection");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyJournal)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("policy_journal_policy_fk");
            });

            modelBuilder.Entity<PolicyMasterDetails>(entity =>
            {
                entity.ToTable("policy_master_details");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Maxinsuredperson)
                    .HasColumnName("maxinsuredperson")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Mininsuredperson)
                    .HasColumnName("mininsuredperson")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.Planpermutation)
                    .HasColumnName("planpermutation")
                    .HasColumnType("json");

                entity.Property(e => e.Planstructure)
                    .HasColumnName("planstructure")
                    .HasColumnType("json");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.PolicyMasterDetails)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entity_id_fkey");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PolicyMasterDetails)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fkey");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyMasterDetails)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("policy_id_fkey");
            });

            modelBuilder.Entity<PolicyNominee>(entity =>
            {
                entity.ToTable("policy_nominee");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("character varying");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("address_2")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("character varying");

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasColumnName("contact_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasColumnType("character varying");

                entity.Property(e => e.IdentityType)
                    .IsRequired()
                    .HasColumnName("identity_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.IdentityValue)
                    .IsRequired()
                    .HasColumnName("identity_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.MobileCountryCode)
                    .HasColumnName("mobile_country_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasColumnName("nationality")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasColumnName("postcode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Relationship)
                    .IsRequired()
                    .HasColumnName("relationship")
                    .HasColumnType("character varying");

                entity.Property(e => e.Religion)
                    .IsRequired()
                    .HasColumnName("religion")
                    .HasColumnType("character varying");

                entity.Property(e => e.SharePercentage).HasColumnName("share_percentage");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasColumnType("character varying");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.WitnessType)
                    .HasColumnName("witness_type")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyNominee)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("nominee_policy_fk");
            });

            modelBuilder.Entity<PolicyNomineeCommunication>(entity =>
            {
                entity.ToTable("policy_nominee_communication");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.EmailMessageId).HasColumnName("email_message_id");

                entity.Property(e => e.PlanSettingId).HasColumnName("plan_Setting_id");

                entity.Property(e => e.SmsMessageId).HasColumnName("sms_message_id");

                entity.HasOne(d => d.PlanSetting)
                    .WithMany(p => p.PolicyNomineeCommunication)
                    .HasForeignKey(d => d.PlanSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_setting_id_fkey");
            });

            modelBuilder.Entity<PolicyNomineeMessage>(entity =>
            {
                entity.ToTable("policy_nominee_message");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.MessageBody)
                    .HasColumnName("message_body")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageName)
                    .HasColumnName("message_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.MessageTitle)
                    .HasColumnName("message_title")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<PolicyPaymentProjection>(entity =>
            {
                entity.ToTable("policy_payment_projection");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.PremiumPlan)
                    .HasColumnName("premium_plan")
                    .HasColumnType("json");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyPaymentProjection)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("projection_policy_fk");
            });

            modelBuilder.Entity<PolicyPaymentReceipt>(entity =>
            {
                entity.ToTable("policy_payment_receipt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Error)
                    .HasColumnName("error")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyPaymentStatusId).HasColumnName("policy_payment_status_id");

                entity.Property(e => e.ReceiptNo)
                    .HasColumnName("receipt_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.PolicyPaymentStatus)
                    .WithMany(p => p.PolicyPaymentReceipt)
                    .HasForeignKey(d => d.PolicyPaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("policy_payment_status_id_fk");
            });

            modelBuilder.Entity<PolicyPaymentStatus>(entity =>
            {
                entity.ToTable("policy_payment_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ActualBillingDate).HasColumnName("actual_billing_date");

                entity.Property(e => e.IsReminderSent).HasColumnName("is_reminder_sent");

                entity.Property(e => e.OutstandingAmount)
                    .HasColumnName("outstanding_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.OutstandingPaymentPolicyStatusId).HasColumnName("outstanding_payment_policy_status_id");

                entity.Property(e => e.PaymentBatchLogId).HasColumnName("payment_batch_log_id");

                entity.Property(e => e.PaymentOptionId).HasColumnName("payment_option_id");

                entity.Property(e => e.PaymentProviderId).HasColumnName("payment_provider_id");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.PolicyNo)
                    .HasColumnName("policy_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyPaymentProjectionBillingDate).HasColumnName("policy_payment_projection_billing_date");

                entity.Property(e => e.PolicyPaymentProjectionId).HasColumnName("policy_payment_projection_id");

                entity.Property(e => e.PostResponseDate).HasColumnName("post_response_date");

                entity.Property(e => e.PostResponseError)
                    .HasColumnName("post_response_error")
                    .HasColumnType("character varying");

                entity.Property(e => e.PostResponseStatus).HasColumnName("post_response_status");

                entity.Property(e => e.PreResponseDate).HasColumnName("pre_response_date");

                entity.Property(e => e.PreResponseError)
                    .HasColumnName("pre_response_error")
                    .HasColumnType("character varying");

                entity.Property(e => e.PreResponseStatus).HasColumnName("pre_response_status");

                entity.Property(e => e.Premium)
                    .HasColumnName("premium")
                    .HasColumnType("numeric");

                entity.Property(e => e.RequestAmount)
                    .HasColumnName("request_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.RequestJson)
                    .HasColumnName("request_json")
                    .HasColumnType("json");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TransactionDate).HasColumnName("transaction_date");

                entity.Property(e => e.TryCount).HasColumnName("try_count");

                entity.HasOne(d => d.OutstandingPaymentPolicyStatus)
                    .WithMany(p => p.InverseOutstandingPaymentPolicyStatus)
                    .HasForeignKey(d => d.OutstandingPaymentPolicyStatusId)
                    .HasConstraintName("outstanding_policy_payment_status_id");

                entity.HasOne(d => d.PaymentBatchLog)
                    .WithMany(p => p.PolicyPaymentStatus)
                    .HasForeignKey(d => d.PaymentBatchLogId)
                    .HasConstraintName("payment_batch_log_id_fk");

                entity.HasOne(d => d.PaymentOption)
                    .WithMany(p => p.PolicyPaymentStatus)
                    .HasForeignKey(d => d.PaymentOptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("payment_option_id");

                entity.HasOne(d => d.PaymentProvider)
                    .WithMany(p => p.PolicyPaymentStatus)
                    .HasForeignKey(d => d.PaymentProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("payment_provider_id");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyPaymentStatus)
                    .HasForeignKey(d => d.PolicyId)
                    .HasConstraintName("policy_id_fk");

                entity.HasOne(d => d.PolicyPaymentProjection)
                    .WithMany(p => p.PolicyPaymentStatus)
                    .HasForeignKey(d => d.PolicyPaymentProjectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("policy_payment_projection_id_fk");
            });

            modelBuilder.Entity<PolicyPaymentToken>(entity =>
            {
                entity.ToTable("policy_payment_token");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreateDate).HasColumnName("create_date");

                entity.Property(e => e.PaymentBankApprovalCode)
                    .HasColumnName("payment_bank_approval_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentOptionId).HasColumnName("payment_option_id");

                entity.Property(e => e.PaymentProviderId).HasColumnName("payment_provider_id");

                entity.Property(e => e.PaymentTransactionRef)
                    .HasColumnName("payment_transaction_ref")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TokenId)
                    .IsRequired()
                    .HasColumnName("token_id")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.PaymentOption)
                    .WithMany(p => p.PolicyPaymentToken)
                    .HasForeignKey(d => d.PaymentOptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("payment_option_id_fk");

                entity.HasOne(d => d.PaymentProvider)
                    .WithMany(p => p.PolicyPaymentToken)
                    .HasForeignKey(d => d.PaymentProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("payment_provider_id_fk");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyPaymentToken)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("policy_id_fk");
            });

            modelBuilder.Entity<PolicyPremiumBreakdown>(entity =>
            {
                entity.ToTable("policy_premium_breakdown");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ChargeAmount)
                    .HasColumnName("charge_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.ChargeCode)
                    .IsRequired()
                    .HasColumnName("charge_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.ChargeName)
                    .IsRequired()
                    .HasColumnName("charge_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.PayFactorValue)
                    .HasColumnName("pay_factor_value")
                    .HasColumnType("numeric");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyPremiumBreakdown)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("policy_premium_breakdown_policy_fk");
            });

            modelBuilder.Entity<PolicyRequestResponse>(entity =>
            {
                entity.ToTable("policy_request_response");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BaseCurrencyCode)
                    .HasColumnName("base_currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.Channel)
                    .HasColumnName("channel")
                    .HasColumnType("character varying");

                entity.Property(e => e.ConvertCurrencyCode)
                    .HasColumnName("convert_currency_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.CurrencyRate)
                    .HasColumnName("currency_rate")
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.InputRequest)
                    .IsRequired()
                    .HasColumnName("input_request")
                    .HasColumnType("json");

                entity.Property(e => e.IsMasterPolicy)
                    .HasColumnName("is_master_policy")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OutputResponse)
                    .HasColumnName("output_response")
                    .HasColumnType("json");

                entity.Property(e => e.PlanCode)
                    .HasColumnName("plan_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.PremiumProjection)
                    .HasColumnName("premium_projection")
                    .HasColumnType("json");

                entity.Property(e => e.PromoMapId).HasColumnName("promo_map_id");

                entity.Property(e => e.QuotationNumber)
                    .HasColumnName("quotation_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.QuoteStatus).HasColumnName("quote_status");

                entity.Property(e => e.Validity).HasColumnName("validity");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyRequestResponse)
                    .HasForeignKey(d => d.PolicyId)
                    .HasConstraintName("policy_id_fkey");
            });

            modelBuilder.Entity<PolicyTrustee>(entity =>
            {
                entity.ToTable("policy_trustee");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("address_2")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.ExpiryTime).HasColumnName("expiry_time");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasMaxLength(50);

                entity.Property(e => e.IdentityType).HasColumnName("identity_type");

                entity.Property(e => e.IdentityValue)
                    .IsRequired()
                    .HasColumnName("identity_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("mobile")
                    .HasMaxLength(20);

                entity.Property(e => e.MobileCountryCode)
                    .HasColumnName("mobile_country_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasColumnName("nationality")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasColumnName("postcode")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Relationship).HasColumnName("relationship");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyTrustee)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("trustee_policy_id");
            });

            modelBuilder.Entity<PolicyUw>(entity =>
            {
                entity.ToTable("policy_uw");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.InputRequestUw)
                    .HasColumnName("input_request_uw")
                    .HasColumnType("json");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.OutputResponseUw)
                    .HasColumnName("output_response_uw")
                    .HasColumnType("json");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.UwAnswer)
                    .HasColumnName("uw_answer")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyUw)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("policy_id_fkey");
            });

            modelBuilder.Entity<PolicyWitness>(entity =>
            {
                entity.ToTable("policy_witness");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.ExpiryTime).HasColumnName("expiry_time");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasMaxLength(50);

                entity.Property(e => e.IdentityType).HasColumnName("identity_type");

                entity.Property(e => e.IdentityValue)
                    .IsRequired()
                    .HasColumnName("identity_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("mobile")
                    .HasMaxLength(20);

                entity.Property(e => e.MobileCountryCode)
                    .HasColumnName("mobile_country_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.Relationship).HasColumnName("relationship");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyWitness)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("witness_policy_id");
            });

            modelBuilder.Entity<PromoCodeSetting>(entity =>
            {
                entity.ToTable("promo_code_setting");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PromoCode)
                    .IsRequired()
                    .HasColumnName("promo_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.PromoType).HasColumnName("promo_type");

                entity.Property(e => e.PromoValue)
                    .HasColumnName("promo_value")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ReinsuranceCommission>(entity =>
            {
                entity.ToTable("reinsurance_commission");

                entity.HasIndex(e => e.Name)
                    .HasName("reinsurance_commission_unique_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CommissionStructureTypeId).HasColumnName("commission_structure_type_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(60);

                entity.Property(e => e.QuotaShare)
                    .HasColumnName("quota_share")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.RetentionAmount)
                    .HasColumnName("retention_amount")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Underwriteruuid).HasColumnName("underwriteruuid");

                entity.HasOne(d => d.CommissionStructureType)
                    .WithMany(p => p.ReinsuranceCommission)
                    .HasForeignKey(d => d.CommissionStructureTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reinsurance_commission_commission_structure_type_id_fkey");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ReinsuranceCommissionCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reinsurance_commission_created_by_fkey");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ReinsuranceCommissionModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("reinsurance_commission_modified_by_fkey");

                entity.HasOne(d => d.Underwriteruu)
                    .WithMany(p => p.ReinsuranceCommission)
                    .HasForeignKey(d => d.Underwriteruuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reinsurance_commission_underwriteruuid_fkey");
            });

            modelBuilder.Entity<ReinsuranceCommissionFormula>(entity =>
            {
                entity.ToTable("reinsurance_commission_formula");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CalculationFormula)
                    .HasColumnName("calculation_formula")
                    .HasMaxLength(1024);

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.ReinsuranceCommissionId).HasColumnName("reinsurance_commission_id");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ReinsuranceCommissionFormulaCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reinsurance_commission_formula_created_by_fkey");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ReinsuranceCommissionFormulaModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("reinsurance_commission_formula_modified_by_fkey");

                entity.HasOne(d => d.ReinsuranceCommission)
                    .WithMany(p => p.ReinsuranceCommissionFormula)
                    .HasForeignKey(d => d.ReinsuranceCommissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reinsurance_commission_formula_reinsurance_commission_id_fkey");
            });

            modelBuilder.Entity<ReinsuranceCommissionJournal>(entity =>
            {
                entity.ToTable("reinsurance_commission_journal");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CalcRemarks)
                    .HasColumnName("calc_remarks")
                    .HasMaxLength(512);

                entity.Property(e => e.CommissionAmount)
                    .HasColumnName("commission_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.DateCode)
                    .IsRequired()
                    .HasColumnName("date_code")
                    .HasMaxLength(4);

                entity.Property(e => e.GrossPolicyCount).HasColumnName("gross_policy_count");

                entity.Property(e => e.GrossPremiumAmount)
                    .HasColumnName("gross_premium_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.UnderwriterId).HasColumnName("underwriter_id");
            });

            modelBuilder.Entity<ReinsuranceCommissionStructure>(entity =>
            {
                entity.ToTable("reinsurance_commission_structure");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AllocationTypeId).HasColumnName("allocation_type_id");

                entity.Property(e => e.Commission)
                    .HasColumnName("commission")
                    .HasColumnType("numeric(20,4)");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.MaxValue)
                    .HasColumnName("max_value")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.MinValue)
                    .HasColumnName("min_value")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.ReinsuranceCommissionId).HasColumnName("reinsurance_commission_id");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.AllocationType)
                    .WithMany(p => p.ReinsuranceCommissionStructure)
                    .HasForeignKey(d => d.AllocationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reinsurance_commission_structure_allocation_type_id_fkey");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ReinsuranceCommissionStructureCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reinsurance_commission_structure_created_by_fkey");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ReinsuranceCommissionStructureModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("reinsurance_commission_structure_modified_by_fkey");

                entity.HasOne(d => d.ReinsuranceCommission)
                    .WithMany(p => p.ReinsuranceCommissionStructure)
                    .HasForeignKey(d => d.ReinsuranceCommissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reinsurance_commission_structure_reinsurance_commission_id_fkey");
            });

            modelBuilder.Entity<ReinsurerBca>(entity =>
            {
                entity.ToTable("reinsurer_bca");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AgreementName)
                    .IsRequired()
                    .HasColumnName("agreement_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.AgreementNo)
                    .IsRequired()
                    .HasColumnName("agreement_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.InitialEndDate).HasColumnName("initial_end_date");

                entity.Property(e => e.InitialTermYear).HasColumnName("initial_term_year");

                entity.Property(e => e.InsurerId).HasColumnName("insurer_id");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.ReinsurerId).HasColumnName("reinsurer_id");

                entity.Property(e => e.RenewalNoticeTerm)
                    .IsRequired()
                    .HasColumnName("renewal_notice_term")
                    .HasColumnType("character varying");

                entity.Property(e => e.RenewalNoticeValue).HasColumnName("renewal_notice_value");

                entity.Property(e => e.RenewalTermYear).HasColumnName("renewal_term_year");

                entity.Property(e => e.RetroId).HasColumnName("retro_id");

                entity.Property(e => e.SignedDate).HasColumnName("signed_date");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Insurer)
                    .WithMany(p => p.ReinsurerBca)
                    .HasForeignKey(d => d.InsurerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("insurer_id_fkey");

                entity.HasOne(d => d.Reinsurer)
                    .WithMany(p => p.ReinsurerBca)
                    .HasForeignKey(d => d.ReinsurerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reinsurer_id_fkey");
            });

            modelBuilder.Entity<ReinsurerPremiumLayers>(entity =>
            {
                entity.ToTable("reinsurer_premium_layers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LayerFormula)
                    .HasColumnName("layer_formula")
                    .HasColumnType("character varying");

                entity.Property(e => e.LayerName)
                    .HasColumnName("layer_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.ReinsurerId).HasColumnName("reinsurer_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Reinsurer)
                    .WithMany(p => p.ReinsurerPremiumLayers)
                    .HasForeignKey(d => d.ReinsurerId)
                    .HasConstraintName("reinsurer_id_fkey");
            });

            modelBuilder.Entity<ReinsurerQstComm>(entity =>
            {
                entity.ToTable("reinsurer_qst_comm");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ChannelCode)
                    .IsRequired()
                    .HasColumnName("channel_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.QstId).HasColumnName("qst_id");

                entity.Property(e => e.RiCommAmount)
                    .HasColumnName("ri_comm_amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.RiCommOn).HasColumnName("ri_comm_on");

                entity.Property(e => e.RiCommPercentage)
                    .HasColumnName("ri_comm_percentage")
                    .HasColumnType("numeric");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.ReinsurerQstComm)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_id_fkey");

                entity.HasOne(d => d.Qst)
                    .WithMany(p => p.ReinsurerQstComm)
                    .HasForeignKey(d => d.QstId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("qst_id_fkey");
            });

            modelBuilder.Entity<ReinsurerQstFormula>(entity =>
            {
                entity.ToTable("reinsurer_qst_formula");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CalculationFormula)
                    .HasColumnName("calculation_formula")
                    .HasColumnType("character varying");

                entity.Property(e => e.CalculationType).HasColumnName("calculation_type");

                entity.Property(e => e.ChargeType)
                    .HasColumnName("charge_type")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.DisplayCalc).HasColumnName("display_calc");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.JsonColumn)
                    .HasColumnName("json_column")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.PlanVariableId).HasColumnName("plan_variable_id");

                entity.Property(e => e.ReinsurerQstFormulaMasterId).HasColumnName("reinsurer_qst_formula_master_id");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.ValueSign)
                    .HasColumnName("value_sign")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.PlanVariable)
                    .WithMany(p => p.ReinsurerQstFormula)
                    .HasForeignKey(d => d.PlanVariableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plan_variable_id_fk");

                entity.HasOne(d => d.ReinsurerQstFormulaMaster)
                    .WithMany(p => p.ReinsurerQstFormula)
                    .HasForeignKey(d => d.ReinsurerQstFormulaMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reinsurer_qst_formula_master_id_fkey");
            });

            modelBuilder.Entity<ReinsurerQstFormulaMaster>(entity =>
            {
                entity.ToTable("reinsurer_qst_formula_master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.EndDateReference).HasColumnName("end_date_reference");

                entity.Property(e => e.EndDateValueType)
                    .HasColumnName("end_date_value_type")
                    .HasMaxLength(20);

                entity.Property(e => e.FormulaMasterCode)
                    .IsRequired()
                    .HasColumnName("formula_master_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.FormulaMasterName)
                    .IsRequired()
                    .HasColumnName("formula_master_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.QstId).HasColumnName("qst_id");

                entity.Property(e => e.SequenceNo).HasColumnName("sequence_no");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.EndDateReferenceNavigation)
                    .WithMany(p => p.ReinsurerQstFormulaMaster)
                    .HasForeignKey(d => d.EndDateReference)
                    .HasConstraintName("formula_master_custom_input_fk");
            });

            modelBuilder.Entity<ReinsurerQstRpgMap>(entity =>
            {
                entity.ToTable("reinsurer_qst_rpg_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.QstId).HasColumnName("qst_id");

                entity.Property(e => e.RpgId).HasColumnName("rpg_id");

                entity.HasOne(d => d.Qst)
                    .WithMany(p => p.ReinsurerQstRpgMap)
                    .HasForeignKey(d => d.QstId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rqst_id_fkey");

                entity.HasOne(d => d.Rpg)
                    .WithMany(p => p.ReinsurerQstRpgMap)
                    .HasForeignKey(d => d.RpgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rrpg_id_fkey");
            });

            modelBuilder.Entity<ReinsurerQstreaties>(entity =>
            {
                entity.ToTable("reinsurer_qstreaties");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BcaId).HasColumnName("bca_id");

                entity.Property(e => e.CompulsoryCession)
                    .HasColumnName("compulsory_cession")
                    .HasColumnType("numeric");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.InsurerLimit)
                    .HasColumnName("insurer_limit")
                    .HasColumnType("numeric");

                entity.Property(e => e.InsurerShare)
                    .HasColumnName("insurer_share")
                    .HasColumnType("numeric");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Plans)
                    .HasColumnName("plans")
                    .HasColumnType("json");

                entity.Property(e => e.Premiumlayers)
                    .HasColumnName("premiumlayers")
                    .HasColumnType("json");

                entity.Property(e => e.QstCode)
                    .IsRequired()
                    .HasColumnName("qst_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.QstName)
                    .IsRequired()
                    .HasColumnName("qst_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReinsurerShare)
                    .HasColumnName("reinsurer_share")
                    .HasColumnType("numeric");

                entity.Property(e => e.RetroShare)
                    .HasColumnName("retro_share")
                    .HasColumnType("numeric");

                entity.Property(e => e.Riskpremiums)
                    .HasColumnName("riskpremiums")
                    .HasColumnType("json");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Bca)
                    .WithMany(p => p.ReinsurerQstreaties)
                    .HasForeignKey(d => d.BcaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bca_id_fkey");
            });

            modelBuilder.Entity<ReinsurerQstreatiesCriteria>(entity =>
            {
                entity.ToTable("reinsurer_qstreaties_criteria");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasColumnName("condition")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.FixedValue)
                    .HasColumnName("fixed_value")
                    .HasColumnType("character varying");

                entity.Property(e => e.Input)
                    .IsRequired()
                    .HasColumnName("input")
                    .HasColumnType("character varying");

                entity.Property(e => e.Jsoncolumn)
                    .IsRequired()
                    .HasColumnName("jsoncolumn")
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.QstId).HasColumnName("qst_id");

                entity.HasOne(d => d.Qst)
                    .WithMany(p => p.ReinsurerQstreatiesCriteria)
                    .HasForeignKey(d => d.QstId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("qst_id_fk");
            });

            modelBuilder.Entity<ReinsurerRiskPremiums>(entity =>
            {
                entity.ToTable("reinsurer_risk_premiums");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.DocName)
                    .HasColumnName("doc_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.ReinsurerId).HasColumnName("reinsurer_id");

                entity.Property(e => e.RrpName)
                    .HasColumnName("rrp_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TableColumns)
                    .HasColumnName("table_columns")
                    .HasColumnType("character varying");

                entity.Property(e => e.TableJson)
                    .IsRequired()
                    .HasColumnName("table_json")
                    .HasColumnType("json");
            });

            modelBuilder.Entity<ReinsurerRiskPremiumsGroups>(entity =>
            {
                entity.ToTable("reinsurer_risk_premiums_groups");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.QstId).HasColumnName("qst_id");

                entity.Property(e => e.RrpgCode)
                    .HasColumnName("rrpg_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.RrpgName)
                    .HasColumnName("rrpg_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Qst)
                    .WithMany(p => p.ReinsurerRiskPremiumsGroups)
                    .HasForeignKey(d => d.QstId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("qst_id_fkey");
            });

            modelBuilder.Entity<ReinsurerRiskPremiumsMap>(entity =>
            {
                entity.ToTable("reinsurer_risk_premiums_map");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.ReinsurerRiskPremiumGroupId).HasColumnName("reinsurer_risk_premium_group_id");

                entity.Property(e => e.ReinsurerRiskPremiumId).HasColumnName("reinsurer_risk_premium_id");

                entity.HasOne(d => d.ReinsurerRiskPremiumGroup)
                    .WithMany(p => p.ReinsurerRiskPremiumsMap)
                    .HasForeignKey(d => d.ReinsurerRiskPremiumGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rrpg_id");

                entity.HasOne(d => d.ReinsurerRiskPremium)
                    .WithMany(p => p.ReinsurerRiskPremiumsMap)
                    .HasForeignKey(d => d.ReinsurerRiskPremiumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rrp_id");
            });

            modelBuilder.Entity<Reinsurers>(entity =>
            {
                entity.ToTable("reinsurers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.ReinsurerCode)
                    .IsRequired()
                    .HasColumnName("reinsurer_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReinsurerName)
                    .IsRequired()
                    .HasColumnName("reinsurer_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReinsurerType)
                    .IsRequired()
                    .HasColumnName("reinsurer_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<SapJournalEntry>(entity =>
            {
                entity.ToTable("sap_journal_entry");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AutoVat).HasColumnName("auto_vat");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.IsSent).HasColumnName("is_sent");

                entity.Property(e => e.JournalType).HasColumnName("journal_type");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasColumnType("character varying");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("project_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.Reference)
                    .HasColumnName("reference")
                    .HasColumnType("character varying");

                entity.Property(e => e.Reference2)
                    .HasColumnName("reference2")
                    .HasColumnType("character varying");

                entity.Property(e => e.Reference3)
                    .HasColumnName("reference3")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReferenceDate).HasColumnName("reference_date");

                entity.Property(e => e.SentDate).HasColumnName("sent_date");

                entity.Property(e => e.Series).HasColumnName("series");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TransactionCode)
                    .HasColumnName("transaction_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.UserFields)
                    .HasColumnName("user_fields")
                    .HasColumnType("json");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.SapJournalEntry)
                    .HasForeignKey(d => d.ClaimId)
                    .HasConstraintName("claimid_fkey");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.SapJournalEntry)
                    .HasForeignKey(d => d.PolicyId)
                    .HasConstraintName("pollicyid_fkey");
            });

            modelBuilder.Entity<SapJournalEntryLine>(entity =>
            {
                entity.ToTable("sap_journal_entry_line");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("account_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.AdditionalReference)
                    .HasColumnName("additional_reference")
                    .HasColumnType("character varying");

                entity.Property(e => e.BaseSum)
                    .HasColumnName("base_sum")
                    .HasColumnType("money");

                entity.Property(e => e.CostingCode)
                    .HasColumnName("costing_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CostingCode2)
                    .HasColumnName("costing_code2")
                    .HasColumnType("character varying");

                entity.Property(e => e.CostingCode3)
                    .HasColumnName("costing_code3")
                    .HasColumnType("character varying");

                entity.Property(e => e.CostingCode4)
                    .HasColumnName("costing_code4")
                    .HasColumnType("character varying");

                entity.Property(e => e.CostingCode5)
                    .HasColumnName("costing_code5")
                    .HasColumnType("character varying");

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasColumnType("money");

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasColumnType("money");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.FcCredit)
                    .HasColumnName("fc_credit")
                    .HasColumnType("money");

                entity.Property(e => e.FcCurrency)
                    .HasColumnName("fc_currency")
                    .HasColumnType("character varying");

                entity.Property(e => e.FcDebit)
                    .HasColumnName("fc_debit")
                    .HasColumnType("money");

                entity.Property(e => e.LineMemo)
                    .HasColumnName("line_memo")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("project_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.Reference1)
                    .HasColumnName("reference1")
                    .HasColumnType("character varying");

                entity.Property(e => e.Reference2)
                    .HasColumnName("reference2")
                    .HasColumnType("character varying");

                entity.Property(e => e.SapJournalEntryId).HasColumnName("sap_journal_entry_id");

                entity.Property(e => e.ShortName)
                    .HasColumnName("short_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.TaxGroup)
                    .HasColumnName("tax_group")
                    .HasColumnType("character varying");

                entity.Property(e => e.UserFields)
                    .HasColumnName("user_fields")
                    .HasColumnType("json");

                entity.HasOne(d => d.SapJournalEntry)
                    .WithMany(p => p.SapJournalEntryLine)
                    .HasForeignKey(d => d.SapJournalEntryId)
                    .HasConstraintName("sap_journal_entry_fk");
            });

            modelBuilder.Entity<SapJournals>(entity =>
            {
                entity.ToTable("sap_journals");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Accountcode)
                    .IsRequired()
                    .HasColumnName("accountcode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Actiontype)
                    .IsRequired()
                    .HasColumnName("actiontype")
                    .HasColumnType("character varying");

                entity.Property(e => e.Autovat).HasColumnName("autovat");

                entity.Property(e => e.Costingcode)
                    .IsRequired()
                    .HasColumnName("costingcode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Costingcode2)
                    .IsRequired()
                    .HasColumnName("costingcode2")
                    .HasColumnType("character varying");

                entity.Property(e => e.Costingcode3)
                    .IsRequired()
                    .HasColumnName("costingcode3")
                    .HasColumnType("character varying");

                entity.Property(e => e.Costingcode4)
                    .IsRequired()
                    .HasColumnName("costingcode4")
                    .HasColumnType("character varying");

                entity.Property(e => e.Costingcode5)
                    .IsRequired()
                    .HasColumnName("costingcode5")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.Journaltype).HasColumnName("journaltype");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Linememo)
                    .IsRequired()
                    .HasColumnName("linememo")
                    .HasColumnType("character varying");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.Projectcode)
                    .IsRequired()
                    .HasColumnName("projectcode")
                    .HasColumnType("character varying");

                entity.Property(e => e.Shortname)
                    .IsRequired()
                    .HasColumnName("shortname")
                    .HasColumnType("character varying");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Transactioncode)
                    .IsRequired()
                    .HasColumnName("transactioncode")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.SapJournals)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("planid_fkey");
            });

            modelBuilder.Entity<SdnAdvanced>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sdn_advanced");

                entity.Property(e => e.Acronym)
                    .HasColumnName("acronym")
                    .HasMaxLength(255);

                entity.Property(e => e.Aliastype)
                    .HasColumnName("aliastype")
                    .HasMaxLength(255);

                entity.Property(e => e.Aliastypeid)
                    .HasColumnName("aliastypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Approximate)
                    .HasColumnName("approximate")
                    .HasMaxLength(255);

                entity.Property(e => e.Approximate107)
                    .HasColumnName("approximate107")
                    .HasMaxLength(255);

                entity.Property(e => e.Approximate117)
                    .HasColumnName("approximate117")
                    .HasMaxLength(255);

                entity.Property(e => e.Approximate51)
                    .HasColumnName("approximate51")
                    .HasMaxLength(255);

                entity.Property(e => e.Approximate79)
                    .HasColumnName("approximate79")
                    .HasMaxLength(255);

                entity.Property(e => e.Approximate89)
                    .HasColumnName("approximate89")
                    .HasMaxLength(255);

                entity.Property(e => e.Areacode)
                    .HasColumnName("areacode")
                    .HasMaxLength(255);

                entity.Property(e => e.Areacodeid)
                    .HasColumnName("areacodeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Areacodetype)
                    .HasColumnName("areacodetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Areacodetypeid).HasColumnName("areacodetypeid");

                entity.Property(e => e.Calendartype)
                    .HasColumnName("calendartype")
                    .HasMaxLength(255);

                entity.Property(e => e.Calendartypeid).HasColumnName("calendartypeid");

                entity.Property(e => e.Calendartypeid102)
                    .HasColumnName("calendartypeid102")
                    .HasMaxLength(255);

                entity.Property(e => e.Calendartypeid130)
                    .HasColumnName("calendartypeid130")
                    .HasMaxLength(255);

                entity.Property(e => e.Calendartypeid135)
                    .HasColumnName("calendartypeid135")
                    .HasMaxLength(255);

                entity.Property(e => e.Calendartypeid41)
                    .HasColumnName("calendartypeid41")
                    .HasMaxLength(255);

                entity.Property(e => e.Calendartypeid75)
                    .HasColumnName("calendartypeid75")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment101)
                    .HasColumnName("comment101")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment106)
                    .HasColumnName("comment106")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment129)
                    .HasColumnName("comment129")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment139)
                    .HasColumnName("comment139")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment40)
                    .HasColumnName("comment40")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment62)
                    .HasColumnName("comment62")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment74)
                    .HasColumnName("comment74")
                    .HasMaxLength(255);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.Countryid).HasColumnName("countryid");

                entity.Property(e => e.Countryid25).HasColumnName("countryid25");

                entity.Property(e => e.Countryid38)
                    .HasColumnName("countryid38")
                    .HasMaxLength(255);

                entity.Property(e => e.Countryrelevance)
                    .HasColumnName("countryrelevance")
                    .HasMaxLength(255);

                entity.Property(e => e.Countryrelevanceid)
                    .HasColumnName("countryrelevanceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Day).HasColumnName("day");

                entity.Property(e => e.Day113)
                    .HasColumnName("day113")
                    .HasMaxLength(255);

                entity.Property(e => e.Day116)
                    .HasColumnName("day116")
                    .HasMaxLength(255);

                entity.Property(e => e.Day123)
                    .HasColumnName("day123")
                    .HasMaxLength(255);

                entity.Property(e => e.Day126)
                    .HasColumnName("day126")
                    .HasMaxLength(255);

                entity.Property(e => e.Day133)
                    .HasColumnName("day133")
                    .HasMaxLength(255);

                entity.Property(e => e.Day47)
                    .HasColumnName("day47")
                    .HasMaxLength(255);

                entity.Property(e => e.Day50)
                    .HasColumnName("day50")
                    .HasMaxLength(255);

                entity.Property(e => e.Day57)
                    .HasColumnName("day57")
                    .HasMaxLength(255);

                entity.Property(e => e.Day60)
                    .HasColumnName("day60")
                    .HasMaxLength(255);

                entity.Property(e => e.Day85)
                    .HasColumnName("day85")
                    .HasMaxLength(255);

                entity.Property(e => e.Day88)
                    .HasColumnName("day88")
                    .HasMaxLength(255);

                entity.Property(e => e.Day95)
                    .HasColumnName("day95")
                    .HasMaxLength(255);

                entity.Property(e => e.Day98)
                    .HasColumnName("day98")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed)
                    .HasColumnName("dayfixed")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed105)
                    .HasColumnName("dayfixed105")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed110)
                    .HasColumnName("dayfixed110")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed120)
                    .HasColumnName("dayfixed120")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed138)
                    .HasColumnName("dayfixed138")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed44)
                    .HasColumnName("dayfixed44")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed54)
                    .HasColumnName("dayfixed54")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed78)
                    .HasColumnName("dayfixed78")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed82)
                    .HasColumnName("dayfixed82")
                    .HasMaxLength(255);

                entity.Property(e => e.Dayfixed92)
                    .HasColumnName("dayfixed92")
                    .HasMaxLength(255);

                entity.Property(e => e.Decisionmakingbody)
                    .HasColumnName("decisionmakingbody")
                    .HasMaxLength(255);

                entity.Property(e => e.Decisionmakingbodyid).HasColumnName("decisionmakingbodyid");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Detailreference)
                    .HasColumnName("detailreference")
                    .HasMaxLength(255);

                entity.Property(e => e.Detailreferenceid)
                    .HasColumnName("detailreferenceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Detailtype)
                    .HasColumnName("detailtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Detailtypeid)
                    .HasColumnName("detailtypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Docnamestatus)
                    .HasColumnName("docnamestatus")
                    .HasMaxLength(255);

                entity.Property(e => e.Docnamestatusid)
                    .HasColumnName("docnamestatusid")
                    .HasMaxLength(255);

                entity.Property(e => e.Documentednameid)
                    .HasColumnName("documentednameid")
                    .HasMaxLength(255);

                entity.Property(e => e.Entryeventtype)
                    .HasColumnName("entryeventtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Entryeventtypeid)
                    .HasColumnName("entryeventtypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Entrylinktypevalues)
                    .HasColumnName("entrylinktypevalues")
                    .HasMaxLength(255);

                entity.Property(e => e.Exreftypevalues)
                    .HasColumnName("exreftypevalues")
                    .HasMaxLength(255);

                entity.Property(e => e.Falsetext)
                    .HasColumnName("falsetext")
                    .HasMaxLength(255);

                entity.Property(e => e.Featuretype)
                    .HasColumnName("featuretype")
                    .HasMaxLength(255);

                entity.Property(e => e.Featuretypegroup)
                    .HasColumnName("featuretypegroup")
                    .HasMaxLength(255);

                entity.Property(e => e.Featuretypegroupid)
                    .HasColumnName("featuretypegroupid")
                    .HasMaxLength(255);

                entity.Property(e => e.Featuretypeid)
                    .HasColumnName("featuretypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Featureversionid)
                    .HasColumnName("featureversionid")
                    .HasMaxLength(255);

                entity.Property(e => e.Featureversionid61)
                    .HasColumnName("featureversionid61")
                    .HasMaxLength(255);

                entity.Property(e => e.Fixedref)
                    .HasColumnName("fixedref")
                    .HasMaxLength(255);

                entity.Property(e => e.Fixedref65)
                    .HasColumnName("fixedref65")
                    .HasMaxLength(255);

                entity.Property(e => e.Fixedref67)
                    .HasColumnName("fixedref67")
                    .HasMaxLength(255);

                entity.Property(e => e.Fixedref70)
                    .HasColumnName("fixedref70")
                    .HasMaxLength(255);

                entity.Property(e => e.Former)
                    .HasColumnName("former")
                    .HasMaxLength(255);

                entity.Property(e => e.Fromprofileid)
                    .HasColumnName("fromprofileid")
                    .HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Id10)
                    .HasColumnName("id10")
                    .HasMaxLength(255);

                entity.Property(e => e.Id100)
                    .HasColumnName("id100")
                    .HasMaxLength(255);

                entity.Property(e => e.Id11).HasColumnName("id11");

                entity.Property(e => e.Id12)
                    .HasColumnName("id12")
                    .HasMaxLength(255);

                entity.Property(e => e.Id127)
                    .HasColumnName("id127")
                    .HasMaxLength(255);

                entity.Property(e => e.Id128)
                    .HasColumnName("id128")
                    .HasMaxLength(255);

                entity.Property(e => e.Id13).HasColumnName("id13");

                entity.Property(e => e.Id134)
                    .HasColumnName("id134")
                    .HasMaxLength(255);

                entity.Property(e => e.Id14)
                    .HasColumnName("id14")
                    .HasMaxLength(255);

                entity.Property(e => e.Id15)
                    .HasColumnName("id15")
                    .HasMaxLength(255);

                entity.Property(e => e.Id16).HasColumnName("id16");

                entity.Property(e => e.Id17)
                    .HasColumnName("id17")
                    .HasMaxLength(255);

                entity.Property(e => e.Id18).HasColumnName("id18");

                entity.Property(e => e.Id19)
                    .HasColumnName("id19")
                    .HasMaxLength(255);

                entity.Property(e => e.Id2).HasColumnName("id2");

                entity.Property(e => e.Id20)
                    .HasColumnName("id20")
                    .HasMaxLength(255);

                entity.Property(e => e.Id21).HasColumnName("id21");

                entity.Property(e => e.Id22).HasColumnName("id22");

                entity.Property(e => e.Id23)
                    .HasColumnName("id23")
                    .HasMaxLength(255);

                entity.Property(e => e.Id24).HasColumnName("id24");

                entity.Property(e => e.Id26)
                    .HasColumnName("id26")
                    .HasMaxLength(255);

                entity.Property(e => e.Id27)
                    .HasColumnName("id27")
                    .HasMaxLength(255);

                entity.Property(e => e.Id28)
                    .HasColumnName("id28")
                    .HasMaxLength(255);

                entity.Property(e => e.Id29)
                    .HasColumnName("id29")
                    .HasMaxLength(255);

                entity.Property(e => e.Id3).HasColumnName("id3");

                entity.Property(e => e.Id30)
                    .HasColumnName("id30")
                    .HasMaxLength(255);

                entity.Property(e => e.Id31)
                    .HasColumnName("id31")
                    .HasMaxLength(255);

                entity.Property(e => e.Id32)
                    .HasColumnName("id32")
                    .HasMaxLength(255);

                entity.Property(e => e.Id33)
                    .HasColumnName("id33")
                    .HasMaxLength(255);

                entity.Property(e => e.Id34).HasColumnName("id34");

                entity.Property(e => e.Id35).HasColumnName("id35");

                entity.Property(e => e.Id36)
                    .HasColumnName("id36")
                    .HasMaxLength(255);

                entity.Property(e => e.Id37)
                    .HasColumnName("id37")
                    .HasMaxLength(255);

                entity.Property(e => e.Id39)
                    .HasColumnName("id39")
                    .HasMaxLength(255);

                entity.Property(e => e.Id4).HasColumnName("id4");

                entity.Property(e => e.Id5)
                    .HasColumnName("id5")
                    .HasMaxLength(255);

                entity.Property(e => e.Id6).HasColumnName("id6");

                entity.Property(e => e.Id63)
                    .HasColumnName("id63")
                    .HasMaxLength(255);

                entity.Property(e => e.Id64)
                    .HasColumnName("id64")
                    .HasMaxLength(255);

                entity.Property(e => e.Id69)
                    .HasColumnName("id69")
                    .HasMaxLength(255);

                entity.Property(e => e.Id7).HasColumnName("id7");

                entity.Property(e => e.Id71)
                    .HasColumnName("id71")
                    .HasMaxLength(255);

                entity.Property(e => e.Id72)
                    .HasColumnName("id72")
                    .HasMaxLength(255);

                entity.Property(e => e.Id73)
                    .HasColumnName("id73")
                    .HasMaxLength(255);

                entity.Property(e => e.Id8)
                    .HasColumnName("id8")
                    .HasMaxLength(255);

                entity.Property(e => e.Id9)
                    .HasColumnName("id9")
                    .HasMaxLength(255);

                entity.Property(e => e.Identityfeaturelinktype)
                    .HasColumnName("identityfeaturelinktype")
                    .HasMaxLength(255);

                entity.Property(e => e.Identityfeaturelinktypeid)
                    .HasColumnName("identityfeaturelinktypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Identityid)
                    .HasColumnName("identityid")
                    .HasMaxLength(255);

                entity.Property(e => e.Identityid99)
                    .HasColumnName("identityid99")
                    .HasMaxLength(255);

                entity.Property(e => e.Idregdocdatetype)
                    .HasColumnName("idregdocdatetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Idregdocdatetypeid)
                    .HasColumnName("idregdocdatetypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Idregdoctype)
                    .HasColumnName("idregdoctype")
                    .HasMaxLength(255);

                entity.Property(e => e.Idregdoctypeid)
                    .HasColumnName("idregdoctypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Idregdocumentid)
                    .HasColumnName("idregdocumentid")
                    .HasMaxLength(255);

                entity.Property(e => e.Idregistrationno)
                    .HasColumnName("idregistrationno")
                    .HasMaxLength(255);

                entity.Property(e => e.Iso2)
                    .HasColumnName("iso2")
                    .HasMaxLength(255);

                entity.Property(e => e.Issuedbycountryid)
                    .HasColumnName("issuedbycountryid")
                    .HasMaxLength(255);

                entity.Property(e => e.Issuedinlocationid)
                    .HasColumnName("issuedinlocationid")
                    .HasMaxLength(255);

                entity.Property(e => e.Issuingauthority)
                    .HasColumnName("issuingauthority")
                    .HasMaxLength(255);

                entity.Property(e => e.Legalbasis)
                    .HasColumnName("legalbasis")
                    .HasMaxLength(255);

                entity.Property(e => e.Legalbasisid)
                    .HasColumnName("legalbasisid")
                    .HasMaxLength(255);

                entity.Property(e => e.Legalbasisshortref)
                    .HasColumnName("legalbasisshortref")
                    .HasMaxLength(255);

                entity.Property(e => e.Legalbasistype)
                    .HasColumnName("legalbasistype")
                    .HasMaxLength(255);

                entity.Property(e => e.Legalbasistypeid)
                    .HasColumnName("legalbasistypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.List)
                    .HasColumnName("list")
                    .HasMaxLength(255);

                entity.Property(e => e.Listid)
                    .HasColumnName("listid")
                    .HasMaxLength(255);

                entity.Property(e => e.Locationid)
                    .HasColumnName("locationid")
                    .HasMaxLength(255);

                entity.Property(e => e.Locparttype)
                    .HasColumnName("locparttype")
                    .HasMaxLength(255);

                entity.Property(e => e.Locparttypeid)
                    .HasColumnName("locparttypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Locpartvaluestatus)
                    .HasColumnName("locpartvaluestatus")
                    .HasMaxLength(255);

                entity.Property(e => e.Locpartvaluestatusid)
                    .HasColumnName("locpartvaluestatusid")
                    .HasMaxLength(255);

                entity.Property(e => e.Locpartvaluetype)
                    .HasColumnName("locpartvaluetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Locpartvaluetypeid)
                    .HasColumnName("locpartvaluetypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Lowquality)
                    .HasColumnName("lowquality")
                    .HasMaxLength(255);

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Month112)
                    .HasColumnName("month112")
                    .HasMaxLength(255);

                entity.Property(e => e.Month115)
                    .HasColumnName("month115")
                    .HasMaxLength(255);

                entity.Property(e => e.Month122)
                    .HasColumnName("month122")
                    .HasMaxLength(255);

                entity.Property(e => e.Month125)
                    .HasColumnName("month125")
                    .HasMaxLength(255);

                entity.Property(e => e.Month132)
                    .HasColumnName("month132")
                    .HasMaxLength(255);

                entity.Property(e => e.Month46)
                    .HasColumnName("month46")
                    .HasMaxLength(255);

                entity.Property(e => e.Month49)
                    .HasColumnName("month49")
                    .HasMaxLength(255);

                entity.Property(e => e.Month56)
                    .HasColumnName("month56")
                    .HasMaxLength(255);

                entity.Property(e => e.Month59)
                    .HasColumnName("month59")
                    .HasMaxLength(255);

                entity.Property(e => e.Month84)
                    .HasColumnName("month84")
                    .HasMaxLength(255);

                entity.Property(e => e.Month87)
                    .HasColumnName("month87")
                    .HasMaxLength(255);

                entity.Property(e => e.Month94)
                    .HasColumnName("month94")
                    .HasMaxLength(255);

                entity.Property(e => e.Month97)
                    .HasColumnName("month97")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed)
                    .HasColumnName("monthfixed")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed104)
                    .HasColumnName("monthfixed104")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed109)
                    .HasColumnName("monthfixed109")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed119)
                    .HasColumnName("monthfixed119")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed137)
                    .HasColumnName("monthfixed137")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed43)
                    .HasColumnName("monthfixed43")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed53)
                    .HasColumnName("monthfixed53")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed77)
                    .HasColumnName("monthfixed77")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed81)
                    .HasColumnName("monthfixed81")
                    .HasMaxLength(255);

                entity.Property(e => e.Monthfixed91)
                    .HasColumnName("monthfixed91")
                    .HasMaxLength(255);

                entity.Property(e => e.Namepartgroupid)
                    .HasColumnName("namepartgroupid")
                    .HasMaxLength(255);

                entity.Property(e => e.Nameparttype)
                    .HasColumnName("nameparttype")
                    .HasMaxLength(255);

                entity.Property(e => e.Nameparttypeid)
                    .HasColumnName("nameparttypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Namepartvalue)
                    .HasColumnName("namepartvalue")
                    .HasMaxLength(255);

                entity.Property(e => e.Notional).HasColumnName("notional");

                entity.Property(e => e.Organisation)
                    .HasColumnName("organisation")
                    .HasMaxLength(255);

                entity.Property(e => e.Organisationid).HasColumnName("organisationid");

                entity.Property(e => e.Partysubtype)
                    .HasColumnName("partysubtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Partysubtypeid)
                    .HasColumnName("partysubtypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Partytype)
                    .HasColumnName("partytype")
                    .HasMaxLength(255);

                entity.Property(e => e.Partytypeid)
                    .HasColumnName("partytypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Primary66)
                    .HasColumnName("primary66")
                    .HasMaxLength(255);

                entity.Property(e => e.Primary68)
                    .HasColumnName("primary68")
                    .HasMaxLength(255);

                entity.Property(e => e.Primarytext)
                    .HasColumnName("primarytext")
                    .HasMaxLength(255);

                entity.Property(e => e.Profileid)
                    .HasColumnName("profileid")
                    .HasMaxLength(255);

                entity.Property(e => e.Relationquality)
                    .HasColumnName("relationquality")
                    .HasMaxLength(255);

                entity.Property(e => e.Relationqualityid)
                    .HasColumnName("relationqualityid")
                    .HasMaxLength(255);

                entity.Property(e => e.Relationtype)
                    .HasColumnName("relationtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Relationtypeid)
                    .HasColumnName("relationtypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Reliability)
                    .HasColumnName("reliability")
                    .HasMaxLength(255);

                entity.Property(e => e.Reliabilityid)
                    .HasColumnName("reliabilityid")
                    .HasMaxLength(255);

                entity.Property(e => e.Sanctionsentryid)
                    .HasColumnName("sanctionsentryid")
                    .HasMaxLength(255);

                entity.Property(e => e.Sanctionsentrylinks)
                    .HasColumnName("sanctionsentrylinks")
                    .HasMaxLength(255);

                entity.Property(e => e.Sanctionsprogram)
                    .HasColumnName("sanctionsprogram")
                    .HasMaxLength(255);

                entity.Property(e => e.Sanctionsprogramid)
                    .HasColumnName("sanctionsprogramid")
                    .HasMaxLength(255);

                entity.Property(e => e.Sanctionstype)
                    .HasColumnName("sanctionstype")
                    .HasMaxLength(255);

                entity.Property(e => e.Sanctionstypeid)
                    .HasColumnName("sanctionstypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Script)
                    .HasColumnName("script")
                    .HasMaxLength(255);

                entity.Property(e => e.Scriptcode)
                    .HasColumnName("scriptcode")
                    .HasMaxLength(255);

                entity.Property(e => e.Scriptid)
                    .HasColumnName("scriptid")
                    .HasMaxLength(255);

                entity.Property(e => e.Scriptstatus)
                    .HasColumnName("scriptstatus")
                    .HasMaxLength(255);

                entity.Property(e => e.Scriptstatusid)
                    .HasColumnName("scriptstatusid")
                    .HasMaxLength(255);

                entity.Property(e => e.Subsidiarybody)
                    .HasColumnName("subsidiarybody")
                    .HasMaxLength(255);

                entity.Property(e => e.Subsidiarybodyid)
                    .HasColumnName("subsidiarybodyid")
                    .HasMaxLength(255);

                entity.Property(e => e.Supinfotypevalues)
                    .HasColumnName("supinfotypevalues")
                    .HasMaxLength(255);

                entity.Property(e => e.Symmetrical)
                    .HasColumnName("symmetrical")
                    .HasMaxLength(255);

                entity.Property(e => e.Targettypevalues)
                    .HasColumnName("targettypevalues")
                    .HasMaxLength(255);

                entity.Property(e => e.Toprofileid)
                    .HasColumnName("toprofileid")
                    .HasMaxLength(255);

                entity.Property(e => e.Validity)
                    .HasColumnName("validity")
                    .HasMaxLength(255);

                entity.Property(e => e.Validityid)
                    .HasColumnName("validityid")
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255);

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.Versiondetail)
                    .HasColumnName("versiondetail")
                    .HasMaxLength(255);

                entity.Property(e => e.Year).HasColumnName("year");

                entity.Property(e => e.Year111)
                    .HasColumnName("year111")
                    .HasMaxLength(255);

                entity.Property(e => e.Year114)
                    .HasColumnName("year114")
                    .HasMaxLength(255);

                entity.Property(e => e.Year121)
                    .HasColumnName("year121")
                    .HasMaxLength(255);

                entity.Property(e => e.Year124)
                    .HasColumnName("year124")
                    .HasMaxLength(255);

                entity.Property(e => e.Year131)
                    .HasColumnName("year131")
                    .HasMaxLength(255);

                entity.Property(e => e.Year45)
                    .HasColumnName("year45")
                    .HasMaxLength(255);

                entity.Property(e => e.Year48)
                    .HasColumnName("year48")
                    .HasMaxLength(255);

                entity.Property(e => e.Year55)
                    .HasColumnName("year55")
                    .HasMaxLength(255);

                entity.Property(e => e.Year58)
                    .HasColumnName("year58")
                    .HasMaxLength(255);

                entity.Property(e => e.Year83)
                    .HasColumnName("year83")
                    .HasMaxLength(255);

                entity.Property(e => e.Year86)
                    .HasColumnName("year86")
                    .HasMaxLength(255);

                entity.Property(e => e.Year93)
                    .HasColumnName("year93")
                    .HasMaxLength(255);

                entity.Property(e => e.Year96)
                    .HasColumnName("year96")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed)
                    .HasColumnName("yearfixed")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed103)
                    .HasColumnName("yearfixed103")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed108)
                    .HasColumnName("yearfixed108")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed118)
                    .HasColumnName("yearfixed118")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed136)
                    .HasColumnName("yearfixed136")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed42)
                    .HasColumnName("yearfixed42")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed52)
                    .HasColumnName("yearfixed52")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed76)
                    .HasColumnName("yearfixed76")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed80)
                    .HasColumnName("yearfixed80")
                    .HasMaxLength(255);

                entity.Property(e => e.Yearfixed90)
                    .HasColumnName("yearfixed90")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SecurityQuestions>(entity =>
            {
                entity.ToTable("security_questions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.SecurityQuestion)
                    .HasColumnName("security_question")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<SettingStatus>(entity =>
            {
                entity.ToTable("setting_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.ReferenceTable)
                    .IsRequired()
                    .HasColumnName("reference_table")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasColumnName("status_name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<SysAccessRights>(entity =>
            {
                entity.HasKey(e => e.Aruuid)
                    .HasName("sys_access_rights_pkey");

                entity.ToTable("sys_access_rights");

                entity.Property(e => e.Aruuid)
                    .HasColumnName("aruuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Aradd).HasColumnName("aradd");

                entity.Property(e => e.Ardelete).HasColumnName("ardelete");

                entity.Property(e => e.Arlist).HasColumnName("arlist");

                entity.Property(e => e.Arupdate).HasColumnName("arupdate");

                entity.Property(e => e.Arview).HasColumnName("arview");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Functionuuid).HasColumnName("functionuuid");

                entity.Property(e => e.Roleuuid).HasColumnName("roleuuid");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysAccessRights)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.Functionuu)
                    .WithMany(p => p.SysAccessRightsFunctionuu)
                    .HasForeignKey(d => d.Functionuuid)
                    .HasConstraintName("sys_access_rights_functionuuid_fkey");

                entity.HasOne(d => d.Roleuu)
                    .WithMany(p => p.SysAccessRightsRoleuu)
                    .HasForeignKey(d => d.Roleuuid)
                    .HasConstraintName("sys_access_rights_roleuuid_fkey");
            });

            modelBuilder.Entity<SysAdmin>(entity =>
            {
                entity.HasKey(e => e.Adminuuid)
                    .HasName("sys_admin_pkey");

                entity.ToTable("sys_admin");

                entity.Property(e => e.Adminuuid)
                    .HasColumnName("adminuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Adminstatus).HasColumnName("adminstatus");

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(2);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Efffromdate)
                    .HasColumnName("efffromdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Efftodate)
                    .HasColumnName("efftodate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(400);

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasMaxLength(400);

                entity.Property(e => e.Lockedexpirydt)
                    .HasColumnName("lockedexpirydt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Lockedstatus).HasColumnName("lockedstatus");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(50);

                entity.Property(e => e.Orguuid).HasColumnName("orguuid");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100);

                entity.Property(e => e.PasswordExpiryDate).HasColumnName("password_expiry_date");

                entity.Property(e => e.Retrycount).HasColumnName("retrycount");

                entity.Property(e => e.Roleuuid).HasColumnName("roleuuid");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.Property(e => e.Useruuid).HasColumnName("useruuid");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.InverseCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_admin_crby_pk");

                entity.HasOne(d => d.Orguu)
                    .WithMany(p => p.SysAdmin)
                    .HasForeignKey(d => d.Orguuid)
                    .HasConstraintName("sys_admin_organizationuuid_fkey");

                entity.HasOne(d => d.Roleuu)
                    .WithMany(p => p.SysAdmin)
                    .HasForeignKey(d => d.Roleuuid)
                    .HasConstraintName("sys_admin_roleuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.InverseUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("sys_admin_upby_pk");

                entity.HasOne(d => d.Useruu)
                    .WithMany(p => p.SysAdmin)
                    .HasForeignKey(d => d.Useruuid)
                    .HasConstraintName("sys_admin_useruuid_fk");
            });

            modelBuilder.Entity<SysAdminPasswordHistory>(entity =>
            {
                entity.ToTable("sys_admin_password_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.MinPasswordAgeDays).HasColumnName("min_password_age_days");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SysAdminPasswordHistory)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sys_admin_password_history_sys_admin");
            });

            modelBuilder.Entity<SysAdminUnlockHistory>(entity =>
            {
                entity.ToTable("sys_admin_unlock_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SysAdminUnlockHistoryCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sys_admin_unlock_history_user_that_unlock");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SysAdminUnlockHistoryUser)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sys_admin_unlock_history_unlocked_user");
            });

            modelBuilder.Entity<SysAgents>(entity =>
            {
                entity.HasKey(e => e.Agentuuid)
                    .HasName("sys_agents_pk");

                entity.ToTable("sys_agents");

                entity.Property(e => e.Agentuuid)
                    .HasColumnName("agentuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Agentlogo)
                    .HasColumnName("agentlogo")
                    .HasMaxLength(250);

                entity.Property(e => e.Agentstatus).HasColumnName("agentstatus");

                entity.Property(e => e.Channelcode)
                    .HasColumnName("channelcode")
                    .HasMaxLength(50);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Efffromdate)
                    .HasColumnName("efffromdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Efftodate)
                    .HasColumnName("efftodate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200);

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasMaxLength(400);

                entity.Property(e => e.Gatewayaccountuuid).HasColumnName("gatewayaccountuuid");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100);

                entity.Property(e => e.Pseudoagentcode)
                    .HasColumnName("pseudoagentcode")
                    .HasMaxLength(50);

                entity.Property(e => e.Pseudocitycode)
                    .HasColumnName("pseudocitycode")
                    .HasMaxLength(50);

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysAgentsCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_agents_crby_pk");

                entity.HasOne(d => d.Gatewayaccountuu)
                    .WithMany(p => p.SysAgents)
                    .HasForeignKey(d => d.Gatewayaccountuuid)
                    .HasConstraintName("sys_agents_gatewayaccountuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysAgentsUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("sys_agents_upby_pk");
            });

            modelBuilder.Entity<SysAgentsFunctionsWs>(entity =>
            {
                entity.HasKey(e => e.Afwsuuid)
                    .HasName("sys_agents_functions_ws_pkey");

                entity.ToTable("sys_agents_functions_ws");

                entity.HasIndex(e => new { e.Agentuuid, e.Functionwsuuid })
                    .HasName("sys_agents_functions_ws_un")
                    .IsUnique();

                entity.Property(e => e.Afwsuuid)
                    .HasColumnName("afwsuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Agentuuid).HasColumnName("agentuuid");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Functionwsuuid).HasColumnName("functionwsuuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.Agentuu)
                    .WithMany(p => p.SysAgentsFunctionsWs)
                    .HasForeignKey(d => d.Agentuuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_agents_functions_ws_agentuuid_fk");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysAgentsFunctionsWsCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_agents_crby_pk");

                entity.HasOne(d => d.Functionwsuu)
                    .WithMany(p => p.SysAgentsFunctionsWs)
                    .HasForeignKey(d => d.Functionwsuuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_agents_functions_ws_functionwsuuid_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysAgentsFunctionsWsUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("sys_agents_upby_pk");
            });

            modelBuilder.Entity<SysAgentsIpaddresses>(entity =>
            {
                entity.HasKey(e => e.Agentipuuid)
                    .HasName("sys_agents_ipaddresses_pkey");

                entity.ToTable("sys_agents_ipaddresses");

                entity.Property(e => e.Agentipuuid)
                    .HasColumnName("agentipuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Agentuuid).HasColumnName("agentuuid");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("ipaddress")
                    .HasMaxLength(50);

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.Agentuu)
                    .WithMany(p => p.SysAgentsIpaddresses)
                    .HasForeignKey(d => d.Agentuuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_agents_ipaddresses_fk");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysAgentsIpaddressesCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysAgentsIpaddressesUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<SysAgentsPlans>(entity =>
            {
                entity.HasKey(e => e.Agentplanuuid)
                    .HasName("sys_agents_plans_pkey");

                entity.ToTable("sys_agents_plans");

                entity.Property(e => e.Agentplanuuid)
                    .HasColumnName("agentplanuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Agentuuid).HasColumnName("agentuuid");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Planuuid).HasColumnName("planuuid");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.Agentuu)
                    .WithMany(p => p.SysAgentsPlans)
                    .HasForeignKey(d => d.Agentuuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_agents_plans_fk");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysAgentsPlans)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");
            });

            modelBuilder.Entity<SysAgentsPseudos>(entity =>
            {
                entity.HasKey(e => e.Agentpseudouuid)
                    .HasName("sys_agents_pseudos_pkey");

                entity.ToTable("sys_agents_pseudos");

                entity.Property(e => e.Agentpseudouuid)
                    .HasColumnName("agentpseudouuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Agentuuid).HasColumnName("agentuuid");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Pseudoagentcode)
                    .IsRequired()
                    .HasColumnName("pseudoagentcode")
                    .HasMaxLength(50);

                entity.Property(e => e.Pseudocitycode)
                    .IsRequired()
                    .HasColumnName("pseudocitycode")
                    .HasMaxLength(50);

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.Agentuu)
                    .WithMany(p => p.SysAgentsPseudos)
                    .HasForeignKey(d => d.Agentuuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_agents_pseudos_agentid_fk");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysAgentsPseudosCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysAgentsPseudosUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<SysAgentsVirtualsettings>(entity =>
            {
                entity.HasKey(e => e.Agentvsuuid)
                    .HasName("sys_agents_virtualsettings_pkey");

                entity.ToTable("sys_agents_virtualsettings");

                entity.Property(e => e.Agentvsuuid)
                    .HasColumnName("agentvsuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Agentuuid).HasColumnName("agentuuid");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Vsname)
                    .HasColumnName("vsname")
                    .HasMaxLength(100);

                entity.Property(e => e.Vsuuid).HasColumnName("vsuuid");

                entity.Property(e => e.Vsvalue)
                    .IsRequired()
                    .HasColumnName("vsvalue")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Agentuu)
                    .WithMany(p => p.SysAgentsVirtualsettings)
                    .HasForeignKey(d => d.Agentuuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_agents_virtualsettings_agentid_fk");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysAgentsVirtualsettingsCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysAgentsVirtualsettingsUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");

                entity.HasOne(d => d.Vsuu)
                    .WithMany(p => p.SysAgentsVirtualsettings)
                    .HasForeignKey(d => d.Vsuuid)
                    .HasConstraintName("vsuuid_fk");
            });

            modelBuilder.Entity<SysAirports>(entity =>
            {
                entity.HasKey(e => e.Airportuuid)
                    .HasName("sys_airports_pk");

                entity.ToTable("sys_airports");

                entity.Property(e => e.Airportuuid)
                    .HasColumnName("airportuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Areacode)
                    .HasColumnName("areacode")
                    .HasMaxLength(10);

                entity.Property(e => e.Citycode)
                    .IsRequired()
                    .HasColumnName("citycode")
                    .HasMaxLength(5);

                entity.Property(e => e.Citydesc)
                    .HasColumnName("citydesc")
                    .HasMaxLength(250);

                entity.Property(e => e.Cityuuid).HasColumnName("cityuuid");

                entity.Property(e => e.Countrycode)
                    .IsRequired()
                    .HasColumnName("countrycode")
                    .HasMaxLength(5);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Hourdiff)
                    .HasColumnName("hourdiff")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.Cityuu)
                    .WithMany(p => p.SysAirports)
                    .HasForeignKey(d => d.Cityuuid)
                    .HasConstraintName("sys_airports_cityuuid_fkey");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysAirportsCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_airports_crby_pk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysAirportsUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("sys_airports_upby_pk");
            });

            modelBuilder.Entity<SysCity>(entity =>
            {
                entity.HasKey(e => e.Cityuuid)
                    .HasName("sys_city_pkey");

                entity.ToTable("sys_city");

                entity.Property(e => e.Cityuuid)
                    .HasColumnName("cityuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Cityname)
                    .IsRequired()
                    .HasColumnName("cityname")
                    .HasMaxLength(100);

                entity.Property(e => e.Coordlat)
                    .HasColumnName("coordlat")
                    .HasMaxLength(12);

                entity.Property(e => e.Coordlon)
                    .HasColumnName("coordlon")
                    .HasMaxLength(12);

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(3);

                entity.Property(e => e.OwmId).HasColumnName("owm_id");
            });

            modelBuilder.Entity<SysClaimPermission>(entity =>
            {
                entity.ToTable("sys_claim_permission");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ClaimStatusValue).HasColumnName("claim_status_value");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.Permission)
                    .HasColumnName("permission")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<SysCountries>(entity =>
            {
                entity.HasKey(e => e.Countryuuid)
                    .HasName("sys_countries_pkey");

                entity.ToTable("sys_countries");

                entity.Property(e => e.Countryuuid)
                    .HasColumnName("countryuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Countrycode)
                    .IsRequired()
                    .HasColumnName("countrycode")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Countrydesc)
                    .IsRequired()
                    .HasColumnName("countrydesc")
                    .HasMaxLength(100);

                entity.Property(e => e.Currencycode)
                    .IsRequired()
                    .HasColumnName("currencycode")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<SysCulturecodes>(entity =>
            {
                entity.HasKey(e => e.Culturecode)
                    .HasName("sys_culturecodes_pk");

                entity.ToTable("sys_culturecodes");

                entity.Property(e => e.Culturecode)
                    .HasColumnName("culturecode")
                    .HasMaxLength(2);

                entity.Property(e => e.Culturedesc)
                    .HasColumnName("culturedesc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysCurrencies>(entity =>
            {
                entity.HasKey(e => e.Currencycode)
                    .HasName("sys_currencies_pk");

                entity.ToTable("sys_currencies");

                entity.Property(e => e.Currencycode)
                    .HasColumnName("currencycode")
                    .HasMaxLength(50);

                entity.Property(e => e.Currencydesc)
                    .HasColumnName("currencydesc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysCurrencyExchange>(entity =>
            {
                entity.HasKey(e => e.Currencyexchangeuuid)
                    .HasName("sys_currency_exchange_pkey");

                entity.ToTable("sys_currency_exchange");

                entity.Property(e => e.Currencyexchangeuuid)
                    .HasColumnName("currencyexchangeuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Currency1)
                    .IsRequired()
                    .HasColumnName("currency1")
                    .HasMaxLength(5);

                entity.Property(e => e.Currency2)
                    .IsRequired()
                    .HasColumnName("currency2")
                    .HasMaxLength(5);

                entity.Property(e => e.Currencyvalue1)
                    .HasColumnName("currencyvalue1")
                    .HasColumnType("numeric");

                entity.Property(e => e.Currencyvalue2)
                    .HasColumnName("currencyvalue2")
                    .HasColumnType("numeric");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysCurrencyExchange)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_currency_crby_pk");
            });

            modelBuilder.Entity<SysCurrencyExchangeDashboard>(entity =>
            {
                entity.HasKey(e => e.Ceduuid)
                    .HasName("sys_currency_exchange_dashboard_pkey");

                entity.ToTable("sys_currency_exchange_dashboard");

                entity.Property(e => e.Ceduuid)
                    .HasColumnName("ceduuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Currencyfrom)
                    .IsRequired()
                    .HasColumnName("currencyfrom")
                    .HasMaxLength(3);

                entity.Property(e => e.Currencyto)
                    .IsRequired()
                    .HasColumnName("currencyto")
                    .HasMaxLength(3);

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Exchangerate)
                    .HasColumnName("exchangerate")
                    .HasColumnType("numeric");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysCurrencyExchangeDashboard)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");
            });

            modelBuilder.Entity<SysForex>(entity =>
            {
                entity.HasKey(e => e.Forexuuid)
                    .HasName("sys_forex_pkey");

                entity.ToTable("sys_forex");

                entity.Property(e => e.Forexuuid)
                    .HasColumnName("forexuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Currencyfrom)
                    .IsRequired()
                    .HasColumnName("currencyfrom")
                    .HasMaxLength(3);

                entity.Property(e => e.Currencyfromvalue)
                    .HasColumnName("currencyfromvalue")
                    .HasColumnType("numeric");

                entity.Property(e => e.Currencyto)
                    .IsRequired()
                    .HasColumnName("currencyto")
                    .HasMaxLength(3);

                entity.Property(e => e.Currencytovalue)
                    .HasColumnName("currencytovalue")
                    .HasColumnType("numeric");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysForexCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_forex_crby_pk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysForexUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("sys_forex_upby_pk");
            });

            modelBuilder.Entity<SysFunctions>(entity =>
            {
                entity.HasKey(e => e.Functionuuid)
                    .HasName("sys_functions_pkey");

                entity.ToTable("sys_functions");

                entity.Property(e => e.Functionuuid)
                    .HasColumnName("functionuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Functiondesc)
                    .HasColumnName("functiondesc")
                    .HasMaxLength(400);

                entity.Property(e => e.Functionlink)
                    .HasColumnName("functionlink")
                    .HasMaxLength(400);

                entity.Property(e => e.Functiontitle)
                    .HasColumnName("functiontitle")
                    .HasMaxLength(200);

                entity.Property(e => e.Parentuuid).HasColumnName("parentuuid");

                entity.Property(e => e.Sequenceuuid).HasColumnName("sequenceuuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysFunctionsCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_functions_crby_pk");

                entity.HasOne(d => d.Parentuu)
                    .WithMany(p => p.InverseParentuu)
                    .HasForeignKey(d => d.Parentuuid)
                    .HasConstraintName("sys_functions_parentuuid_fkey");

                entity.HasOne(d => d.Sequenceuu)
                    .WithMany(p => p.InverseSequenceuu)
                    .HasForeignKey(d => d.Sequenceuuid)
                    .HasConstraintName("sys_functions_sequenceuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysFunctionsUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("sys_functions_upby_pk");
            });

            modelBuilder.Entity<SysFunctionsAccess>(entity =>
            {
                entity.HasKey(e => e.Functionaccessuuid)
                    .HasName("sys_functions_access_pkey");

                entity.ToTable("sys_functions_access");

                entity.Property(e => e.Functionaccessuuid)
                    .HasColumnName("functionaccessuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Functionadd).HasColumnName("functionadd");

                entity.Property(e => e.Functiondelete).HasColumnName("functiondelete");

                entity.Property(e => e.Functionedit).HasColumnName("functionedit");

                entity.Property(e => e.Functionlist).HasColumnName("functionlist");

                entity.Property(e => e.Functionuuid).HasColumnName("functionuuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysFunctionsAccessCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_functions_crby_pk");

                entity.HasOne(d => d.Functionuu)
                    .WithMany(p => p.SysFunctionsAccess)
                    .HasForeignKey(d => d.Functionuuid)
                    .HasConstraintName("sys_functions_access_functionuuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysFunctionsAccessUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("sys_functions_upby_pk");
            });

            modelBuilder.Entity<SysFunctionsProcess>(entity =>
            {
                entity.HasKey(e => e.Functionprocessuuid)
                    .HasName("sys_functions_process_pkey");

                entity.ToTable("sys_functions_process");

                entity.Property(e => e.Functionprocessuuid)
                    .HasColumnName("functionprocessuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Functiondesc)
                    .HasColumnName("functiondesc")
                    .HasMaxLength(400);

                entity.Property(e => e.Functionlink)
                    .HasColumnName("functionlink")
                    .HasMaxLength(400);

                entity.Property(e => e.Functiontitle)
                    .HasColumnName("functiontitle")
                    .HasMaxLength(200);

                entity.Property(e => e.Parentuuid).HasColumnName("parentuuid");

                entity.Property(e => e.Sequenceuuid).HasColumnName("sequenceuuid");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysFunctionsProcess)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_functions_crby_pk");

                entity.HasOne(d => d.Parentuu)
                    .WithMany(p => p.InverseParentuu)
                    .HasForeignKey(d => d.Parentuuid)
                    .HasConstraintName("sys_functions_process_parentuuid_fkey");

                entity.HasOne(d => d.Sequenceuu)
                    .WithMany(p => p.InverseSequenceuu)
                    .HasForeignKey(d => d.Sequenceuuid)
                    .HasConstraintName("sys_functions_process_sequenceuuid_fkey");
            });

            modelBuilder.Entity<SysFunctionsWs>(entity =>
            {
                entity.HasKey(e => e.Functionwsuuid)
                    .HasName("sys_functions_ws_pkey");

                entity.ToTable("sys_functions_ws");

                entity.Property(e => e.Functionwsuuid)
                    .HasColumnName("functionwsuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Functiondesc)
                    .HasColumnName("functiondesc")
                    .HasMaxLength(400);

                entity.Property(e => e.Functionlink)
                    .HasColumnName("functionlink")
                    .HasMaxLength(400);

                entity.Property(e => e.Functiontitle)
                    .HasColumnName("functiontitle")
                    .HasMaxLength(200);

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysFunctionsWs)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_functions_crby_pk");
            });

            modelBuilder.Entity<SysGatewayAccount>(entity =>
            {
                entity.HasKey(e => e.Gatewayaccountuuid)
                    .HasName("sys_gateway_account_pk");

                entity.ToTable("sys_gateway_account");

                entity.Property(e => e.Gatewayaccountuuid)
                    .HasColumnName("gatewayaccountuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Gatewayusername)
                    .IsRequired()
                    .HasColumnName("gatewayusername");

                entity.Property(e => e.Orguuid).HasColumnName("orguuid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt).HasColumnName("updt");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysGatewayAccountCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_gateway_account_crby_fkey");

                entity.HasOne(d => d.Orguu)
                    .WithMany(p => p.SysGatewayAccount)
                    .HasForeignKey(d => d.Orguuid)
                    .HasConstraintName("sys_gateway_account_orguuid_fkey");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysGatewayAccountUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("sys_gateway_account_upby_fkey");
            });

            modelBuilder.Entity<SysLoginLog>(entity =>
            {
                entity.HasKey(e => e.Loginloguuid)
                    .HasName("sys_login_log_pkey");

                entity.ToTable("sys_login_log");

                entity.Property(e => e.Loginloguuid)
                    .HasColumnName("loginloguuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Actionid).HasColumnName("actionid");

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Pagename)
                    .HasColumnName("pagename")
                    .HasMaxLength(100);

                entity.Property(e => e.Sessionid)
                    .IsRequired()
                    .HasColumnName("sessionid")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysMenu>(entity =>
            {
                entity.ToTable("sys_menu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ControllerAction)
                    .HasColumnName("controller_action")
                    .HasColumnType("character varying");

                entity.Property(e => e.ControllerName)
                    .HasColumnName("controller_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnName("display_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.MenuGroupId).HasColumnName("menu_group_id");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.SortNo).HasColumnName("sort_no");

                entity.HasOne(d => d.MenuGroup)
                    .WithMany(p => p.SysMenu)
                    .HasForeignKey(d => d.MenuGroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("sys_menu_menu_group_fk");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("sys_menu_parent_fk");
            });

            modelBuilder.Entity<SysMenuGroup>(entity =>
            {
                entity.ToTable("sys_menu_group");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.GroupClaims)
                    .HasColumnName("group_claims")
                    .HasColumnType("character varying");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate).HasColumnName("modified_date");

                entity.Property(e => e.SortNo).HasColumnName("sort_no");
            });

            modelBuilder.Entity<SysMigrationLog>(entity =>
            {
                entity.HasKey(e => e.Migrationloguuid)
                    .HasName("sys_migration_log_pk");

                entity.ToTable("sys_migration_log");

                entity.Property(e => e.Migrationloguuid)
                    .HasColumnName("migrationloguuid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Hashedvalue)
                    .HasColumnName("hashedvalue")
                    .HasMaxLength(50);

                entity.Property(e => e.Tablename)
                    .IsRequired()
                    .HasColumnName("tablename")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysOrganizations>(entity =>
            {
                entity.HasKey(e => e.Orguuid)
                    .HasName("sys_organizations_pkey");

                entity.ToTable("sys_organizations");

                entity.Property(e => e.Orguuid)
                    .HasColumnName("orguuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Addressline1)
                    .HasColumnName("addressline1")
                    .HasMaxLength(200);

                entity.Property(e => e.Addressline2)
                    .HasColumnName("addressline2")
                    .HasMaxLength(200);

                entity.Property(e => e.Addressline3)
                    .HasColumnName("addressline3")
                    .HasMaxLength(200);

                entity.Property(e => e.Businesschannel)
                    .HasColumnName("businesschannel")
                    .HasMaxLength(70);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Companyname)
                    .IsRequired()
                    .HasColumnName("companyname")
                    .HasMaxLength(200);

                entity.Property(e => e.Contactperson)
                    .HasColumnName("contactperson")
                    .HasMaxLength(200);

                entity.Property(e => e.Coregno)
                    .HasColumnName("coregno")
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(800);

                entity.Property(e => e.Officetelephone)
                    .HasColumnName("officetelephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Postcode)
                    .HasColumnName("postcode")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50);

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysOrganizationsCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysOrganizationsUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<SysRoleClaimPermission>(entity =>
            {
                entity.ToTable("sys_role_claim_permission");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.MaxClaimAmount).HasColumnName("max_claim_amount");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");
            });

            modelBuilder.Entity<SysRolePermission>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("sys_role_permission_pkey");

                entity.ToTable("sys_role_permission");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.IsGranted).HasColumnName("is_granted");

                entity.Property(e => e.Permission)
                    .HasColumnName("permission")
                    .HasColumnType("character varying");

                entity.Property(e => e.RoleId).HasColumnName("role_id");
            });

            modelBuilder.Entity<SysRoles>(entity =>
            {
                entity.HasKey(e => e.Roleuuid)
                    .HasName("sys_roles_pkey");

                entity.ToTable("sys_roles");

                entity.Property(e => e.Roleuuid)
                    .HasColumnName("roleuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role")
                    .HasMaxLength(20);

                entity.Property(e => e.Roledesc)
                    .HasColumnName("roledesc")
                    .HasMaxLength(30);

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Versionno).HasColumnName("versionno");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysRolesCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysRolesUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<SysRolesMenu>(entity =>
            {
                entity.ToTable("sys_roles_menu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.MenuGroupId).HasColumnName("menu_group_id");

                entity.Property(e => e.RoleUuid).HasColumnName("role_uuid");

                entity.HasOne(d => d.MenuGroup)
                    .WithMany(p => p.SysRolesMenu)
                    .HasForeignKey(d => d.MenuGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_roles_menu_menu_group_fk");

                entity.HasOne(d => d.RoleUu)
                    .WithMany(p => p.SysRolesMenu)
                    .HasForeignKey(d => d.RoleUuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_roles_menu_role_fk");
            });

            modelBuilder.Entity<SysTitles>(entity =>
            {
                entity.HasKey(e => e.Titleuuid)
                    .HasName("sys_titles_pkey");

                entity.ToTable("sys_titles");

                entity.Property(e => e.Titleuuid)
                    .HasColumnName("titleuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Titlegender)
                    .IsRequired()
                    .HasColumnName("titlegender")
                    .HasMaxLength(1);

                entity.Property(e => e.Titlename)
                    .IsRequired()
                    .HasColumnName("titlename")
                    .HasMaxLength(50);

                entity.Property(e => e.Titleorder).HasColumnName("titleorder");
            });

            modelBuilder.Entity<SysUsers>(entity =>
            {
                entity.HasKey(e => e.Useruuid)
                    .HasName("sys_users_pkey");

                entity.ToTable("sys_users");

                entity.Property(e => e.Useruuid)
                    .HasColumnName("useruuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Accessid).HasColumnName("accessid");

                entity.Property(e => e.Acid).HasColumnName("acid");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Efffromdate)
                    .HasColumnName("efffromdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Efftodate)
                    .HasColumnName("efftodate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250);

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasMaxLength(250);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100);

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(0) without time zone");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);

                entity.Property(e => e.Usertype).HasColumnName("usertype");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysUsersCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .HasConstraintName("crby_fk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysUsersUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("upby_fk");
            });

            modelBuilder.Entity<SysUsersIp>(entity =>
            {
                entity.HasKey(e => e.Useripuuid)
                    .HasName("sys_users_ip_pkey");

                entity.ToTable("sys_users_ip");

                entity.Property(e => e.Useripuuid)
                    .HasColumnName("useripuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Efffromdate)
                    .HasColumnName("efffromdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Efftodate)
                    .HasColumnName("efftodate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("ipaddress")
                    .HasMaxLength(50);

                entity.Property(e => e.Useruuid).HasColumnName("useruuid");

                entity.HasOne(d => d.Useruu)
                    .WithMany(p => p.SysUsersIp)
                    .HasForeignKey(d => d.Useruuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_users_ip_useruuid_fk");
            });

            modelBuilder.Entity<SysUsersUnderwriters>(entity =>
            {
                entity.HasKey(e => e.Useruwuuid)
                    .HasName("sys_users_underwriters_pkey");

                entity.ToTable("sys_users_underwriters");

                entity.Property(e => e.Useruwuuid)
                    .HasColumnName("useruwuuid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Efffromdate)
                    .HasColumnName("efffromdate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Efftodate)
                    .HasColumnName("efftodate")
                    .HasColumnType("timestamp(3) without time zone");

                entity.Property(e => e.Underwriteruuid).HasColumnName("underwriteruuid");

                entity.Property(e => e.Useruuid).HasColumnName("useruuid");

                entity.HasOne(d => d.Underwriteruu)
                    .WithMany(p => p.SysUsersUnderwriters)
                    .HasForeignKey(d => d.Underwriteruuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_users_underwriters_underwriteruuid_fkey");

                entity.HasOne(d => d.Useruu)
                    .WithMany(p => p.SysUsersUnderwriters)
                    .HasForeignKey(d => d.Useruuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_users_underwriters_useruuid_fkey");
            });

            modelBuilder.Entity<SysVirtualsetting>(entity =>
            {
                entity.HasKey(e => e.Vsuuid)
                    .HasName("sys_virtualsetting_pkey");

                entity.ToTable("sys_virtualsetting");

                entity.Property(e => e.Vsuuid)
                    .HasColumnName("vsuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt).HasColumnName("crdt");

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt).HasColumnName("updt");

                entity.Property(e => e.Vsname)
                    .IsRequired()
                    .HasColumnName("vsname")
                    .HasMaxLength(100);

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysVirtualsetting)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crby_fk");
            });

            modelBuilder.Entity<SysWeatherIndex>(entity =>
            {
                entity.HasKey(e => e.Weatherindexuuid)
                    .HasName("sys_weather_index_pk");

                entity.ToTable("sys_weather_index");

                entity.Property(e => e.Weatherindexuuid)
                    .HasColumnName("weatherindexuuid")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Conditioncode)
                    .IsRequired()
                    .HasColumnName("conditioncode")
                    .HasMaxLength(6);

                entity.Property(e => e.Crby).HasColumnName("crby");

                entity.Property(e => e.Crdt)
                    .HasColumnName("crdt")
                    .HasColumnType("timestamp(3) without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.Disabledinsurance).HasColumnName("disabledinsurance");

                entity.Property(e => e.Loading)
                    .HasColumnName("loading")
                    .HasColumnType("numeric(14,2)");

                entity.Property(e => e.Maincode)
                    .IsRequired()
                    .HasColumnName("maincode")
                    .HasMaxLength(25);

                entity.Property(e => e.Upby).HasColumnName("upby");

                entity.Property(e => e.Updt)
                    .HasColumnName("updt")
                    .HasColumnType("timestamp(3) without time zone");

                entity.HasOne(d => d.CrbyNavigation)
                    .WithMany(p => p.SysWeatherIndexCrbyNavigation)
                    .HasForeignKey(d => d.Crby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_weather_crby_pk");

                entity.HasOne(d => d.UpbyNavigation)
                    .WithMany(p => p.SysWeatherIndexUpbyNavigation)
                    .HasForeignKey(d => d.Upby)
                    .HasConstraintName("sys_weather_upby_pk");
            });

            modelBuilder.Entity<TaskSchedulerJob>(entity =>
            {
                entity.ToTable("task_scheduler_job");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ApiTokenUrl)
                    .HasColumnName("api_token_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.ApiUrl)
                    .HasColumnName("api_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.Authentication)
                    .IsRequired()
                    .HasColumnName("authentication")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CronExpressions)
                    .HasColumnName("cron_expressions")
                    .HasColumnType("character varying");

                entity.Property(e => e.EmailList)
                    .HasColumnName("email_list")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsErrorRerun).HasColumnName("is_error_rerun");

                entity.Property(e => e.IsErrorSendEmail).HasColumnName("is_error_send_email");

                entity.Property(e => e.IsOneTime).HasColumnName("is_one_time");

                entity.Property(e => e.JobNo).HasColumnName("job_no");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("character varying");

                entity.Property(e => e.RequestBody)
                    .HasColumnName("request_body")
                    .HasColumnType("json");

                entity.Property(e => e.TaskName)
                    .HasColumnName("task_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<TaskSchedulerLog>(entity =>
            {
                entity.ToTable("task_scheduler_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ActionDate)
                    .HasColumnName("action_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.IsSuccess).HasColumnName("is_success");

                entity.Property(e => e.TaskId).HasColumnName("task_id");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskSchedulerLog)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("task_id_fk");
            });

            modelBuilder.Entity<TokenManagement>(entity =>
            {
                entity.ToTable("token_management");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('token_id_seq'::regclass)");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Token).HasColumnName("token");

                entity.Property(e => e.TokenName)
                    .IsRequired()
                    .HasColumnName("token_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<UserAccess>(entity =>
            {
                entity.ToTable("user_access");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessRoleId).HasColumnName("access_role_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<UserSecurityTypes>(entity =>
            {
                entity.ToTable("user_security_types");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AccessTokenValidity).HasColumnName("access_token_validity");

                entity.Property(e => e.AccountLockPeriod).HasColumnName("account_lock_period");

                entity.Property(e => e.ActivationCodeExpiry).HasColumnName("activation_code_expiry");

                entity.Property(e => e.AppRedirection).HasColumnName("app_redirection");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Entityid).HasColumnName("entityid");

                entity.Property(e => e.InactivityPeriodInDays).HasColumnName("inactivity_period_in_days");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.IsMobile).HasColumnName("is_mobile");

                entity.Property(e => e.IsTacRequired).HasColumnName("is_tac_required");

                entity.Property(e => e.IsTacRequiredForWeb).HasColumnName("is_tac_required_for_web");

                entity.Property(e => e.IsWeb).HasColumnName("is_web");

                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

                entity.Property(e => e.LastModifiedDate).HasColumnName("last_modified_date");

                entity.Property(e => e.LastPasswordHistoryLimit).HasColumnName("last_password_history_limit");

                entity.Property(e => e.LoginAttempts).HasColumnName("login_attempts");

                entity.Property(e => e.LoginTimeOut).HasColumnName("login_time_out");

                entity.Property(e => e.MaxLength).HasColumnName("max_length");

                entity.Property(e => e.MinLength).HasColumnName("min_length");

                entity.Property(e => e.PasswordExpiry).HasColumnName("password_expiry");

                entity.Property(e => e.Pattern)
                    .HasColumnName("pattern")
                    .HasMaxLength(255);

                entity.Property(e => e.RefreshTokenValidity).HasColumnName("refresh_token_validity");

                entity.Property(e => e.ResetOnFirstLogin).HasColumnName("reset_on_first_login");

                entity.Property(e => e.SecuritySettingId).HasColumnName("security_setting_id");

                entity.Property(e => e.TacExpiry).HasColumnName("tac_expiry");

                entity.Property(e => e.TacLength).HasColumnName("tac_length");

                entity.Property(e => e.TacVerificationAttempts).HasColumnName("tac_verification_attempts");

                entity.Property(e => e.VerificationAttempts).HasColumnName("verification_attempts");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.UserSecurityTypes)
                    .HasForeignKey(d => d.Entityid)
                    .HasConstraintName("entityid_fkey");
            });

            modelBuilder.HasSequence("audit_admin_actions_seq");

            modelBuilder.HasSequence("audit_admin_events_seq");

            modelBuilder.HasSequence("audit_getquote_seq");

            modelBuilder.HasSequence("audit_log_new_seq");

            modelBuilder.HasSequence("audit_logins_seq");

            modelBuilder.HasSequence("audit_policy_cancellations_seq");

            modelBuilder.HasSequence("audit_policy_refund_seq");

            modelBuilder.HasSequence("audit_weather_index_seq");

            modelBuilder.HasSequence("audit_webservices_seq");

            modelBuilder.HasSequence("audit_ws_planprofiles_seq");

            modelBuilder.HasSequence("authorisationapi_seq");

            modelBuilder.HasSequence("ins_carriers_seq");

            modelBuilder.HasSequence("ins_ci_templates_seq");

            modelBuilder.HasSequence("ins_emails_seq");

            modelBuilder.HasSequence("ins_journeys_seq");

            modelBuilder.HasSequence("ins_plans_categories_plans_log_seq");

            modelBuilder.HasSequence("ins_plans_categories_plans_seq");

            modelBuilder.HasSequence("ins_plans_categories_seq");

            modelBuilder.HasSequence("ins_plans_marketing_own_seq");

            modelBuilder.HasSequence("ins_plans_marketing_pointers_seq");

            modelBuilder.HasSequence("ins_plans_marketing_seq");

            modelBuilder.HasSequence("ins_plans_marketing_sub_seq");

            modelBuilder.HasSequence("ins_plans_pax_limits_relationships_seq");

            modelBuilder.HasSequence("ins_plans_pax_limits_seq");

            modelBuilder.HasSequence("ins_plans_profiles_marketing_seq");

            modelBuilder.HasSequence("ins_plans_profiles_seq");

            modelBuilder.HasSequence("ins_plans_profiles_sub_seq");

            modelBuilder.HasSequence("ins_plans_profiles_upsell_seq");

            modelBuilder.HasSequence("ins_plans_routes_seq");

            modelBuilder.HasSequence("ins_plans_seq");

            modelBuilder.HasSequence("ins_plans_serial_range_seq");

            modelBuilder.HasSequence("ins_policy_contact_person_zeus_seq");

            modelBuilder.HasSequence("ins_policy_coverage_person_zeus_seq");

            modelBuilder.HasSequence("ins_policy_detail_actions_zeus_seq");

            modelBuilder.HasSequence("ins_policy_detail_zeus_seq");

            modelBuilder.HasSequence("ins_policy_payment_status_log_seq");

            modelBuilder.HasSequence("ins_policy_payment_status_seq");

            modelBuilder.HasSequence("ins_policy_serial_range_seq");

            modelBuilder.HasSequence("ins_policy_states_seq");

            modelBuilder.HasSequence("ins_policy_unsent_zeus_seq");

            modelBuilder.HasSequence("ins_ratings_pseudo_custom_items_seq");

            modelBuilder.HasSequence("ins_ratings_pseudo_custom_seq");

            modelBuilder.HasSequence("ins_ratings_seq");

            modelBuilder.HasSequence("ins_routes_seq");

            modelBuilder.HasSequence("ins_underwriters_reports_seq");

            modelBuilder.HasSequence("ins_underwriters_seq");

            modelBuilder.HasSequence("sys_access_rights_seq");

            modelBuilder.HasSequence("sys_agents_functions_ws_seq");

            modelBuilder.HasSequence("sys_agents_ipaddresses_seq");

            modelBuilder.HasSequence("sys_agents_plans_seq");

            modelBuilder.HasSequence("sys_agents_pseudos_seq");

            modelBuilder.HasSequence("sys_agents_seq");

            modelBuilder.HasSequence("sys_agents_virtualsettings_seq");

            modelBuilder.HasSequence("sys_airports_seq");

            modelBuilder.HasSequence("sys_allow_ip_seq");

            modelBuilder.HasSequence("sys_city_seq");

            modelBuilder.HasSequence("sys_countries_seq");

            modelBuilder.HasSequence("sys_currency_exchange_dashboard_seq");

            modelBuilder.HasSequence("sys_currency_exchange_seq");

            modelBuilder.HasSequence("sys_functions_access_seq");

            modelBuilder.HasSequence("sys_functions_process_seq");

            modelBuilder.HasSequence("sys_functions_seq");

            modelBuilder.HasSequence("sys_functions_ws_seq");

            modelBuilder.HasSequence("sys_login_log_seq");

            modelBuilder.HasSequence("sys_migration_log_seq");

            modelBuilder.HasSequence("sys_organizations_seq");

            modelBuilder.HasSequence("sys_roles_seq");

            modelBuilder.HasSequence("sys_titles_seq");

            modelBuilder.HasSequence("sys_users_ip_seq");

            modelBuilder.HasSequence("sys_users_seq");

            modelBuilder.HasSequence("sys_users_underwriters_seq");

            modelBuilder.HasSequence("sys_weather_index_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
