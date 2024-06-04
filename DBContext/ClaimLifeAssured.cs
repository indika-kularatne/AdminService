using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimLifeAssured
    {
        public Guid Id { get; set; }
        public Guid ClaimId { get; set; }
        public string EmployeeDependentName { get; set; }
        public string EmployeeDependentRegNo { get; set; }
        public string InsuranceCoverage { get; set; }
        public string InsuranceComName { get; set; }
        public string PolicyNo { get; set; }
        public string BenefitAmount { get; set; }
    }
}
