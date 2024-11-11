using Microsoft.EntityFrameworkCore;
using StudyBibleReading.Domain.Models;
using StudyBibleReading.Domain.Repositories;
using StudyBibleReading.Infra.Context;

namespace StudyBibleReading.Infra.Repositories;

public class ApplicationSettingRepository(SbrContext context) : IApplicationSettingRepository
{
    public async Task<ApplicationSetting> Add(string key, string defaultValue)
    {
        var appSetting = new ApplicationSetting { Key = key, Value = defaultValue };
        var result = await context.ApplicationSettings.AddAsync(appSetting);

        return result.Entity;
    }

    public Task<ApplicationSetting> GetByKey(string key)
    {
        throw new NotImplementedException();
    }

    public async Task Update(string key, string value)
    {
        //var dbContext = await context.CreateDbContextAsync();
        var existing = await context.ApplicationSettings.FirstOrDefaultAsync(x => x.Key == key) ?? throw new ApplicationException($"ApplicationSetting {key} does not exist.");
        existing.Value = value;
        //await dbContext.SaveChangesAsync();
    }

    public async Task<ApplicationSetting> Toggle(string key) //inverte o valor da chave
    {
        //var dbContext = await context.CreateDbContextAsync();
        var appSetting = await context.ApplicationSettings.SingleOrDefaultAsync(x => x.Key == key);

        if (appSetting is null || bool.TryParse(appSetting.Value, out bool appSettingValue) == false)
        {
            throw new ApplicationException($"ApplicationSetting {key} is not a valid boolean setting.");
        }

        appSetting.Value = (!appSettingValue).ToString();
        //await dbContext.SaveChangesAsync();

        return appSetting;
    }
}
