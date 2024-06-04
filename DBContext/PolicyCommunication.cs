using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyCommunication
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public string Content { get; set; }
        public short ContentType { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ContentHeader { get; set; }

        public virtual Policy Policy { get; set; }
    }
}
