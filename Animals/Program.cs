using Animals.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

CreateHost()
    .Build()
    .Services
    .GetService<AppRunner>()!
    .Do();

IHostBuilder CreateHost()
{
    return Host.CreateDefaultBuilder()
        .ConfigureServices(services =>
        {
            services.AddTransient<AppRunner>(); // каждый раз новый AppRunner
            services.AddScoped<IFoodProvider, AnotherFoodProvider>(); // по 1 штуке на инстанс
            services.AddSingleton<AnimalFeeder>(); // один раз на всю прилагу
        });
}
