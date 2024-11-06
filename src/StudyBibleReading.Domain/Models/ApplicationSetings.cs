namespace StudyBibleReading.Domain.Models;

public record ApplicationSetting
{
    public int Id { get; set; }
    public string Key { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}