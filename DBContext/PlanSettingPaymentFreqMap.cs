using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanSettingPaymentFreqMap
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public Guid PlanPayFreqId { get; set; }
        public string PayFreqTerm { get; set; }
        public short PayFreqValue { get; set; }
        public decimal PayFactorValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public short? StatusId { get; set; }
        public short? FirstPaymentAdvance { get; set; }
        public bool? IsApplyToFormula { get; set; }

        public virtual PlanSetting Plan { get; set; }
        public virtual PlanPaymentFreq PlanPayFreq { get; set; }
    }
}
