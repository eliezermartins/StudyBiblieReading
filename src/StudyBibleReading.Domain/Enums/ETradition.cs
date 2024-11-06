using System.ComponentModel;

namespace StudyBibleReading.Domain.Enums;

public enum ETradition
{
    [Description("")]
    None = 0,

    [Description("Protestante")]
    Protestant = 1,

    [Description("Católica")]
    Catholic = 2,

    [Description("Tanak")]
    Tanak = 3,

    [Description("Outra")]
    Other = 4,
}
