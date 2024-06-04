using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class GenericApplicationLog
    {
        public Guid Id { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationModule { get; set; }
        public string LogMessage { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsError { get; set; }
    }
}
