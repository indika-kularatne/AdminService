using System;

namespace AdminService.Models.PermissionModel.Request
{
    public class UpdateRolePermissionModel
    {
        public Guid Id { get; set; }
        public string Permission { get; set; }
    }
}
