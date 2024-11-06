using System.ComponentModel;

namespace StudyBibleReading.Domain.Enums;

public enum ETestament
{
    [Description("")]
    None = 0,

    [Description("Antigo Testamento")]
    Old = 1,

    [Description("Novo Testamento")]
    New = 2
}
