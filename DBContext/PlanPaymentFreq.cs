using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanPaymentFreq
    {
        public PlanPaymentFreq()
        {
            PlanSettingPaymentFreqMap = new HashSet<PlanSettingPaymentFreqMap>();
        }

        public Guid Id { get; set; }
        public string PayFreqDescription { get; set; }
        public string PayFreqTerm { get; set; }
        public short Statusid { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int FreqValue { get; set; }

        public virtual ICollection<PlanSettingPaymentFreqMap> PlanSettingPaymentFreqMap { get; set; }
    }
}
