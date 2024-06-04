using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class InsurersExpenses
    {
        public Guid Id { get; set; }
        public Guid? ExpensegroupId { get; set; }
        public string ExpenseCode { get; set; }
        public string ExpenseName { get; set; }
        public string ExpenseBasis { get; set; }
        public decimal? ExpenseAmount { get; set; }
        public decimal? ExpensePercentage { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual InsurersExpenseGroups Expensegroup { get; set; }
    }
}
