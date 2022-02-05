using C200_Web_Application___Identity.Models;
using C200_Web_Application___Identity.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity
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
            services.AddControllersWithViews();
            services.AddAuthentication(
               CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(options =>
               { options.LoginPath = "/Account/Login/"; });
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

            if (env.IsProduction())
            {
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/detectmaskrun", async context =>
                {
                    var webRoot = env.WebRootPath;
                    var pythonPath = System.IO.Path.Combine(webRoot, @"..\..\venv\python.exe");
                    var filePath = System.IO.Path.Combine(webRoot, @"..\Python\detect_mask_video.py");

                    ProcessStartInfo p = new ProcessStartInfo();
                    p.FileName = pythonPath;
                    p.Arguments = "\"" + filePath + "\"";
                    p.UseShellExecute = true;
                    p.RedirectStandardOutput = false;
                    Process.Start(p);
                    await context.Response.WriteAsync($"opening detect...(takes a while)");

                });
                endpoints.MapGet("/trainmaskrun", async context =>
                {
                    var webRoot = env.WebRootPath;
                    var pythonPath = System.IO.Path.Combine(webRoot, @"..\..\venv\python.exe");
                    var filePath = System.IO.Path.Combine(webRoot, @"..\Python\train_mask_detector.py");

                    ProcessStartInfo p = new ProcessStartInfo();
                    p.FileName = pythonPath;
                    p.Arguments = "\"" + filePath + "\"";
                    p.UseShellExecute = true;
                    p.RedirectStandardOutput = false;
                    Process.Start(p);
                    await context.Response.WriteAsync($"opening train...(takes a while)");

                });
            });
        }


    }
}

