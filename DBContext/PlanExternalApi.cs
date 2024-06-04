using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanExternalApi
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public short AuthorizationType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string RequestBody { get; set; }
        public string PolicyReferenceColumn { get; set; }
        public short StatusId { get; set; }
        public string RequestUrl { get; set; }
        public bool IsBilling { get; set; }
        public bool IsFirstOnly { get; set; }
        public bool IsPriority { get; set; }
        public short? Type { get; set; }

        public virtual PlanSetting Plan { get; set; }
    }
}
