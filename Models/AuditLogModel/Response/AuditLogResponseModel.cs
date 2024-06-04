using AdminService.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Models.AuditLogModel
{
    public class AuditLogResponseModel
    {
        public Guid Id { get; set; }
        public Guid? ReferenceId { get; set; }
        public string ReferenceTable { get; set; }
        public string ActionType { get; set; }
        public string ColumnName { get; set; }
        public string ColumnOldValue { get; set; }
        public string ColumnNewValue { get; set; }
        public string RecordValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedUser { get; set; }
        public string CreatedUserName { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
    }
}
