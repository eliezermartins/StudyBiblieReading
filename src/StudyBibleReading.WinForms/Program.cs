using Microsoft.Extensions.DependencyInjection;

namespace StudyBibleReading.WinForms;

internal class Program
{
    private static IServiceProvider? _serviceProvider;

    public static IServiceProvider ServiceProvider
    {
        get
        {
            if (_serviceProvider == null)
            {
                throw new InvalidOperationException("Service provider has not been initialized.");
            }

            return _serviceProvider;
        }
        private set => _serviceProvider = value;
    }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    internal static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        try
        {
            ServiceProvider = Configurations.Services();
            Configurations.CreateDatabase(ServiceProvider);
            var mainForm = ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }
        finally
        {
            if (_serviceProvider is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }
}