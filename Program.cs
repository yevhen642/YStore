using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YStore.Managers;

namespace YStore;

public static class Program
{
    public static IServiceProvider ServiceProvider { get; set; }

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        ServiceProvider = serviceCollection.BuildServiceProvider();

        Application.Run(ServiceProvider.GetRequiredService<Form1>());
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", false)
            .Build();

        services.Configure<AppSettings>(options =>
        {
            options.ConnectionString = configuration.GetConnectionString("DefaultConnection");
        });

        services.AddScoped<IProductProvider, ProductProvider>();
        services.AddScoped<ProductManager>();
        services.AddSingleton<Form1>();
    }
}