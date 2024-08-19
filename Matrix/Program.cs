using BLL.INTERFACES;
using BLL.REPOSITORY;
using DAL.CONTEXT;
using DAL.ENTITIES;
using Matrix.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Matrix
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

			builder.Services.AddDbContext<ApplicationDBcontext>
			(options => options.UseSqlServer(builder.Configuration.GetConnectionString("constr")), ServiceLifetime.Scoped);

			builder.Services.AddScoped<IPRODUCT, ProdRepo>();
			builder.Services.AddScoped<ICART, CartRepo>();
			builder.Services.AddScoped<IAccount, AccountRepo>();
			builder.Services.AddScoped<IEMP, EmpRepo>();
			builder.Services.AddAutoMapper(x => x.AddProfile(new MappingProfile()));

			builder.Services.AddIdentity<ApplicationUser, IdentityRole>(config =>
			{
				config.Password.RequiredUniqueChars = 2; //minimum number uniq is 2
				config.Password.RequireDigit = true; //default
				config.Password.RequireNonAlphanumeric = true; //default
				config.Password.RequiredLength = 5;
				config.Password.RequireUppercase = true;
				config.Password.RequireLowercase = true;

				config.User.RequireUniqueEmail = true;

				config.Lockout.MaxFailedAccessAttempts = 3;
				config.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromDays(10);
				config.Lockout.AllowedForNewUsers = true;


			}).AddEntityFrameworkStores<ApplicationDBcontext>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			app.UseAuthentication();
			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}