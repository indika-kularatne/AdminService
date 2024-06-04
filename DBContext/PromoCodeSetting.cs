using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PromoCodeSetting
    {
        public PromoCodeSetting()
        {
            PlanPromoCodeMap = new HashSet<PlanPromoCodeMap>();
        }

        public Guid Id { get; set; }
        public string PromoCode { get; set; }
        public short PromoType { get; set; }
        public decimal PromoValue { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<PlanPromoCodeMap> PlanPromoCodeMap { get; set; }
    }
}
