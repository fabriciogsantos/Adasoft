using Microsoft.EntityFrameworkCore;
using ParseContabil.Domain.Dtos;
using ParseContabil.Infrastructure.Context;

namespace ParseContabil.Worker.Extensions.HostBuilderExtensions
{
    public static class ConfigureServicesExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, HostBuilderContext context)
        {
            services.AddHostedService<Worker>();
            services.AddDbContext<ParseContabilContext>(options =>
            {
                options.UseSqlServer(context.Configuration.GetConnectionString("ParseContabilConnection"));
            });

            services.Configure<Configuration>(context.Configuration.GetSection("Configurations"));
            return services;
        }
    }
}
