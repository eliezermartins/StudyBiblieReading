using StudyBibleReading.Infra.Context;

namespace StudyBiblieReading.WebAPI.Extensions;

public static class DatabaseExtension
{
    public static WebApplication CreateDatabase(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            try
            {
                var context = services.GetRequiredService<SbrContext>();
                context.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        return app;
    }
}
