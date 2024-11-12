using Microsoft.Extensions.Options;
using ParseContabil.Domain.Dtos;
using ParseContabil.Domain.Helpers;
using ParseContabil.Domain.Interfaces.Services;

namespace ParseContabil.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IOptions<Configuration> _configurationOptions;
        private readonly IServiceProvider _serviceProvider;
        
        public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider, IOptions<Configuration> configurationOptions)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
            _configurationOptions = configurationOptions;
            
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var pathInput = _configurationOptions.Value.PathInput;
            var timer = new PeriodicTimer(TimeSpan.FromSeconds(_configurationOptions.Value.TimeVerifyDirectory));

            while (await timer.WaitForNextTickAsync(stoppingToken) && !stoppingToken.IsCancellationRequested)
            {
                try
                {
                    _logger.LogInformation("Verify files start");
                    var filesInput = FilesHandler.GetFilesInput(pathInput);
                    _logger.LogInformation("Verify files end");
                    if (filesInput.Any())
                    {
                        _logger.LogInformation("processing files start");
                        FilesHandler.MoveFilesProcessing(pathInput, _logger);

                        using var scope = _serviceProvider.CreateScope();
                        var parseService = scope.ServiceProvider.GetRequiredService<IParserService>();
                        await parseService.ProcessInputFileAsync(filesInput);

                        FilesHandler.MoveFilesProcessed(pathInput, _logger);
                        _logger.LogInformation("processing files end");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Erro: {ex.Message}",ex);
                }
            }
        }
    }
}
