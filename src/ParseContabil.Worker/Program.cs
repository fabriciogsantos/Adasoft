using ParseContabil.Worker.Extensions.HostBuilderExtensions;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context,services) => services.ConfigureServices(context))
    .UseContentRoot(Directory.GetCurrentDirectory())
    .RegisterDependencies()
    .Build();

await host.RunAsync();
