using System;

namespace AdminService.Models.PermissionModel.Response
{
    public class RolePermissionResponseModel
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid MenuId { get; set; }
        public string Permission { get; set; }
        public bool IsGranted { get; set; }
    }
}
