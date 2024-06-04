using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyHolderEndorsement
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public DateTime ActionDate { get; set; }
        public string ActionSection { get; set; }
        public string ActionTask { get; set; }

        public virtual Policy Policy { get; set; }
    }
}
