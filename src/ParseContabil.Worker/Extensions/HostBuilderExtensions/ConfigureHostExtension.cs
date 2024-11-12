using Serilog;

namespace ParseContabil.Worker.Extensions.HostBuilderExtensions
{
    public static class ConfigureHostExtension
    {
        public static IHostBuilder ConfigureServices(this IHostBuilder hostBuilder)
        {
            hostBuilder.UseSerilog((context, services, configuration) =>
            {
                configuration
                    .ReadFrom.Configuration(context.Configuration)
                    .Enrich.FromLogContext();

            });
            return hostBuilder;
        }
    }
}
