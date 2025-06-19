namespace FormEase.Core.Models.WebApplication.CoreModels
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Order { get; set; } // Display order
        public bool IsRequired { get; set; } = false;
        public bool ShowInResponseList { get; set; } = false;
        public QuestionType Type { get; set; } = QuestionType.Text;


        public Guid TemplateId { get; set; }
        public Template Template { get; set; }
        public List<Answer> Answers { get; set; } = new();
        public List<QuestionOption> Options { get; set; } = new(); // For choice-based questions
    }
}
