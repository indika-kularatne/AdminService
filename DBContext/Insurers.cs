using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Insurers
    {
        public Insurers()
        {
            InsurersExpenseGroups = new HashSet<InsurersExpenseGroups>();
            ReinsurerBca = new HashSet<ReinsurerBca>();
        }

        public Guid Id { get; set; }
        public string InsurerCode { get; set; }
        public string InsurerName { get; set; }
        public string CountryCode { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<InsurersExpenseGroups> InsurersExpenseGroups { get; set; }
        public virtual ICollection<ReinsurerBca> ReinsurerBca { get; set; }
    }
}
