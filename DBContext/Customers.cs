using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Customers
    {
        public Customers()
        {
            CustomerDevices = new HashSet<CustomerDevices>();
            CustomerRisks = new HashSet<CustomerRisks>();
        }

        public Guid Id { get; set; }
        public int? RsUserId { get; set; }
        public Guid? EntityId { get; set; }
        public string FullName { get; set; }
        public string Nric { get; set; }
        public string Passport { get; set; }
        public string OtherId { get; set; }
        public DateTime Dob { get; set; }
        public string Nationality { get; set; }
        public string NationalityCode { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string MaritalStatus { get; set; }
        public string Race { get; set; }
        public string Religion { get; set; }
        public bool? IsMuslim { get; set; }
        public bool? IsFirstTimeBuyer { get; set; }
        public bool? AgreePdpa { get; set; }
        public bool? AgreeMarketing { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsLocked { get; set; }
        public bool? EmailVerified { get; set; }
        public bool? MobileVerified { get; set; }
        public string Addresses { get; set; }
        public string Actions { get; set; }
        public string Activations { get; set; }
        public string BankingAccounts { get; set; }
        public string Employments { get; set; }
        public string Policies { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? NextLoginBefore { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string RiskProfile { get; set; }
        public string PolicyNos { get; set; }
        public Guid? OwnerCustomerid { get; set; }
        public string RelationshipToOwner { get; set; }
        public string Occupation { get; set; }
        public string IncomeRange { get; set; }
        public string EmployerName { get; set; }
        public string MobileCountryCode { get; set; }

        public virtual Entities Entity { get; set; }
        public virtual CustomerCredentials CustomerCredentials { get; set; }
        public virtual ICollection<CustomerDevices> CustomerDevices { get; set; }
        public virtual ICollection<CustomerRisks> CustomerRisks { get; set; }
    }
}
