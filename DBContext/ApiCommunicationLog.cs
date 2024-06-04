using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ApiCommunicationLog
    {
        public Guid Id { get; set; }
        public string RequestJson { get; set; }
        public string ResponseJson { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ErrorException { get; set; }
        public Guid PolicyId { get; set; }
        public string ReferenceCode { get; set; }
        public string PostUrl { get; set; }

        public virtual Policy Policy { get; set; }
    }
}
