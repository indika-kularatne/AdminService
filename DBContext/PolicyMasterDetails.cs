using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PolicyMasterDetails
    {
        public Guid Id { get; set; }
        public Guid PolicyId { get; set; }
        public Guid PlanId { get; set; }
        public Guid EntityId { get; set; }
        public short Mininsuredperson { get; set; }
        public short Maxinsuredperson { get; set; }
        public string Planstructure { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Planpermutation { get; set; }

        public virtual Entities Entity { get; set; }
        public virtual PlanSetting Plan { get; set; }
        public virtual Policy Policy { get; set; }
    }
}
