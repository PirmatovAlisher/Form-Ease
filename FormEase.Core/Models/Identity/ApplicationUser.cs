using Microsoft.AspNetCore.Identity;

namespace FormEase.Core.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsBlocked { get; set; } = false;
	}
}
