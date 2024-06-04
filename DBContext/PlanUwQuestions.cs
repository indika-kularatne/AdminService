using System;
using System.Collections.Generic;

namespace AdminService.DBContext
{
    public partial class PlanUwQuestions
    {
        public PlanUwQuestions()
        {
            PlanUwAnswersNextQuestion = new HashSet<PlanUwAnswers>();
            PlanUwAnswersPlanUwQuestion = new HashSet<PlanUwAnswers>();
            PlanUwQuestionsMap = new HashSet<PlanUwQuestionsMap>();
            PlanUwQuestionsTranslation = new HashSet<PlanUwQuestionsTranslation>();
        }

        public Guid Id { get; set; }
        public string QuestionCode { get; set; }
        public string QuestionDesc { get; set; }
        public short StatusId { get; set; }
        public int Weightage { get; set; }
        public string ComparisonType { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string DefaultAnswer { get; set; }

        public virtual ICollection<PlanUwAnswers> PlanUwAnswersNextQuestion { get; set; }
        public virtual ICollection<PlanUwAnswers> PlanUwAnswersPlanUwQuestion { get; set; }
        public virtual ICollection<PlanUwQuestionsMap> PlanUwQuestionsMap { get; set; }
        public virtual ICollection<PlanUwQuestionsTranslation> PlanUwQuestionsTranslation { get; set; }
    }
}
