namespace Abraks.Web
{
    using Abraks.Data;
    using Abraks.Models;
    using Areas.Identity.Services;
    using AutoMapper;
    using Common.Constants;
    using Extensions;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Services.Admin;
    using Services.Admin.Interfaces;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<AbraksContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString(StringConstants.ContextConnectionString)));

            services.AddIdentity<User, IdentityRole>()
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<AbraksContext>();
            
            services.AddAuthentication()
                .AddFacebook(options =>
                {
                    options.AppId = this.Configuration.GetSection("ExternalAuthentication:FacebookApi:AppId").Value;
                    options.AppSecret = this.Configuration.GetSection("ExternalAuthentication:FacebookApi:AppSecret").Value;
                   options.CallbackPath = "/Index";
                });

            services.Configure<IdentityOptions>(options =>
            {
             //  options.SignIn.RequireConfirmedEmail = true;
            });

            //TODO Find why Emails not sending
            //services.AddSingleton<IEmailSender, SendGridEmailSender>();
            //services.Configure<SendGridOptions>(this.Configuration.GetSection(StringConstants.SendGridEmailSettings));

            services.AddAutoMapper();

            RegisterServiceLayer(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler(StringConstants.ExceptionHandlerPath);
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.SeedDatabase();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "area",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void RegisterServiceLayer(IServiceCollection services)
        {
            services.AddScoped<IAdminEventsService, AdminEventsService>();
            services.AddScoped<IAdminRewardService, AdminRewardsService>();
        }
    }
}
