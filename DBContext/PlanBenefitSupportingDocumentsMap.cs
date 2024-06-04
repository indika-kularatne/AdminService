using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitSupportingDocumentsMap
    {
        public Guid Id { get; set; }
        public Guid PlanBenefitId { get; set; }
        public Guid PlanBenefitSupportingDocumentsId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual PlanBenefit PlanBenefit { get; set; }
        public virtual PlanBenefitSupportingDocuments PlanBenefitSupportingDocuments { get; set; }
    }
}
