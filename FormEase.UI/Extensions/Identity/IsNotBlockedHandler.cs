using FormEase.Core.Models.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace FormEase.UI.Extensions.Identity
{
	public class IsNotBlockedHandler : AuthorizationHandler<IsNotBlockedRequirement>
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IServiceScopeFactory _serviceScopeFactory;

		public IsNotBlockedHandler(IServiceProvider serviceProvider, IServiceScopeFactory serviceScopeFactory)
		{
			_serviceProvider = serviceProvider;
			_serviceScopeFactory = serviceScopeFactory;
		}

		protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, IsNotBlockedRequirement requirement)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
				var signInManager = scope.ServiceProvider.GetRequiredService<SignInManager<ApplicationUser>>();
				var httpContextAccessor = scope.ServiceProvider.GetRequiredService<IHttpContextAccessor>();
				var httpContext = httpContextAccessor.HttpContext;


				if (httpContext == null)
				{
					context.Fail();
					return;
				}

				if (context.User.Identity?.IsAuthenticated == true)
				{
					var user = userManager.GetUserAsync(context.User).Result;

					if (user is { IsBlocked: false })
					{
						context.Succeed(requirement);
					}
					else if (user is { IsBlocked: true })
					{
						await signInManager.SignOutAsync();
						httpContext.Response.Redirect("/Account/Login");

						context.Fail();
					}
				}
				else
				{
					context.Fail();
				}
			}
		}
	}
}
