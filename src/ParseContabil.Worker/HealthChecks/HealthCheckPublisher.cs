using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ParseContabil.Worker.HealthChecks
{
    public  class HealthCheckPublisher : IHealthCheckPublisher
    {
        private readonly ILogger _logger;

        public HealthCheckPublisher(ILogger<HealthCheckPublisher> logger)
        {
            _logger = logger;
        }

        public Task PublishAsync(HealthReport report, CancellationToken cancellationToken)
        {
            if (report.Status != HealthStatus.Healthy)
                _logger.LogError("Service Status: {Status} {@Report}", report.Status, report.Entries);
            else
                _logger.LogInformation("Service Status: {Status} {@Report}", report.Status, report.Entries);

            cancellationToken.ThrowIfCancellationRequested();

            return Task.CompletedTask;
        }
    }
}
