using StudyBibleReading.Domain.Enums;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Domain.Common;

public static class CatholicOldTestamentBooks
{
    public static IEnumerable<Book> Books(Bible bible) =>
    [
        new(bible, "Gênesis", 1, ETestament.Old, EGroup.Pentateuch, 50, "Gn"),
        new(bible, "Êxodo", 2, ETestament.Old, EGroup.Pentateuch, 40, "Ex"),
        new(bible, "Levítico", 3, ETestament.Old, EGroup.Pentateuch, 27, "Lv"),
        new(bible, "Números", 4, ETestament.Old, EGroup.Pentateuch, 36, "Nm"),
        new(bible, "Deuteronômio", 5, ETestament.Old, EGroup.Pentateuch, 34, "Dt"),
        new(bible, "Josué", 6, ETestament.Old, EGroup.Historical, 24, "Js"),
        new(bible, "Juízes", 7, ETestament.Old, EGroup.Historical, 21, "Jz"),
        new(bible, "Rute", 8, ETestament.Old, EGroup.Historical, 4, "Rt"),
        new(bible, "1 Samuel", 9, ETestament.Old, EGroup.Historical, 31, "1Sm"),
        new(bible, "2 Samuel", 10, ETestament.Old, EGroup.Historical, 24, "2Sm"),
        new(bible, "1 Reis", 11, ETestament.Old, EGroup.Historical, 22, "1Re"),
        new(bible, "2 Reis", 12, ETestament.Old, EGroup.Historical, 25, "2Re"),
        new(bible, "1 Crônicas", 13, ETestament.Old, EGroup.Historical, 29, "1Cr"),
        new(bible, "2 Crônicas", 14, ETestament.Old, EGroup.Historical, 36, "2Cr"),
        new(bible, "Esdras", 15, ETestament.Old, EGroup.Historical, 10, "Ed"),
        new(bible, "Neemias", 16, ETestament.Old, EGroup.Historical, 13, "Ne"),
        new(bible, "Tobias", 17, ETestament.Old, EGroup.Historical, 14, "Tb"),
        new(bible, "Judite", 18, ETestament.Old, EGroup.Historical, 16, "Jd"),
        new(bible, "Ester", 19, ETestament.Old, EGroup.Historical, 10, "Est"),
        new(bible, "1 Macabeus", 20, ETestament.Old, EGroup.Deuterocanonical, 16, "1Mc"),
        new(bible, "2 Macabeus", 21, ETestament.Old, EGroup.Deuterocanonical, 15, "2Mc"),
        new(bible, "Jó", 22, ETestament.Old, EGroup.Poetic, 42, "Jó"),
        new(bible, "Salmos", 23, ETestament.Old, EGroup.Poetic, 150, "Sl"),
        new(bible, "Provérbios", 24, ETestament.Old, EGroup.Poetic, 31, "Pr"),
        new(bible, "Eclesiastes", 25, ETestament.Old, EGroup.Poetic, 12, "Ecl"),
        new(bible, "Canticos dos canticos", 26, ETestament.Old, EGroup.Poetic, 8, "Ct"),
        new(bible, "Sabedoria", 27, ETestament.Old, EGroup.Deuterocanonical, 19, "Sb"),
        new(bible, "Eclesiastos", 28, ETestament.Old, EGroup.Deuterocanonical, 51, "Eclo"),
        new(bible, "Isaías", 29, ETestament.Old, EGroup.MajorProphet, 66, "Is"),
        new(bible, "Jeremias", 30, ETestament.Old, EGroup.MajorProphet, 52, "Jr"),
        new(bible, "Lamentações", 31, ETestament.Old, EGroup.MajorProphet, 5, "Lm"),
        new(bible, "Baruc", 32, ETestament.Old, EGroup.Deuterocanonical, 6, "Br"),
        new(bible, "Ezequiel", 33, ETestament.Old, EGroup.MajorProphet, 48, "Ez"),
        new(bible, "Daniel", 34, ETestament.Old, EGroup.MajorProphet, 14, "Dn"),
        new(bible, "Oseias", 35, ETestament.Old, EGroup.MinorProphet, 14, "Os"),
        new(bible, "Joel", 36, ETestament.Old, EGroup.MinorProphet, 3, "Jl"),
        new(bible, "Amós", 37, ETestament.Old, EGroup.MinorProphet, 9, "Am"),
        new(bible, "Abdias", 38, ETestament.Old, EGroup.MinorProphet, 1, "Ab"),
        new(bible, "Jonas", 39, ETestament.Old, EGroup.MinorProphet, 4, "Jn"),
        new(bible, "Miqueias", 40, ETestament.Old, EGroup.MinorProphet, 7, "Mq"),
        new(bible, "Naum", 41, ETestament.Old, EGroup.MinorProphet, 3, "Na"),
        new(bible, "Habacuc", 42, ETestament.Old, EGroup.MinorProphet, 3, "Hab"),
        new(bible, "Sofonias", 43, ETestament.Old, EGroup.MinorProphet, 3, "Sf"),
        new(bible, "Ageu", 44, ETestament.Old, EGroup.MinorProphet, 2, "Ag"),
        new(bible, "Zacarias", 45, ETestament.Old, EGroup.MinorProphet, 14, "Zc"),
        new(bible, "Malaquias", 46, ETestament.Old, EGroup.MinorProphet, 4, "Ml"),
    ];
}
