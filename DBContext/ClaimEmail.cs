using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ClaimEmail
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public short StatusId { get; set; }
        public Guid? ReferenceId { get; set; }
    }
}
