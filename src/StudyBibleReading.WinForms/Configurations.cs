using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudyBibleReading.App.Services;
using StudyBibleReading.Domain.UnitOfWork;
using StudyBibleReading.Infra.Context;
using StudyBibleReading.Infra.UnitOfWork;

namespace StudyBibleReading.WinForms;

public static class Configurations
{
    //private static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "StudyBibleReading", "DataBase");

    public static IServiceProvider Services()
    {
        var services = new ServiceCollection();

        services.AddScoped<MainForm>();

        //if (!Directory.Exists(path))
        //{
        //    Directory.CreateDirectory(path);
        //}

        services.AddDbContextFactory<SbrContext>(options => options.UseSqlite(@"Data Source=C:\Projetos\meus\StudyBibleReading\db\SBRDB.sqlite3"));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<PublisherService>();
        services.AddScoped<TranslationService>();
        services.AddScoped<BibleService>();

        return services.BuildServiceProvider();
    }

    public static void CreateDatabase(IServiceProvider serviceProvider)
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<SbrContext>();
            try
            {
                context.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
