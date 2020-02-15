using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UAS_20170140120_DeckyAprianto.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UAS_20170140120_DeckyAprianto.Models;
using Microsoft.AspNetCore.Identity.UI.Services;


namespace UAS_20170140120_DeckyAprianto
{
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

            services.AddDbContext<Models.UASPAWContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("Default")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddIdentity<IdentityUser, IdentityRole>().AddDefaultUI()
              .AddEntityFrameworkStores<UASPAWContext>().AddDefaultTokenProviders();

            services.AddAuthorization(options => {
                options.AddPolicy("readonlypolicy",
                    builder => builder.RequireRole("Admin", "Resepsionis", "Cleaning Service", "Kitchen"));
                options.AddPolicy("writepolicy",
                    builder => builder.RequireRole("Admin", "Kitchen"));
                options.AddPolicy("editpolicy",
                    builder => builder.RequireRole("Admin", "Kitchen"));
                options.AddPolicy("deletepolicy",
                builder => builder.RequireRole("Admin", "Kitchen"));
            });

            services.AddScoped<Reservasi>();
            services.AddScoped<RoomService>();


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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
