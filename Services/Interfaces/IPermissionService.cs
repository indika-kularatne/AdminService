using AdminService.Models.PermissionModel.Request;
using AdminService.Models.PermissionModel.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdminService.Services.Interfaces
{
    public interface IPermissionService
    {
        Task<bool> CreateAsync(IList<CreatePermissionModel> model);
        Task<IList<RolePermissionResponseModel>> GetListPermissionByRoleIdAsync(Guid roleId);
        Task<bool> UpdateRolePermissionsAsync(IList<UpdateRolePermissionModel> models);
        Task<bool> DeleteRolePermissionAsync(Guid id);
    }
}
