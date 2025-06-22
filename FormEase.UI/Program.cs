using FormEase.Core.Models.Identity;
using FormEase.Infrastructure.PostgreSQL.Data;
using FormEase.Infrastructure.PostgreSQL.Extensions;
using FormEase.Services.Extensions;
using FormEase.UI.Components;
using FormEase.UI.Components.Account;
using FormEase.UI.Extensions;
using FormEase.UI.Middlewares;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Radzen;

namespace FormEase.UI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRadzenComponents();
			builder.Services.AddRazorComponents()
				.AddInteractiveServerComponents();

			builder.Services.LoadInfrastructureLayerExtensions();
			builder.Services.LoadServiceLayerExtensions();
			#region Database configuration

			var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("DefaultConnection not set");
			if (!builder.Environment.IsDevelopment())
			{
				connectionString = ConnectionStringHandler.GetRenderConnectionString();
			}

			builder.Services.AddDbContext<ApplicationDbContext>(options =>
				options.UseNpgsql(connectionString, x => x.MigrationsAssembly("FormEase.Infrastructure.PostgreSQL")));
			builder.Services.AddDatabaseDeveloperPageExceptionFilter();
			#endregion

			builder.Services.AddHttpClient();

			#region Identity Services
			builder.Services.AddCascadingAuthenticationState();
			builder.Services.AddScoped<IdentityUserAccessor>();
			builder.Services.AddScoped<IdentityRedirectManager>();
			builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

			builder.Services.AddAuthentication(options =>
				{
					options.DefaultScheme = IdentityConstants.ApplicationScheme;
					options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
				})
				.AddIdentityCookies();

			builder.Services.AddAuthorization();

			builder.Services.ConfigureApplicationCookie(options =>
			{
				options.LoginPath = "/Account/Login";
				options.AccessDeniedPath = "/Account/AccessDenied";
				options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
				options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Force HTTPS cookies
				options.Cookie.SameSite = SameSiteMode.Lax; // Allow top-level navigation

			});


			builder.Services.AddIdentityCore<ApplicationUser>(options =>
			options.SignIn.RequireConfirmedAccount = false)
				.AddRoles<IdentityRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddSignInManager()
				.AddDefaultTokenProviders();
			#endregion

			builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

			var app = builder.Build();

			// Required for deployment on Render
			app.UseForwardedHeaders(new ForwardedHeadersOptions
			{
				ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
			});

			using (var scope = app.Services.CreateScope())
			{
				var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
				db.Database.Migrate();
			}

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseMigrationsEndPoint();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseMiddleware<BlockedUserMiddleware>();

			app.UseAntiforgery();

			app.MapRazorComponents<App>()
				.AddInteractiveServerRenderMode();

			// Add additional endpoints required by the Identity /Account Razor components.
			app.MapAdditionalIdentityEndpoints();

			app.Run();
		}
	}
}
