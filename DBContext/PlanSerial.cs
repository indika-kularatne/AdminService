using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSerial
    {
        public PlanSerial()
        {
            PlanSetting = new HashSet<PlanSetting>();
            PlanSettingSerial = new HashSet<PlanSettingSerial>();
        }

        public Guid Id { get; set; }
        public string PlanSerialName { get; set; }
        public string PlanPrefix { get; set; }
        public string PlanPostfix { get; set; }
        public string Format { get; set; }
        public int StartNumber { get; set; }
        public int EndNumber { get; set; }
        public int NextNumber { get; set; }
        public short? RandomNumberId { get; set; }
        public short StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual PlanRandomNumber RandomNumber { get; set; }
        public virtual SettingStatus Status { get; set; }
        public virtual ICollection<PlanSetting> PlanSetting { get; set; }
        public virtual ICollection<PlanSettingSerial> PlanSettingSerial { get; set; }
    }
}
