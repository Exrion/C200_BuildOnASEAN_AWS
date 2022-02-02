using C200_Web_Application___Identity.Models;
using C200_Web_Application___Identity.Services;
using IronPython.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;



namespace C200_Web_Application___Identity
{
    public class Program
    {
        public static void Main(string[] args)
        {



            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                try
                {
                    //RoleAndUser_Create.createDefaultSuper();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }

            host.Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });



        public static List<Statistics> ReadCSVFile()
        {
            var lines = File.ReadAllLines("Python\\Statistics.csv");
            var list = new List<Statistics>();

            foreach (var line in lines)
            {
                var values = line.Split(',');
                var stats = new Statistics() { Loss = values[0], Accuracy = values[0], ValidAccuracy = values[0], ValidLoss = values[0]};
                list.Add(stats);


            }
            return list;
        }

        public class Statistics
        {
            public string Loss { get; set; }
            public string ValidLoss { get; set; }
            public string Accuracy { get; set; }
            public string ValidAccuracy { get; set; }
        }

    }




}
