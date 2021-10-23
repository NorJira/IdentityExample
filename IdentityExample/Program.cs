using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityExample.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace IdentityExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            //var host = CreateHostBuilder(args).Build();

            //using (var scope = app.ApplicationServices.CreateScope())
            //{
            //    //Resolve ASP .NET Core Identity with DI help
            //    var userManager = (UserManager<ApplicationUser>)scope.ServiceProvider.GetService(typeof(UserManager<ApplicationUser>));
            //    // do you things here
            //}

            ////using (var scope = host.Services.CreateScope())
            ////{
            ////    var serviceProvider = scope.ServiceProvider;
            ////    var config = serviceProvider.GetRequiredService<IConfiguration>();

            ////    await ApplicationDbContext.CreateAdminAccount(serviceProvider, config);
            ////}

            ////await host.RunAsync();
            //host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseDefaultServiceProvider(options =>
                        options.ValidateScopes = false);
                });
    }
}
