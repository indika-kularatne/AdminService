using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class SysPermission
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Permission { get; set; }
    }
}
