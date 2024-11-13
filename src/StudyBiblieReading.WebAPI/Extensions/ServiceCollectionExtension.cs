using StudyBibleReading.App.Services;

namespace StudyBiblieReading.WebAPI.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddSbrServices(this IServiceCollection service)
    {
        service.AddScoped<PublisherService>();
        service.AddScoped<TranslationService>();

        return service;
    }
}
