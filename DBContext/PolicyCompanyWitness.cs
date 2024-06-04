using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyCompanyWitness
    {
        public Guid Id { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string IdentityValue { get; set; }
        public short? IdentityType { get; set; }
        public Guid? InsurerId { get; set; }
        public string FullName { get; set; }

        public virtual InsUnderwriters Insurer { get; set; }
    }
}
