using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using K_Smart_IMS.Models;

namespace K_Smart_IMS
{
     public class Startup
        {
            public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public IConfiguration Configuration { get; }

            // Use this method to add services to the container.
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddRouting(options => options.LowercaseUrls = true);

                services.AddMemoryCache();
                services.AddSession();

                services.AddControllersWithViews().AddNewtonsoftJson();

                 services.AddDbContext<InventoryContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("InventoryContext")));

                // add this
                services.AddIdentity<User, IdentityRole>(options =>
                {
                    options.Password.RequiredLength = 6;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = false;
                }).AddEntityFrameworkStores<InventoryContext>()
                  .AddDefaultTokenProviders();
            }

            // Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, InventoryContext db)
            {
                app.UseDeveloperExceptionPage();
                app.UseHttpsRedirection();
                app.UseStaticFiles();

                app.UseRouting();

                app.UseAuthentication();   // add this
                app.UseAuthorization();    // add this

                app.UseSession();
                db.Database.EnsureCreated();

                app.UseEndpoints(endpoints =>
                {
                    // route for Admin area
                    endpoints.MapAreaControllerRoute(
                        name: "admin",
                        areaName: "Admin",
                        pattern: "Admin/{controller=Item}/{action=Index}/{id?}");

                    // route for paging, sorting, and filtering
                    endpoints.MapControllerRoute(
                        name: "",
                        pattern: "{controller}/{action}/page/{pagenumber}/size/{pagesize}/sort/{sortfield}/{sortdirection}/filter/{vendor}/{category}/{price}");

                    // route for paging and sorting only
                    endpoints.MapControllerRoute(
                        name: "",
                        pattern: "{controller}/{action}/page/{pagenumber}/size/{pagesize}/sort/{sortfield}/{sortdirection}");

                    // default route
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");
                });

            }
        }
    }
