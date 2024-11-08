using System.ComponentModel;

namespace StudyBibleReading.Domain.Enums;

public enum EArticleGroup
{
    [Description("")]
    None = 0,

    [Description("Prefácio")]
    Preface = 1,

    [Description("Introdução")]
    Introduction = 2,

    [Description("Introdução de livro")]
    BookIntroduction = 3,

    [Description("Texto de apoio")]
    SupportText = 4,

    [Description("Recurso")]
    Resource = 5,

    [Description("Outro")]
    Other = 6
}
