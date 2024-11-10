using StudyBibleReading.Domain.Attibutes;

namespace StudyBibleReading.Domain.Enums;

public enum EOldTestamentProtestantBooks
{
    [BookInfo("Gênesis", "Gn", 50, ETestament.Old, EBookGroup.Pentateuch)]
    Genesis = 1,

    [BookInfo("Êxodo", "Ex", 40, ETestament.Old, EBookGroup.Pentateuch)]
    Exodo = 2,

    [BookInfo("Levítico", "Lv", 27, ETestament.Old, EBookGroup.Pentateuch)]
    Levitico = 3,

    [BookInfo("Números", "Nm", 36, ETestament.Old, EBookGroup.Pentateuch)]
    Numeros = 4,

    [BookInfo("Deuteronômio", "Dt", 34, ETestament.Old, EBookGroup.Pentateuch)]
    Deuteronomio = 5,

    [BookInfo("Josué", "Js", 24, ETestament.Old, EBookGroup.Historical)]
    Josue = 6,

    [BookInfo("Juízes", "Jz", 21, ETestament.Old, EBookGroup.Historical)]
    Juizes = 7,

    [BookInfo("Rute", "Rt", 4, ETestament.Old, EBookGroup.Historical)]
    Rute = 8,

    [BookInfo("1 Samuel", "1Sm", 31, ETestament.Old, EBookGroup.Historical)]
    PrimeiroSamuel = 9,

    [BookInfo("2 Samuel", "2Sm", 24, ETestament.Old, EBookGroup.Historical)]
    SegundoSamuel = 10,

    [BookInfo("1 Reis", "1Rs", 22, ETestament.Old, EBookGroup.Historical)]
    PrimeiroReis = 11,

    [BookInfo("2 Reis", "2Rs", 25, ETestament.Old, EBookGroup.Historical)]
    SegundoReis = 12,

    [BookInfo("1 Crônicas", "1Cr", 29, ETestament.Old, EBookGroup.Historical)]
    PrimeiroCronicas = 13,

    [BookInfo("2 Crônicas", "2Cr", 36, ETestament.Old, EBookGroup.Historical)]
    SegundoCronicas = 14,

    [BookInfo("Esdras", "Ed", 10, ETestament.Old, EBookGroup.Historical)]
    Esdras = 15,

    [BookInfo("Neemias", "Ne", 13, ETestament.Old, EBookGroup.Historical)]
    Neemias = 16,

    [BookInfo("Ester", "Et", 10, ETestament.Old, EBookGroup.Historical)]
    Ester = 17,

    [BookInfo("Jó", "Jó", 42, ETestament.Old, EBookGroup.Poetic)]
    Jo = 18,

    [BookInfo("Salmos", "Sl", 150, ETestament.Old, EBookGroup.Poetic)]
    Salmos = 19,

    [BookInfo("Provérbios", "Pv", 31, ETestament.Old, EBookGroup.Poetic)]
    Proverbios = 20,

    [BookInfo("Eclesiastes", "Ec", 12, ETestament.Old, EBookGroup.Poetic)]
    Eclesiastes = 21,

    [BookInfo("Cânticos dos cânticos", "Ct", 8, ETestament.Old, EBookGroup.Poetic)]
    CanticoDosCanticos = 22,

    [BookInfo("Isaías", "Is", 66, ETestament.Old, EBookGroup.MajorProphet)]
    Isaias = 23,

    [BookInfo("Jeremias", "Jr", 52, ETestament.Old, EBookGroup.MajorProphet)]
    Jeremias = 24,

    [BookInfo("Lamentações", "Lm", 5, ETestament.Old, EBookGroup.MajorProphet)]
    Lamentacoes = 25,

    [BookInfo("Ezequiel", "Ez", 48, ETestament.Old, EBookGroup.MajorProphet)]
    Ezequiel = 26,

    [BookInfo("Daniel", "Dn", 12, ETestament.Old, EBookGroup.MajorProphet)]
    Daniel = 27,

    [BookInfo("Oseias", "Os", 14, ETestament.Old, EBookGroup.MinorProphet)]
    Oseias = 28,

    [BookInfo("Joel", "Jl", 3, ETestament.Old, EBookGroup.MinorProphet)]
    Joel = 29,

    [BookInfo("Amós", "Am", 9, ETestament.Old, EBookGroup.MinorProphet)]
    Amos = 30,

    [BookInfo("Obadias", "Ob", 1, ETestament.Old, EBookGroup.MinorProphet)]
    Obadias = 31,

    [BookInfo("Jonas", "Jn", 4, ETestament.Old, EBookGroup.MinorProphet)]
    Jonas = 32,

    [BookInfo("Miqueias", "Mq", 7, ETestament.Old, EBookGroup.MinorProphet)]
    Miqueias = 33,

    [BookInfo("Naum", "Na", 3, ETestament.Old, EBookGroup.MinorProphet)]
    Naum = 34,

    [BookInfo("Habacuque", "Hc", 3, ETestament.Old, EBookGroup.MinorProphet)]
    Habacuque = 35,

    [BookInfo("Sofonias", "Sf", 3, ETestament.Old, EBookGroup.MinorProphet)]
    Sofonias = 36,

    [BookInfo("Ageu", "Ag", 2, ETestament.Old, EBookGroup.MinorProphet)]
    Ageu = 37,

    [BookInfo("Zacarias", "Zc", 14, ETestament.Old, EBookGroup.MinorProphet)]
    Zacarias = 38,

    [BookInfo("Malaquias", "Ml", 4, ETestament.Old, EBookGroup.MinorProphet)]
    Malaquias = 39
}
