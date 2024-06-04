using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyUw
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public string InputRequestUw { get; set; }
        public string OutputResponseUw { get; set; }
        public string UwAnswer { get; set; }
        public Guid CreatedBy { get; set; }
        public TimeSpan CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual Policy Policy { get; set; }
    }
}
