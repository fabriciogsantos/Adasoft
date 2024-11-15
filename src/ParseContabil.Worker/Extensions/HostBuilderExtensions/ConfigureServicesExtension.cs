using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using ParseContabil.Domain.Dtos;
using ParseContabil.Domain.Interfaces.Repositories;
using ParseContabil.Domain.Interfaces.Services;
using ParseContabil.Domain.Services;
using ParseContabil.Infrastructure.Context;
using ParseContabil.Infrastructure.Repositories;
using ParseContabil.Worker.HealthChecks;

namespace ParseContabil.Worker.Extensions.HostBuilderExtensions
{
    public static class ConfigureServicesExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, HostBuilderContext context)
        {
            services.AddHostedService<Worker>();
            services.AddDbContext<ParseContabilContext>(options =>
            {
                options.UseSqlServer(context.Configuration.GetConnectionString("ParseContabilConnection")!);
            });
            
            services.Configure<Configuration>(context.Configuration.GetSection("Configurations"));

            services.AddSingleton<IHealthCheckPublisher, HealthCheckPublisher>();
            services.AddHealthChecks().AddCheck("Worker Health Check", () => HealthCheckResult.Healthy("Worker is running."));

            services.AddScoped<IRecordTypeRepository, RecordTypeRepository>();
            services.AddScoped<IProcessTaskLogRepository, ProcessTaskLogRepository>();
            services.AddScoped<IParserService, ParserService>();
            services.AddScoped<IFilesHandlerWrapper, FilesHandlerWrapper>();
            return services;
        }
    }
}
