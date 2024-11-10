using StudyBibleReading.Domain.Attibutes;

namespace StudyBibleReading.Domain.Enums;

public enum EOldTestamentCatholicBooks
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

    [BookInfo("2 Crônicas", "1Cr", 36, ETestament.Old, EBookGroup.Historical)]
    SegundoCronicas = 14,

    [BookInfo("Esdras", "Esd", 10, ETestament.Old, EBookGroup.Historical)]
    Esdras = 15,

    [BookInfo("Neemias", "Ne", 13, ETestament.Old, EBookGroup.Historical)]
    Neemias = 16,

    [BookInfo("Tobias", "Tb", 14, ETestament.Old, EBookGroup.Deuterocanonical)]
    Tobias = 17,

    [BookInfo("Judite", "Jd", 16, ETestament.Old, EBookGroup.Deuterocanonical)]
    Judite = 18,

    [BookInfo("Ester", "Est", 10, ETestament.Old, EBookGroup.Historical)]
    Ester = 19,

    [BookInfo("1 Macabeus", "1Mc", 16, ETestament.Old, EBookGroup.Deuterocanonical)]
    PrimeiroMacabeus = 20,

    [BookInfo("2 Macabeus", "2Mc", 15, ETestament.Old, EBookGroup.Deuterocanonical)]
    SegundoMacabeus = 21,

    [BookInfo("Jó", "Jó", 42, ETestament.Old, EBookGroup.Poetic)]
    Jo = 22,

    [BookInfo("Salmos", "Sl", 150, ETestament.Old, EBookGroup.Poetic)]
    Salmos = 23,

    [BookInfo("Provérbios", "Pr", 31, ETestament.Old, EBookGroup.Poetic)]
    Proverbios = 24,

    [BookInfo("Eclesiastes", "Ecl", 12, ETestament.Old, EBookGroup.Poetic)]
    Eclesiastes = 25,

    [BookInfo("Cânticos dos cânticos", "Ct", 8, ETestament.Old, EBookGroup.Poetic)]
    CanticoDosCanticos = 26,

    [BookInfo("Sabedoria", "Sb", 19, ETestament.Old, EBookGroup.Deuterocanonical)]
    Sabedoria = 27,

    [BookInfo("Eclesiástico", "Eclo", 51, ETestament.Old, EBookGroup.Deuterocanonical)]
    Eclesiastico = 28,

    [BookInfo("Isaías", "Is", 66, ETestament.Old, EBookGroup.MajorProphet)]
    Isaias = 29,

    [BookInfo("Jeremias", "Jr", 52, ETestament.Old, EBookGroup.MajorProphet)]
    Jeremias = 30,

    [BookInfo("Lamentações", "Lm", 5, ETestament.Old, EBookGroup.MajorProphet)]
    Lamentacoes = 31,

    [BookInfo("Baruc", "Br", 6, ETestament.Old, EBookGroup.Deuterocanonical)]
    Baruc = 32,

    [BookInfo("Ezequiel", "Ez", 48, ETestament.Old, EBookGroup.MajorProphet)]
    Ezequiel = 33,

    [BookInfo("Daniel", "Dn", 14, ETestament.Old, EBookGroup.MajorProphet)]
    Daniel = 34,

    [BookInfo("Oseias", "Os", 14, ETestament.Old, EBookGroup.MinorProphet)]
    Oseias = 35,

    [BookInfo("Joel", "Jl", 3, ETestament.Old, EBookGroup.MinorProphet)]
    Joel = 36,

    [BookInfo("Amós", "Am", 9, ETestament.Old, EBookGroup.MinorProphet)]
    Amos = 37,

    [BookInfo("Abdias", "Ab", 1, ETestament.Old, EBookGroup.MinorProphet)]
    Abdias = 38,

    [BookInfo("Jonas", "Jn", 4, ETestament.Old, EBookGroup.MinorProphet)]
    Jonas = 39,

    [BookInfo("Miqueias", "Mq", 7, ETestament.Old, EBookGroup.MinorProphet)]
    Miqueias = 40,

    [BookInfo("Naum", "Na", 3, ETestament.Old, EBookGroup.MinorProphet)]
    Naum = 41,

    [BookInfo("Habacuc", "Hab", 3, ETestament.Old, EBookGroup.MinorProphet)]
    Habacuc = 42,

    [BookInfo("Sofonias", "Sf", 3, ETestament.Old, EBookGroup.MinorProphet)]
    Sofonias = 43,

    [BookInfo("Ageu", "Ag", 2, ETestament.Old, EBookGroup.MinorProphet)]
    Ageu = 44,

    [BookInfo("Zacarias", "Zc", 14, ETestament.Old, EBookGroup.MinorProphet)]
    Zacarias = 45,

    [BookInfo("Malaquias", "Ml", 4, ETestament.Old, EBookGroup.MinorProphet)]
    Malaquias = 46
}