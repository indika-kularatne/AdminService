using AdminService.Models.AuditLogModel;
using AdminService.Models.AuditLogModel.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Services.Interfaces
{
    public interface IAuditLogService
    {
       Task<IEnumerable<AuditLogResponseModel>>  GetAuditLog(AuditLogRequestModel lookupModel);
    }
}
