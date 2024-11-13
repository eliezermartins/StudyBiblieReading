using Microsoft.Extensions.DependencyInjection;

namespace StudyBibleReading.WinForms;

public static class ServiceLocator
{
    public static T GetService<T>()
    {
        return Program.ServiceProvider.GetService<T>()!;
    }
}
