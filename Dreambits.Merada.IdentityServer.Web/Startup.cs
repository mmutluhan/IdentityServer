using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DreamBits.Merada.IdentityServer.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
         
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AuthorizationDbContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddConfigurationStore(option =>
                {
                    option.DefaultSchema = "merada_auth_db";
                    option.ConfigureDbContext = builder => builder.UseNpgsql(
                            Configuration.GetConnectionString("DefaultConnection"), options =>
                            {
                                options.UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery);
                                options.MigrationsAssembly(typeof(Startup).Assembly.FullName);
                            })
                        .EnableSensitiveDataLogging()
                        .LogTo(Console.WriteLine, LogLevel.Information);
                    ;
                })
                .AddOperationalStore(option =>
                {
                    option.DefaultSchema = "merada_auth_db";
                    option.ConfigureDbContext = builder => builder.UseNpgsql(
                            Configuration.GetConnectionString("DefaultConnection"),
                            options =>
                            {
                                options.UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery);
                                options.MigrationsAssembly(typeof(Startup).Assembly.FullName);
                            })
                        .EnableSensitiveDataLogging()
                        .LogTo(Console.WriteLine, LogLevel.Information);
                    ;
                });


            services.AddControllersWithViews();
        }
         
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); 
            }

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AuthorizationDbContext>();
                DatabaseInitializer.Initialize(app, context);
            }
            app.UseStaticFiles();

            app.UseIdentityServer();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
