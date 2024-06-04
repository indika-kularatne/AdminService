using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsurersExpenseGroups
    {
        public InsurersExpenseGroups()
        {
            InsurersExpenses = new HashSet<InsurersExpenses>();
        }

        public Guid Id { get; set; }
        public Guid InsurerId { get; set; }
        public string ExpensegroupCode { get; set; }
        public string ExpensegroupName { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual Insurers Insurer { get; set; }
        public virtual ICollection<InsurersExpenses> InsurersExpenses { get; set; }
    }
}
