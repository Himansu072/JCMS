using JCMS.Model.Entities;
using JCMS.Repository.Context;
using JCMS.Repository.Repositories.Interfaces;
using JCMS.Repository.Repositories.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JCMS.Repository.Container
{
    public static class CustomContainer
    {

        public static void AddCustomContainer(this IServiceCollection services, IConfiguration configuration)
        {
            IConnectionFactory connectionFactory = new ConnectionFactory(configuration.GetConnectionString("DBConnection"));
            services.AddSingleton<IConnectionFactory>(connectionFactory);
            services.AddDbContext<ApplicationDbContext>(options =>
                  options.UseSqlServer(configuration.GetConnectionString("DBConnection")));
            services.AddDbContext<CMSDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DBConnection"));
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
                 );
            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();
            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, AppClaimsPrincipalFactory>();
            services.AddScoped<SignInManager<ApplicationUser>, AuditableSignInManager<ApplicationUser>>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IMainpageRepository, MainpageRepository>();
            services.AddScoped<IUploadRepository, UploadRepository>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            
        }
    }
}
