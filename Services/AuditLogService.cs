using AdminService.DBContext;
using AdminService.Models.AuditLogModel;
using AdminService.Models.AuditLogModel.Request;
using AdminService.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Services
{
    public class AuditLogService : BaseService,IAuditLogService
    {
        public AuditLogService(IConfiguration configuration, IWebHostEnvironment env) :  base(configuration, "", env)
        { }
        public async Task<IEnumerable<AuditLogResponseModel>> GetAuditLog(AuditLogRequestModel lookupModel)
        {
            try
            {
                using (pgzeusContext context = new pgzeusContext(_options.Options))
                {
                    var auditLog = await context.ActionLog
                        .Where(item => 
                        (string.IsNullOrEmpty(lookupModel.TableName) || item.ReferenceTable.Contains(lookupModel.TableName))
                        && (lookupModel.UserID == null || lookupModel.UserID == Guid.Empty || item.CreatedUser == lookupModel.UserID)
                        && item.CreatedDate >= lookupModel.FromDate 
                        && item.CreatedDate < lookupModel.ToDate.AddDays(1)).Include(i => i.CreatedUserNavigation).ToListAsync();
                    var returnValue = auditLog.Select(item => new AuditLogResponseModel
                    {
                        Id = item.Id,
                        ActionType = item.ActionType,
                        ColumnName = item.ColumnName,
                        ColumnNewValue = item.ColumnNewValue,
                        ColumnOldValue = item.ColumnOldValue,
                        CreatedDate = item.CreatedDate,
                        RecordValue = item.RecordValue,
                        ReferenceId = item.ReferenceId,
                        ReferenceTable = item.ReferenceTable,
                        CreatedUserName = item.CreatedUserNavigation?.Fullname,
                        CreatedUser = item.CreatedUser,
                        TotalRecords = auditLog.Count,
                        TotalPages = (int)Math.Ceiling((decimal)auditLog.Count / (decimal)lookupModel.PageSize)
                    }).Skip(lookupModel.PageSize * (lookupModel.PageIndex - 1)).Take(lookupModel.PageSize);
                    
                    return returnValue;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
