﻿using System;
using C200_Web_Application___Identity.Areas.Identity.Data;
using C200_Web_Application___Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(C200_Web_Application___Identity.Areas.Identity.IdentityHostingStartup))]
namespace C200_Web_Application___Identity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthDBContextConnection")));

                services.AddDefaultIdentity<WebAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<AuthDBContext>();
            });
        }
    }
}