using FormEase.Core.Models.Identity;
using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Models.WebApplication.PermissionModels
{
    public class Like
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Guid TemplateId { get; set; }
        public Template Template { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
