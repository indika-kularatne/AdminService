using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanUwAnswers
    {
        public Guid Id { get; set; }
        public Guid PlanUwQuestionId { get; set; }
        public string AnswerCode { get; set; }
        public string AnswerDesc { get; set; }
        public string AnswerValue { get; set; }
        public string AnswerTranslation { get; set; }
        public decimal Weightage { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Guid? NextQuestionId { get; set; }

        public virtual PlanUwQuestions NextQuestion { get; set; }
        public virtual PlanUwQuestions PlanUwQuestion { get; set; }
    }
}
