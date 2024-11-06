using StudyBibleReading.Domain.Enums;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Domain.Common;

public static class ProtestantOldTestamentBooks
{
    public static IEnumerable<Book> Books(Bible bible) =>
    [
        new Book(bible, "Gênesis", 1, ETestament.Old, EGroup.Pentateuch, 50, "Gn"),
        new Book(bible, "Êxodo", 2, ETestament.Old, EGroup.Pentateuch, 40, "Ex"),
        new Book(bible, "Levítico", 3, ETestament.Old, EGroup.Pentateuch, 27, "Lv"),
        new Book(bible, "Números", 4, ETestament.Old, EGroup.Pentateuch, 36, "Nm"),
        new Book(bible, "Deuteronômio", 5, ETestament.Old, EGroup.Pentateuch, 34, "Dt"),
        new Book(bible, "Josué", 6, ETestament.Old, EGroup.Historical, 24, "Js"),
        new Book(bible, "Juízes", 7, ETestament.Old, EGroup.Historical, 21, "Jz"),
        new Book(bible, "Rute", 8, ETestament.Old, EGroup.Historical, 4, "Rt"),
        new Book(bible, "1 Samuel", 9, ETestament.Old, EGroup.Historical, 31, "1Sm"),
        new Book(bible, "2 Samuel", 10, ETestament.Old, EGroup.Historical, 24, "2Sm"),
        new Book(bible, "1 Reis", 11, ETestament.Old, EGroup.Historical, 22, "1Re"),
        new Book(bible, "2 Reis", 12, ETestament.Old, EGroup.Historical, 25, "2Re"),
        new Book(bible, "1 Crônicas", 13, ETestament.Old, EGroup.Historical, 29, "1Cr"),
        new Book(bible, "2 Crônicas", 14, ETestament.Old, EGroup.Historical, 36, "2Cr"),
        new Book(bible, "Esdras", 15, ETestament.Old, EGroup.Historical, 10, "Ed"),
        new Book(bible, "Neemias", 16, ETestament.Old, EGroup.Historical, 13, "Ne"),
        new Book(bible, "Ester", 17, ETestament.Old, EGroup.Historical, 10, "Et"),
        new Book(bible, "Jó", 18, ETestament.Old, EGroup.Poetic, 42, "Jó"),
        new Book(bible, "Salmos", 19, ETestament.Old, EGroup.Poetic, 150, "Sl"),
        new Book(bible, "Provérbios", 20, ETestament.Old, EGroup.Poetic, 31, "Pr"),
        new Book(bible, "Eclesiastes", 21, ETestament.Old, EGroup.Poetic, 12, "Ec"),
        new Book(bible, "Cânticos dos cânticos", 22, ETestament.Old, EGroup.Poetic, 8, "Ct"),
        new Book(bible, "Isaías", 23, ETestament.Old, EGroup.MajorProphet, 66, "Is"),
        new Book(bible, "Jeremias", 24, ETestament.Old, EGroup.MajorProphet, 52, "Jr"),
        new Book(bible, "Lamentações", 25, ETestament.Old, EGroup.MajorProphet, 5, "Lm"),
        new Book(bible, "Ezequiel", 26, ETestament.Old, EGroup.MajorProphet, 48, "Ez"),
        new Book(bible, "Daniel", 27, ETestament.Old, EGroup.MajorProphet, 12, "Dn"),
        new Book(bible, "Oseias", 28, ETestament.Old, EGroup.MinorProphet, 14, "Os"),
        new Book(bible, "Joel", 29, ETestament.Old, EGroup.MinorProphet, 3, "Jl"),
        new Book(bible, "Amós", 30, ETestament.Old, EGroup.MinorProphet, 9, "Am"),
        new Book(bible, "Obadias", 31, ETestament.Old, EGroup.MinorProphet, 1, "Ob"),
        new Book(bible, "Jonas", 32, ETestament.Old, EGroup.MinorProphet, 4, "Jn"),
        new Book(bible, "Miqueas", 33, ETestament.Old, EGroup.MinorProphet, 7, "Mq"),
        new Book(bible, "Naum", 34, ETestament.Old, EGroup.MinorProphet, 3, "Na"),
        new Book(bible, "Habacuque", 35, ETestament.Old, EGroup.MinorProphet, 3, "Hc"),
        new Book(bible, "Sofonias", 36, ETestament.Old, EGroup.MinorProphet, 3, "Sf"),
        new Book(bible, "Ageu", 37, ETestament.Old, EGroup.MinorProphet, 2, "Ag"),
        new Book(bible, "Zacarias", 38, ETestament.Old, EGroup.MinorProphet, 14, "Zc"),
        new Book(bible, "Malaquias", 39, ETestament.Old, EGroup.MinorProphet, 4, "Ml"),
    ];
}
