using GymBusiness.Abstractions;
using GymBusiness.Services;
using GymDomain;
using GymDomain.Abstractions;
using GymDomain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GymWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            //builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services
                .AddScoped<IMemberRepository, MemberRepository>()
                .AddScoped<ISubscriptionRepository, SubscriptionRepository>()
                .AddScoped<IMemberSubscriptionRepository, MemberSubscriptionRepository>();

            builder.Services
                .AddScoped<IMemberService, MemberService>()
                .AddScoped<ISubscriptionService, SubscriptionService>()
                .AddScoped<IMemberSubscriptionService, MemberSubscriptionService>();

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //app.UseAuthentication();
            //app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Member}/{action=ListMembers}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}