using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitSupportingDocumentsTranslation
    {
        public Guid Id { get; set; }
        public Guid PlanBenefitSupportingDocumentsId { get; set; }
        public string Locale { get; set; }
        public string Description { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanBenefitSupportingDocuments PlanBenefitSupportingDocuments { get; set; }
    }
}
