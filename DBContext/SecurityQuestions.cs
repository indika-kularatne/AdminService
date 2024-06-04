using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SecurityQuestions
    {
        public Guid Id { get; set; }
        public string SecurityQuestion { get; set; }
    }
}
