using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanPromoCodeMap
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public string CurrencyCode { get; set; }
        public Guid PromoCodeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Quantity { get; set; }
        public bool IsLimited { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid PlanVariableId { get; set; }
        public int UsedQuantity { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual PlanSetting Plan { get; set; }
        public virtual PlanVariable PlanVariable { get; set; }
        public virtual PromoCodeSetting PromoCode { get; set; }
    }
}
