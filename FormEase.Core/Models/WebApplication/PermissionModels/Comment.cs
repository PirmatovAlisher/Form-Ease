using FormEase.Core.Models.Identity;
using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Models.WebApplication.PermissionModels
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Guid TemplateId { get; set; }
        public Template Template { get; set; }
        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
    }
}
