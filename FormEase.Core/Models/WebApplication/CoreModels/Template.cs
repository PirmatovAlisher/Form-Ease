using FormEase.Core.Models.Identity;
using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Core.Models.WebApplication.MetadataModels;
using FormEase.Core.Models.WebApplication.PermissionModels;

namespace FormEase.Core.Models.WebApplication.CoreModels
{
    public class Template
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsPublic { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string CreatorId { get; set; }
        public ApplicationUser Creator { get; set; }
        public Guid TopicId { get; set; }
        public Topic Topic { get; set; }
        public List<Question> Questions { get; set; } = new();
        public List<FormResponse> FormResponses { get; set; } = new();
        public List<Comment> Comments { get; set; } = new();
        public List<Like> Likes { get; set; } = new();
        public List<TemplateTag> TemplateTags { get; set; } = new();
        public List<UserTemplateAccess> AllowedUsers { get; set; } = new();
    }
}
