using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C200_Web_Application___Identity.Models;
using Microsoft.Extensions.Configuration;

namespace C200_Web_Application___Identity.Models
{
    public class RDSContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public RDSContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("webapptest");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
