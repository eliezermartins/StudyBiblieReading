using StudyBibleReading.Domain.Enums;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Domain.Common;

public static class ProtestantOldTestamentBooks
{
    public static IEnumerable<Book> Books(Bible bible) =>
    [
        new Book(bible, "Gênesis", 1, ETestament.Old, EBookGroup.Pentateuch, 50, "Gn"),
        new Book(bible, "Êxodo", 2, ETestament.Old, EBookGroup.Pentateuch, 40, "Ex"),
        new Book(bible, "Levítico", 3, ETestament.Old, EBookGroup.Pentateuch, 27, "Lv"),
        new Book(bible, "Números", 4, ETestament.Old, EBookGroup.Pentateuch, 36, "Nm"),
        new Book(bible, "Deuteronômio", 5, ETestament.Old, EBookGroup.Pentateuch, 34, "Dt"),
        new Book(bible, "Josué", 6, ETestament.Old, EBookGroup.Historical, 24, "Js"),
        new Book(bible, "Juízes", 7, ETestament.Old, EBookGroup.Historical, 21, "Jz"),
        new Book(bible, "Rute", 8, ETestament.Old, EBookGroup.Historical, 4, "Rt"),
        new Book(bible, "1 Samuel", 9, ETestament.Old, EBookGroup.Historical, 31, "1Sm"),
        new Book(bible, "2 Samuel", 10, ETestament.Old, EBookGroup.Historical, 24, "2Sm"),
        new Book(bible, "1 Reis", 11, ETestament.Old, EBookGroup.Historical, 22, "1Re"),
        new Book(bible, "2 Reis", 12, ETestament.Old, EBookGroup.Historical, 25, "2Re"),
        new Book(bible, "1 Crônicas", 13, ETestament.Old, EBookGroup.Historical, 29, "1Cr"),
        new Book(bible, "2 Crônicas", 14, ETestament.Old, EBookGroup.Historical, 36, "2Cr"),
        new Book(bible, "Esdras", 15, ETestament.Old, EBookGroup.Historical, 10, "Ed"),
        new Book(bible, "Neemias", 16, ETestament.Old, EBookGroup.Historical, 13, "Ne"),
        new Book(bible, "Ester", 17, ETestament.Old, EBookGroup.Historical, 10, "Et"),
        new Book(bible, "Jó", 18, ETestament.Old, EBookGroup.Poetic, 42, "Jó"),
        new Book(bible, "Salmos", 19, ETestament.Old, EBookGroup.Poetic, 150, "Sl"),
        new Book(bible, "Provérbios", 20, ETestament.Old, EBookGroup.Poetic, 31, "Pr"),
        new Book(bible, "Eclesiastes", 21, ETestament.Old, EBookGroup.Poetic, 12, "Ec"),
        new Book(bible, "Cânticos dos cânticos", 22, ETestament.Old, EBookGroup.Poetic, 8, "Ct"),
        new Book(bible, "Isaías", 23, ETestament.Old, EBookGroup.MajorProphet, 66, "Is"),
        new Book(bible, "Jeremias", 24, ETestament.Old, EBookGroup.MajorProphet, 52, "Jr"),
        new Book(bible, "Lamentações", 25, ETestament.Old, EBookGroup.MajorProphet, 5, "Lm"),
        new Book(bible, "Ezequiel", 26, ETestament.Old, EBookGroup.MajorProphet, 48, "Ez"),
        new Book(bible, "Daniel", 27, ETestament.Old, EBookGroup.MajorProphet, 12, "Dn"),
        new Book(bible, "Oseias", 28, ETestament.Old, EBookGroup.MinorProphet, 14, "Os"),
        new Book(bible, "Joel", 29, ETestament.Old, EBookGroup.MinorProphet, 3, "Jl"),
        new Book(bible, "Amós", 30, ETestament.Old, EBookGroup.MinorProphet, 9, "Am"),
        new Book(bible, "Obadias", 31, ETestament.Old, EBookGroup.MinorProphet, 1, "Ob"),
        new Book(bible, "Jonas", 32, ETestament.Old, EBookGroup.MinorProphet, 4, "Jn"),
        new Book(bible, "Miqueas", 33, ETestament.Old, EBookGroup.MinorProphet, 7, "Mq"),
        new Book(bible, "Naum", 34, ETestament.Old, EBookGroup.MinorProphet, 3, "Na"),
        new Book(bible, "Habacuque", 35, ETestament.Old, EBookGroup.MinorProphet, 3, "Hc"),
        new Book(bible, "Sofonias", 36, ETestament.Old, EBookGroup.MinorProphet, 3, "Sf"),
        new Book(bible, "Ageu", 37, ETestament.Old, EBookGroup.MinorProphet, 2, "Ag"),
        new Book(bible, "Zacarias", 38, ETestament.Old, EBookGroup.MinorProphet, 14, "Zc"),
        new Book(bible, "Malaquias", 39, ETestament.Old, EBookGroup.MinorProphet, 4, "Ml"),
    ];
}
