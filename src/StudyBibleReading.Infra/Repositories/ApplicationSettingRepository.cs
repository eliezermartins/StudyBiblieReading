using Microsoft.EntityFrameworkCore;
using StudyBibleReading.Domain.Models;
using StudyBibleReading.Infra.Context;

namespace StudyBibleReading.Infra.Repositories;

public class ApplicationSettingRepository(IDbContextFactory<SbrContext> db)
{
    public async Task<ApplicationSetting> GetOrAdd(string key, string defaultValue)
    {
        await using var dbContext = await db.CreateDbContextAsync();

        var appSetting = dbContext.ApplicationSettings.SingleOrDefault(x => x.Key == key);
        if (appSetting == null)
        {
            appSetting = new ApplicationSetting { Key = key, Value = defaultValue };
            dbContext.ApplicationSettings.Add(appSetting);
            await dbContext.SaveChangesAsync();
        }

        return appSetting;
    }

    public async Task Update(string key, string value)
    {
        var dbContext = await db.CreateDbContextAsync();
        var existing = dbContext.ApplicationSettings.FirstOrDefault(x => x.Key == key) ?? throw new ApplicationException($"ApplicationSetting {key} does not exist.");
        existing.Value = value;
        await dbContext.SaveChangesAsync();
    }

    public async Task<ApplicationSetting> Toggle(string key)
    {
        var dbContext = await db.CreateDbContextAsync();
        var appSetting = dbContext.ApplicationSettings.SingleOrDefault(x => x.Key == key);

        if (appSetting is null || bool.TryParse(appSetting.Value, out bool appSettingValue) == false)
        {
            throw new ApplicationException($"ApplicationSetting {key} is not a valid boolean setting.");
        }

        appSetting.Value = (!appSettingValue).ToString();
        await dbContext.SaveChangesAsync();

        return appSetting;
    }
}
