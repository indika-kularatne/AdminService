using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class Action
    {
        public Guid Id { get; set; }
        public string ActionName { get; set; }
    }
}
