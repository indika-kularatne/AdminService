using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class OrganizationEmployeeDocuments
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public string FileContentBase64 { get; set; }
        public string FileName { get; set; }
        public string DocumentCode { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual SysAdmin CreatedByNavigation { get; set; }
        public virtual SysAdmin ModifiedByNavigation { get; set; }
        public virtual SysOrganizations Organization { get; set; }
    }
}
