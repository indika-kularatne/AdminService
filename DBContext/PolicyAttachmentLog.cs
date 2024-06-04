using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyAttachmentLog
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public short ItemType { get; set; }
        public string FileName { get; set; }
        public string ItemContent { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }

        public virtual Policy Policy { get; set; }
    }
}
