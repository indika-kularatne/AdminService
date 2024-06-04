using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyNomineeMessage
    {
        public Guid Id { get; set; }
        public string MessageName { get; set; }
        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
    }
}
