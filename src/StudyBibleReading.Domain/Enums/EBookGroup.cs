using System.ComponentModel;

namespace StudyBibleReading.Domain.Enums;

public enum EBookGroup
{
    [Description("Pentateuco")]
    Pentateuch = 1,

    [Description("Histórico")]
    Historical = 2,

    [Description("Poético")]
    Poetic = 3,

    [Description("Profeta Maior")]
    MajorProphet = 4,

    [Description("Profeta Menor")]
    MinorProphet = 5,

    [Description("Evangelho")]
    Gospel = 6,

    [Description("Epístola Paulina")]
    PaulsLetter = 7,

    [Description("Epístola")]
    Letter = 8,

    [Description("Apocalíptico")]
    Apocalyptic = 9,

    [Description("Deuterocanônico")]
    Deuterocanonical = 10,

    [Description("Apócrifo")]
    Apocryphal = 11,

    [Description("Torá")]
    Torah = 17,

    [Description("Nevi'im")]
    Neviim = 18,

    [Description("Ketuvim")]
    Ketuvim = 19
}
