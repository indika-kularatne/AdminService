using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanBenefitSupportingDocuments
    {
        public PlanBenefitSupportingDocuments()
        {
            PlanBenefitSupportingDocumentsMap = new HashSet<PlanBenefitSupportingDocumentsMap>();
            PlanBenefitSupportingDocumentsTranslation = new HashSet<PlanBenefitSupportingDocumentsTranslation>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public bool IsRequired { get; set; }
        public string Description { get; set; }
        public short StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<PlanBenefitSupportingDocumentsMap> PlanBenefitSupportingDocumentsMap { get; set; }
        public virtual ICollection<PlanBenefitSupportingDocumentsTranslation> PlanBenefitSupportingDocumentsTranslation { get; set; }
    }
}
