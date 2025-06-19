using FormEase.Core.Models.Identity;
using FormEase.Core.Models.WebApplication.CoreModels;

namespace FormEase.Core.Models.WebApplication.AccessControlModels
{
    public class UserTemplateAccess
    {
        public Guid Id { get; set; }

        public Guid TemplateId { get; set; }
        public Template Template { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
