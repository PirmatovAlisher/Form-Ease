using FormEase.Core.Models.WebApplication.AccessControlModels;
using FormEase.Core.Models.WebApplication.CoreModels;
using FormEase.Core.Models.WebApplication.PermissionModels;
using Microsoft.AspNetCore.Identity;

namespace FormEase.Core.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsBlocked { get; set; } = false;

        public List<Template> CreatedTemplates { get; set; } = new();
        public List<FormResponse> FormResponses { get; set; } = new();
        public List<UserTemplateAccess> AllowedTemplates { get; set; } = new();
        public List<Comment> Comments { get; set; } = new();
        public List<Like> Likes { get; set; } = new();
    }
}
