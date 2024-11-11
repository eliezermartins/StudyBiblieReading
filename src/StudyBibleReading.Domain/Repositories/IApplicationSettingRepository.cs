using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Domain.Repositories;

public interface IApplicationSettingRepository
{
    Task<ApplicationSetting> GetByKey(string key);

    Task<ApplicationSetting> Add(string key, string defaultValue);

    Task Update(string key, string value);

    Task<ApplicationSetting> Toggle(string key);
}
