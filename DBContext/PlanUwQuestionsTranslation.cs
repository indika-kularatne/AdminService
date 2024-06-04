using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanUwQuestionsTranslation
    {
        public Guid Id { get; set; }
        public Guid PlanUwQuestionsId { get; set; }
        public string Locale { get; set; }
        public string Question { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual PlanUwQuestions PlanUwQuestions { get; set; }
    }
}
