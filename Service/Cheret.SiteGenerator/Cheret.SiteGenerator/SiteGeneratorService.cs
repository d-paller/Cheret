using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cheret.SiteGenerator
{
    public class SiteGeneratorService :IHostedService, IDisposable
    {
        private readonly ILogger<SiteGeneratorService> _logger;
        private readonly IOptions<ServiceConfig> _config;

        public SiteGeneratorService(ILogger<SiteGeneratorService> logger, IOptions<ServiceConfig> config)
        {
            _logger = logger;
            _config = config;
        }

        public void Dispose()
        {
            _logger.LogInformation("Disposing...");
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Starting service: " + _config.Value.Name);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Stopping Service: " + _config.Value.Name);
            return Task.CompletedTask;
        }
    }
}
