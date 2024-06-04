using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Models
{
    public class ResponseModel
    {
        public AdminModel Admin { get; set; }

        public int ErrorCode { get; set; }

        public string ErrorMessage { get; set; }
    }
}
