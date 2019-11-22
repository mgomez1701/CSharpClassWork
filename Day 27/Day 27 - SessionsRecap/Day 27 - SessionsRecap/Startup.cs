using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_27___SessionsRecap.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Day_27___SessionsRecap
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
            services.AddDistributedMemoryCache();

            services.AddSession(
                options =>
                {
                    //set a short timeout for easy testing//                 
                    options.Cookie.HttpOnly = true;
                    //make the session cookei essential
                    options.Cookie.IsEssential = true;
                    // need to add app.UseSession(); in the configure below after completing this

                }
                );
            services.AddControllersWithViews();
            var connectionString = "Server=.\\SQLExpress;Database=MOVIE_Db;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<MOVIE_DbContext>(option => option.UseSqlServer(connectionString));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
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
