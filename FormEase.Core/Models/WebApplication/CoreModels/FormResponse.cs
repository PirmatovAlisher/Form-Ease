using FormEase.Core.Models.Identity;

namespace FormEase.Core.Models.WebApplication.CoreModels
{
    public class FormResponse
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public Guid TemplateId { get; set; }
        public Template Template { get; set; }
        public string RespondentId { get; set; }
        public ApplicationUser Respondent { get; set; }
        public List<Answer> Answers { get; set; } = new();
    }
}
