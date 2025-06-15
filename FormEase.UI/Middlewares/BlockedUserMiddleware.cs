using FormEase.Core.Models.Identity;
using Microsoft.AspNetCore.Identity;

namespace FormEase.UI.Middlewares
{
	public class BlockedUserMiddleware
	{
		private readonly RequestDelegate _next;

		public BlockedUserMiddleware(RequestDelegate next) => _next = next;

		public async Task InvokeAsync(
			HttpContext context,
			UserManager<ApplicationUser> userManager,
			SignInManager<ApplicationUser> signInManager)
		{
			if (context.User.Identity?.IsAuthenticated == true)
			{
				var user = await userManager.GetUserAsync(context.User);
				if (user is { IsBlocked: true })
				{
					await signInManager.SignOutAsync();
					context.Response.Redirect("/Account/Login");
					return;
				}
			}
			await _next(context);
		}
	}
}
