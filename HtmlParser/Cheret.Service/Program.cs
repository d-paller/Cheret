using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Service.Data.Model;
using Service.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheret.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    var config = hostContext.Configuration;

                    services.Configure<CheretDatabaseSettings>(config.GetSection(nameof(CheretDatabaseSettings)));

                    services.AddSingleton<ICheretDatabaseSettings>(x => x.GetRequiredService<IOptions<CheretDatabaseSettings>>().Value);
                    
                    services.AddHostedService<Worker>();
                });
    }
}
