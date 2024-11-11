using Microsoft.Extensions.Options;
using ParseContabil.Domain.Dtos;

namespace ParseContabil.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IOptions<Configuration> _configuraOptions;
        private readonly IServiceProvider _serviceProvider;
        public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider, IOptions<Configuration> configuraOptions)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
            _configuraOptions = configuraOptions;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
