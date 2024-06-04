using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanUwQuestionsMap
    {
        public Guid Id { get; set; }
        public Guid PlanUwGroupId { get; set; }
        public Guid PlanUwQuestionId { get; set; }
        public int Weightage { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PlanUwGroup PlanUwGroup { get; set; }
        public virtual PlanUwQuestions PlanUwQuestion { get; set; }
    }
}
