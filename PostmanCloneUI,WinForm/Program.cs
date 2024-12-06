namespace PostmanCloneUI_WinForm;

using Microsoft.Extensions.DependencyInjection;
using PostmanCloneLibrary;

internal static class Program
{
    private static IServiceProvider _serviceProvider;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        _serviceProvider = serviceCollection.BuildServiceProvider();


        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(_serviceProvider.GetService<DashBoard>());
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        // Регистрация главной формы
        services.AddTransient<DashBoard>();
        services.AddTransient<IApiAccess, ApiAccess>();
        services.AddHttpClient();
    }
}