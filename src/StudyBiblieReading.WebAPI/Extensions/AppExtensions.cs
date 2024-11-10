using Microsoft.EntityFrameworkCore;
using StudyBibleReading.Infra.Context;

namespace StudyBiblieReading.WebAPI.Extensions;

public static class AppExtensions
{
    public static WebApplication CreateDatabase(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            try
            {
                var context = services.GetRequiredService<SbrContext>();
                context.Database.Migrate();
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "Ocorreu um erro ao criar o banco de dados.");
            }
        }

        return app;
    }
}
