using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysAdmin
    {
        public SysAdmin()
        {
            ActionLog = new HashSet<ActionLog>();
            AuditAdminActionsActionapprovaluseruu = new HashSet<AuditAdminActions>();
            AuditAdminActionsAdminuu = new HashSet<AuditAdminActions>();
            AuditAdminEvents = new HashSet<AuditAdminEvents>();
            AuthorisationapiCrbyNavigation = new HashSet<Authorisationapi>();
            AuthorisationapiUpbyNavigation = new HashSet<Authorisationapi>();
            InsBookingclassCrbyNavigation = new HashSet<InsBookingclass>();
            InsBookingclassUpbyNavigation = new HashSet<InsBookingclass>();
            InsCampaignsCrbyNavigation = new HashSet<InsCampaigns>();
            InsCampaignsUpbyNavigation = new HashSet<InsCampaigns>();
            InsCarrierBookingsCrbyNavigation = new HashSet<InsCarrierBookings>();
            InsCarrierBookingsUpbyNavigation = new HashSet<InsCarrierBookings>();
            InsCarrierFaresCrbyNavigation = new HashSet<InsCarrierFares>();
            InsCarrierFaresUpbyNavigation = new HashSet<InsCarrierFares>();
            InsCarrierFaretiersCrbyNavigation = new HashSet<InsCarrierFaretiers>();
            InsCarrierFaretiersUpbyNavigation = new HashSet<InsCarrierFaretiers>();
            InsCarriersCrbyNavigation = new HashSet<InsCarriers>();
            InsCarriersUpbyNavigation = new HashSet<InsCarriers>();
            InsCiTemplatesCrbyNavigation = new HashSet<InsCiTemplates>();
            InsCiTemplatesUpbyNavigation = new HashSet<InsCiTemplates>();
            InsEmailsCrbyNavigation = new HashSet<InsEmails>();
            InsEmailsUpbyNavigation = new HashSet<InsEmails>();
            InsFareclassCrbyNavigation = new HashSet<InsFareclass>();
            InsFareclassUpbyNavigation = new HashSet<InsFareclass>();
            InsFaretierRangesCrbyNavigation = new HashSet<InsFaretierRanges>();
            InsFaretierRangesUpbyNavigation = new HashSet<InsFaretierRanges>();
            InsFaretiersCrbyNavigation = new HashSet<InsFaretiers>();
            InsFaretiersUpbyNavigation = new HashSet<InsFaretiers>();
            InsJourneysCrbyNavigation = new HashSet<InsJourneys>();
            InsJourneysUpbyNavigation = new HashSet<InsJourneys>();
            InsPartnerKeysCrbyNavigation = new HashSet<InsPartnerKeys>();
            InsPartnerKeysUpbyNavigation = new HashSet<InsPartnerKeys>();
            InsPlansCategoriesCrbyNavigation = new HashSet<InsPlansCategories>();
            InsPlansCategoriesPlansCrbyNavigation = new HashSet<InsPlansCategoriesPlans>();
            InsPlansCategoriesPlansLogCrbyNavigation = new HashSet<InsPlansCategoriesPlansLog>();
            InsPlansCategoriesPlansLogUpbyNavigation = new HashSet<InsPlansCategoriesPlansLog>();
            InsPlansCategoriesPlansUpbyNavigation = new HashSet<InsPlansCategoriesPlans>();
            InsPlansCategoriesUpbyNavigation = new HashSet<InsPlansCategories>();
            InsPlansCrbyNavigation = new HashSet<InsPlans>();
            InsPlansMarketingCrbyNavigation = new HashSet<InsPlansMarketing>();
            InsPlansMarketingOwnCrbyNavigation = new HashSet<InsPlansMarketingOwn>();
            InsPlansMarketingOwnUpbyNavigation = new HashSet<InsPlansMarketingOwn>();
            InsPlansMarketingSubCrbyNavigation = new HashSet<InsPlansMarketingSub>();
            InsPlansMarketingSubUpbyNavigation = new HashSet<InsPlansMarketingSub>();
            InsPlansMarketingUpbyNavigation = new HashSet<InsPlansMarketing>();
            InsPlansProfilesCrbyNavigation = new HashSet<InsPlansProfiles>();
            InsPlansProfilesMarketingCrbyNavigation = new HashSet<InsPlansProfilesMarketing>();
            InsPlansProfilesMarketingUpbyNavigation = new HashSet<InsPlansProfilesMarketing>();
            InsPlansProfilesSubCrbyNavigation = new HashSet<InsPlansProfilesSub>();
            InsPlansProfilesSubUpbyNavigation = new HashSet<InsPlansProfilesSub>();
            InsPlansProfilesUpbyNavigation = new HashSet<InsPlansProfiles>();
            InsPlansProfilesUpsell = new HashSet<InsPlansProfilesUpsell>();
            InsPlansRestrictionsCrbyNavigation = new HashSet<InsPlansRestrictions>();
            InsPlansRestrictionsUpbyNavigation = new HashSet<InsPlansRestrictions>();
            InsPlansRoutes = new HashSet<InsPlansRoutes>();
            InsPlansSerialRangeCrbyNavigation = new HashSet<InsPlansSerialRange>();
            InsPlansSerialRangeUpbyNavigation = new HashSet<InsPlansSerialRange>();
            InsPlansUpbyNavigation = new HashSet<InsPlans>();
            InsPolicySerialRangeCrbyNavigation = new HashSet<InsPolicySerialRange>();
            InsPolicySerialRangeUpbyNavigation = new HashSet<InsPolicySerialRange>();
            InsPolicyUnsentZeus = new HashSet<InsPolicyUnsentZeus>();
            InsRatingsCrbyNavigation = new HashSet<InsRatings>();
            InsRatingsUpbyNavigation = new HashSet<InsRatings>();
            InsRoutesCrbyNavigation = new HashSet<InsRoutes>();
            InsRoutesUpbyNavigation = new HashSet<InsRoutes>();
            InsUnderwritersCrbyNavigation = new HashSet<InsUnderwriters>();
            InsUnderwritersReportsCrbyNavigation = new HashSet<InsUnderwritersReports>();
            InsUnderwritersReportsUpbyNavigation = new HashSet<InsUnderwritersReports>();
            InsUnderwritersUpbyNavigation = new HashSet<InsUnderwriters>();
            InverseCrbyNavigation = new HashSet<SysAdmin>();
            InverseUpbyNavigation = new HashSet<SysAdmin>();
            LookupReferenceCreatedByNavigation = new HashSet<LookupReference>();
            LookupReferenceModifiedByNavigation = new HashSet<LookupReference>();
            OrganizationEmployeeCreatedByNavigation = new HashSet<OrganizationEmployee>();
            OrganizationEmployeeDocumentsCreatedByNavigation = new HashSet<OrganizationEmployeeDocuments>();
            OrganizationEmployeeDocumentsModifiedByNavigation = new HashSet<OrganizationEmployeeDocuments>();
            OrganizationEmployeeModifiedByNavigation = new HashSet<OrganizationEmployee>();
            PartnerIncentiveCreatedByNavigation = new HashSet<PartnerIncentive>();
            PartnerIncentiveModifiedByNavigation = new HashSet<PartnerIncentive>();
            PartnerIncentiveStructureCreatedByNavigation = new HashSet<PartnerIncentiveStructure>();
            PartnerIncentiveStructureModifiedByNavigation = new HashSet<PartnerIncentiveStructure>();
            PartnerOrganizationIncentiveCreatedByNavigation = new HashSet<PartnerOrganizationIncentive>();
            PartnerOrganizationIncentiveModifiedByNavigation = new HashSet<PartnerOrganizationIncentive>();
            PlanSettingCommissionsCreatedByNavigation = new HashSet<PlanSettingCommissions>();
            PlanSettingCommissionsModifiedByNavigation = new HashSet<PlanSettingCommissions>();
            PlanSettingReinsuranceCommissionsCreatedByNavigation = new HashSet<PlanSettingReinsuranceCommissions>();
            PlanSettingReinsuranceCommissionsModifiedByNavigation = new HashSet<PlanSettingReinsuranceCommissions>();
            ReinsuranceCommissionCreatedByNavigation = new HashSet<ReinsuranceCommission>();
            ReinsuranceCommissionFormulaCreatedByNavigation = new HashSet<ReinsuranceCommissionFormula>();
            ReinsuranceCommissionFormulaModifiedByNavigation = new HashSet<ReinsuranceCommissionFormula>();
            ReinsuranceCommissionModifiedByNavigation = new HashSet<ReinsuranceCommission>();
            ReinsuranceCommissionStructureCreatedByNavigation = new HashSet<ReinsuranceCommissionStructure>();
            ReinsuranceCommissionStructureModifiedByNavigation = new HashSet<ReinsuranceCommissionStructure>();
            SysAccessRights = new HashSet<SysAccessRights>();
            SysAdminPasswordHistory = new HashSet<SysAdminPasswordHistory>();
            SysAdminUnlockHistoryCreatedByNavigation = new HashSet<SysAdminUnlockHistory>();
            SysAdminUnlockHistoryUser = new HashSet<SysAdminUnlockHistory>();
            SysAgentsCrbyNavigation = new HashSet<SysAgents>();
            SysAgentsFunctionsWsCrbyNavigation = new HashSet<SysAgentsFunctionsWs>();
            SysAgentsFunctionsWsUpbyNavigation = new HashSet<SysAgentsFunctionsWs>();
            SysAgentsIpaddressesCrbyNavigation = new HashSet<SysAgentsIpaddresses>();
            SysAgentsIpaddressesUpbyNavigation = new HashSet<SysAgentsIpaddresses>();
            SysAgentsPlans = new HashSet<SysAgentsPlans>();
            SysAgentsPseudosCrbyNavigation = new HashSet<SysAgentsPseudos>();
            SysAgentsPseudosUpbyNavigation = new HashSet<SysAgentsPseudos>();
            SysAgentsUpbyNavigation = new HashSet<SysAgents>();
            SysAgentsVirtualsettingsCrbyNavigation = new HashSet<SysAgentsVirtualsettings>();
            SysAgentsVirtualsettingsUpbyNavigation = new HashSet<SysAgentsVirtualsettings>();
            SysAirportsCrbyNavigation = new HashSet<SysAirports>();
            SysAirportsUpbyNavigation = new HashSet<SysAirports>();
            SysCurrencyExchange = new HashSet<SysCurrencyExchange>();
            SysCurrencyExchangeDashboard = new HashSet<SysCurrencyExchangeDashboard>();
            SysForexCrbyNavigation = new HashSet<SysForex>();
            SysForexUpbyNavigation = new HashSet<SysForex>();
            SysFunctionsAccessCrbyNavigation = new HashSet<SysFunctionsAccess>();
            SysFunctionsAccessUpbyNavigation = new HashSet<SysFunctionsAccess>();
            SysFunctionsCrbyNavigation = new HashSet<SysFunctions>();
            SysFunctionsProcess = new HashSet<SysFunctionsProcess>();
            SysFunctionsUpbyNavigation = new HashSet<SysFunctions>();
            SysFunctionsWs = new HashSet<SysFunctionsWs>();
            SysGatewayAccountCrbyNavigation = new HashSet<SysGatewayAccount>();
            SysGatewayAccountUpbyNavigation = new HashSet<SysGatewayAccount>();
            SysOrganizationsCrbyNavigation = new HashSet<SysOrganizations>();
            SysOrganizationsUpbyNavigation = new HashSet<SysOrganizations>();
            SysRolesCrbyNavigation = new HashSet<SysRoles>();
            SysRolesUpbyNavigation = new HashSet<SysRoles>();
            SysUsersCrbyNavigation = new HashSet<SysUsers>();
            SysUsersUpbyNavigation = new HashSet<SysUsers>();
            SysVirtualsetting = new HashSet<SysVirtualsetting>();
            SysWeatherIndexCrbyNavigation = new HashSet<SysWeatherIndex>();
            SysWeatherIndexUpbyNavigation = new HashSet<SysWeatherIndex>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Countrycode { get; set; }
        public int? Adminstatus { get; set; }
        public DateTime? Efffromdate { get; set; }
        public DateTime? Efftodate { get; set; }
        public DateTime Crdt { get; set; }
        public Guid Crby { get; set; }
        public DateTime? Updt { get; set; }
        public Guid? Upby { get; set; }
        public int? Retrycount { get; set; }
        public int? Lockedstatus { get; set; }
        public DateTime? Lockedexpirydt { get; set; }
        public Guid Adminuuid { get; set; }
        public Guid? Useruuid { get; set; }
        public Guid? Orguuid { get; set; }
        public Guid? Roleuuid { get; set; }
        public short StatusId { get; set; }
        public DateTime? PasswordExpiryDate { get; set; }

        public virtual SysAdmin CrbyNavigation { get; set; }
        public virtual SysOrganizations Orguu { get; set; }
        public virtual SysRoles Roleuu { get; set; }
        public virtual SysAdmin UpbyNavigation { get; set; }
        public virtual SysUsers Useruu { get; set; }
        public virtual ICollection<ActionLog> ActionLog { get; set; }
        public virtual ICollection<AuditAdminActions> AuditAdminActionsActionapprovaluseruu { get; set; }
        public virtual ICollection<AuditAdminActions> AuditAdminActionsAdminuu { get; set; }
        public virtual ICollection<AuditAdminEvents> AuditAdminEvents { get; set; }
        public virtual ICollection<Authorisationapi> AuthorisationapiCrbyNavigation { get; set; }
        public virtual ICollection<Authorisationapi> AuthorisationapiUpbyNavigation { get; set; }
        public virtual ICollection<InsBookingclass> InsBookingclassCrbyNavigation { get; set; }
        public virtual ICollection<InsBookingclass> InsBookingclassUpbyNavigation { get; set; }
        public virtual ICollection<InsCampaigns> InsCampaignsCrbyNavigation { get; set; }
        public virtual ICollection<InsCampaigns> InsCampaignsUpbyNavigation { get; set; }
        public virtual ICollection<InsCarrierBookings> InsCarrierBookingsCrbyNavigation { get; set; }
        public virtual ICollection<InsCarrierBookings> InsCarrierBookingsUpbyNavigation { get; set; }
        public virtual ICollection<InsCarrierFares> InsCarrierFaresCrbyNavigation { get; set; }
        public virtual ICollection<InsCarrierFares> InsCarrierFaresUpbyNavigation { get; set; }
        public virtual ICollection<InsCarrierFaretiers> InsCarrierFaretiersCrbyNavigation { get; set; }
        public virtual ICollection<InsCarrierFaretiers> InsCarrierFaretiersUpbyNavigation { get; set; }
        public virtual ICollection<InsCarriers> InsCarriersCrbyNavigation { get; set; }
        public virtual ICollection<InsCarriers> InsCarriersUpbyNavigation { get; set; }
        public virtual ICollection<InsCiTemplates> InsCiTemplatesCrbyNavigation { get; set; }
        public virtual ICollection<InsCiTemplates> InsCiTemplatesUpbyNavigation { get; set; }
        public virtual ICollection<InsEmails> InsEmailsCrbyNavigation { get; set; }
        public virtual ICollection<InsEmails> InsEmailsUpbyNavigation { get; set; }
        public virtual ICollection<InsFareclass> InsFareclassCrbyNavigation { get; set; }
        public virtual ICollection<InsFareclass> InsFareclassUpbyNavigation { get; set; }
        public virtual ICollection<InsFaretierRanges> InsFaretierRangesCrbyNavigation { get; set; }
        public virtual ICollection<InsFaretierRanges> InsFaretierRangesUpbyNavigation { get; set; }
        public virtual ICollection<InsFaretiers> InsFaretiersCrbyNavigation { get; set; }
        public virtual ICollection<InsFaretiers> InsFaretiersUpbyNavigation { get; set; }
        public virtual ICollection<InsJourneys> InsJourneysCrbyNavigation { get; set; }
        public virtual ICollection<InsJourneys> InsJourneysUpbyNavigation { get; set; }
        public virtual ICollection<InsPartnerKeys> InsPartnerKeysCrbyNavigation { get; set; }
        public virtual ICollection<InsPartnerKeys> InsPartnerKeysUpbyNavigation { get; set; }
        public virtual ICollection<InsPlansCategories> InsPlansCategoriesCrbyNavigation { get; set; }
        public virtual ICollection<InsPlansCategoriesPlans> InsPlansCategoriesPlansCrbyNavigation { get; set; }
        public virtual ICollection<InsPlansCategoriesPlansLog> InsPlansCategoriesPlansLogCrbyNavigation { get; set; }
        public virtual ICollection<InsPlansCategoriesPlansLog> InsPlansCategoriesPlansLogUpbyNavigation { get; set; }
        public virtual ICollection<InsPlansCategoriesPlans> InsPlansCategoriesPlansUpbyNavigation { get; set; }
        public virtual ICollection<InsPlansCategories> InsPlansCategoriesUpbyNavigation { get; set; }
        public virtual ICollection<InsPlans> InsPlansCrbyNavigation { get; set; }
        public virtual ICollection<InsPlansMarketing> InsPlansMarketingCrbyNavigation { get; set; }
        public virtual ICollection<InsPlansMarketingOwn> InsPlansMarketingOwnCrbyNavigation { get; set; }
        public virtual ICollection<InsPlansMarketingOwn> InsPlansMarketingOwnUpbyNavigation { get; set; }
        public virtual ICollection<InsPlansMarketingSub> InsPlansMarketingSubCrbyNavigation { get; set; }
        public virtual ICollection<InsPlansMarketingSub> InsPlansMarketingSubUpbyNavigation { get; set; }
        public virtual ICollection<InsPlansMarketing> InsPlansMarketingUpbyNavigation { get; set; }
        public virtual ICollection<InsPlansProfiles> InsPlansProfilesCrbyNavigation { get; set; }
        public virtual ICollection<InsPlansProfilesMarketing> InsPlansProfilesMarketingCrbyNavigation { get; set; }
        public virtual ICollection<InsPlansProfilesMarketing> InsPlansProfilesMarketingUpbyNavigation { get; set; }
        public virtual ICollection<InsPlansProfilesSub> InsPlansProfilesSubCrbyNavigation { get; set; }
        public virtual ICollection<InsPlansProfilesSub> InsPlansProfilesSubUpbyNavigation { get; set; }
        public virtual ICollection<InsPlansProfiles> InsPlansProfilesUpbyNavigation { get; set; }
        public virtual ICollection<InsPlansProfilesUpsell> InsPlansProfilesUpsell { get; set; }
        public virtual ICollection<InsPlansRestrictions> InsPlansRestrictionsCrbyNavigation { get; set; }
        public virtual ICollection<InsPlansRestrictions> InsPlansRestrictionsUpbyNavigation { get; set; }
        public virtual ICollection<InsPlansRoutes> InsPlansRoutes { get; set; }
        public virtual ICollection<InsPlansSerialRange> InsPlansSerialRangeCrbyNavigation { get; set; }
        public virtual ICollection<InsPlansSerialRange> InsPlansSerialRangeUpbyNavigation { get; set; }
        public virtual ICollection<InsPlans> InsPlansUpbyNavigation { get; set; }
        public virtual ICollection<InsPolicySerialRange> InsPolicySerialRangeCrbyNavigation { get; set; }
        public virtual ICollection<InsPolicySerialRange> InsPolicySerialRangeUpbyNavigation { get; set; }
        public virtual ICollection<InsPolicyUnsentZeus> InsPolicyUnsentZeus { get; set; }
        public virtual ICollection<InsRatings> InsRatingsCrbyNavigation { get; set; }
        public virtual ICollection<InsRatings> InsRatingsUpbyNavigation { get; set; }
        public virtual ICollection<InsRoutes> InsRoutesCrbyNavigation { get; set; }
        public virtual ICollection<InsRoutes> InsRoutesUpbyNavigation { get; set; }
        public virtual ICollection<InsUnderwriters> InsUnderwritersCrbyNavigation { get; set; }
        public virtual ICollection<InsUnderwritersReports> InsUnderwritersReportsCrbyNavigation { get; set; }
        public virtual ICollection<InsUnderwritersReports> InsUnderwritersReportsUpbyNavigation { get; set; }
        public virtual ICollection<InsUnderwriters> InsUnderwritersUpbyNavigation { get; set; }
        public virtual ICollection<SysAdmin> InverseCrbyNavigation { get; set; }
        public virtual ICollection<SysAdmin> InverseUpbyNavigation { get; set; }
        public virtual ICollection<LookupReference> LookupReferenceCreatedByNavigation { get; set; }
        public virtual ICollection<LookupReference> LookupReferenceModifiedByNavigation { get; set; }
        public virtual ICollection<OrganizationEmployee> OrganizationEmployeeCreatedByNavigation { get; set; }
        public virtual ICollection<OrganizationEmployeeDocuments> OrganizationEmployeeDocumentsCreatedByNavigation { get; set; }
        public virtual ICollection<OrganizationEmployeeDocuments> OrganizationEmployeeDocumentsModifiedByNavigation { get; set; }
        public virtual ICollection<OrganizationEmployee> OrganizationEmployeeModifiedByNavigation { get; set; }
        public virtual ICollection<PartnerIncentive> PartnerIncentiveCreatedByNavigation { get; set; }
        public virtual ICollection<PartnerIncentive> PartnerIncentiveModifiedByNavigation { get; set; }
        public virtual ICollection<PartnerIncentiveStructure> PartnerIncentiveStructureCreatedByNavigation { get; set; }
        public virtual ICollection<PartnerIncentiveStructure> PartnerIncentiveStructureModifiedByNavigation { get; set; }
        public virtual ICollection<PartnerOrganizationIncentive> PartnerOrganizationIncentiveCreatedByNavigation { get; set; }
        public virtual ICollection<PartnerOrganizationIncentive> PartnerOrganizationIncentiveModifiedByNavigation { get; set; }
        public virtual ICollection<PlanSettingCommissions> PlanSettingCommissionsCreatedByNavigation { get; set; }
        public virtual ICollection<PlanSettingCommissions> PlanSettingCommissionsModifiedByNavigation { get; set; }
        public virtual ICollection<PlanSettingReinsuranceCommissions> PlanSettingReinsuranceCommissionsCreatedByNavigation { get; set; }
        public virtual ICollection<PlanSettingReinsuranceCommissions> PlanSettingReinsuranceCommissionsModifiedByNavigation { get; set; }
        public virtual ICollection<ReinsuranceCommission> ReinsuranceCommissionCreatedByNavigation { get; set; }
        public virtual ICollection<ReinsuranceCommissionFormula> ReinsuranceCommissionFormulaCreatedByNavigation { get; set; }
        public virtual ICollection<ReinsuranceCommissionFormula> ReinsuranceCommissionFormulaModifiedByNavigation { get; set; }
        public virtual ICollection<ReinsuranceCommission> ReinsuranceCommissionModifiedByNavigation { get; set; }
        public virtual ICollection<ReinsuranceCommissionStructure> ReinsuranceCommissionStructureCreatedByNavigation { get; set; }
        public virtual ICollection<ReinsuranceCommissionStructure> ReinsuranceCommissionStructureModifiedByNavigation { get; set; }
        public virtual ICollection<SysAccessRights> SysAccessRights { get; set; }
        public virtual ICollection<SysAdminPasswordHistory> SysAdminPasswordHistory { get; set; }
        public virtual ICollection<SysAdminUnlockHistory> SysAdminUnlockHistoryCreatedByNavigation { get; set; }
        public virtual ICollection<SysAdminUnlockHistory> SysAdminUnlockHistoryUser { get; set; }
        public virtual ICollection<SysAgents> SysAgentsCrbyNavigation { get; set; }
        public virtual ICollection<SysAgentsFunctionsWs> SysAgentsFunctionsWsCrbyNavigation { get; set; }
        public virtual ICollection<SysAgentsFunctionsWs> SysAgentsFunctionsWsUpbyNavigation { get; set; }
        public virtual ICollection<SysAgentsIpaddresses> SysAgentsIpaddressesCrbyNavigation { get; set; }
        public virtual ICollection<SysAgentsIpaddresses> SysAgentsIpaddressesUpbyNavigation { get; set; }
        public virtual ICollection<SysAgentsPlans> SysAgentsPlans { get; set; }
        public virtual ICollection<SysAgentsPseudos> SysAgentsPseudosCrbyNavigation { get; set; }
        public virtual ICollection<SysAgentsPseudos> SysAgentsPseudosUpbyNavigation { get; set; }
        public virtual ICollection<SysAgents> SysAgentsUpbyNavigation { get; set; }
        public virtual ICollection<SysAgentsVirtualsettings> SysAgentsVirtualsettingsCrbyNavigation { get; set; }
        public virtual ICollection<SysAgentsVirtualsettings> SysAgentsVirtualsettingsUpbyNavigation { get; set; }
        public virtual ICollection<SysAirports> SysAirportsCrbyNavigation { get; set; }
        public virtual ICollection<SysAirports> SysAirportsUpbyNavigation { get; set; }
        public virtual ICollection<SysCurrencyExchange> SysCurrencyExchange { get; set; }
        public virtual ICollection<SysCurrencyExchangeDashboard> SysCurrencyExchangeDashboard { get; set; }
        public virtual ICollection<SysForex> SysForexCrbyNavigation { get; set; }
        public virtual ICollection<SysForex> SysForexUpbyNavigation { get; set; }
        public virtual ICollection<SysFunctionsAccess> SysFunctionsAccessCrbyNavigation { get; set; }
        public virtual ICollection<SysFunctionsAccess> SysFunctionsAccessUpbyNavigation { get; set; }
        public virtual ICollection<SysFunctions> SysFunctionsCrbyNavigation { get; set; }
        public virtual ICollection<SysFunctionsProcess> SysFunctionsProcess { get; set; }
        public virtual ICollection<SysFunctions> SysFunctionsUpbyNavigation { get; set; }
        public virtual ICollection<SysFunctionsWs> SysFunctionsWs { get; set; }
        public virtual ICollection<SysGatewayAccount> SysGatewayAccountCrbyNavigation { get; set; }
        public virtual ICollection<SysGatewayAccount> SysGatewayAccountUpbyNavigation { get; set; }
        public virtual ICollection<SysOrganizations> SysOrganizationsCrbyNavigation { get; set; }
        public virtual ICollection<SysOrganizations> SysOrganizationsUpbyNavigation { get; set; }
        public virtual ICollection<SysRoles> SysRolesCrbyNavigation { get; set; }
        public virtual ICollection<SysRoles> SysRolesUpbyNavigation { get; set; }
        public virtual ICollection<SysUsers> SysUsersCrbyNavigation { get; set; }
        public virtual ICollection<SysUsers> SysUsersUpbyNavigation { get; set; }
        public virtual ICollection<SysVirtualsetting> SysVirtualsetting { get; set; }
        public virtual ICollection<SysWeatherIndex> SysWeatherIndexCrbyNavigation { get; set; }
        public virtual ICollection<SysWeatherIndex> SysWeatherIndexUpbyNavigation { get; set; }
    }
}
