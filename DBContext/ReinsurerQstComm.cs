using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class ReinsurerQstComm
    {
        public Guid Id { get; set; }
        public Guid QstId { get; set; }
        public Guid PlanId { get; set; }
        public string ChannelCode { get; set; }
        public decimal RiCommAmount { get; set; }
        public decimal RiCommPercentage { get; set; }
        public short RiCommOn { get; set; }
        public short? StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual PlanSetting Plan { get; set; }
        public virtual ReinsurerQstreaties Qst { get; set; }
    }
}
