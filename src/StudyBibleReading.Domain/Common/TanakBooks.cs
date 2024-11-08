using StudyBibleReading.Domain.Enums;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Domain.Common;

public static class TanakBooks
{
    public static IEnumerable<Book> Books(Bible bible) =>
    [
        new Book(bible, "Bereshit", 1, 0, EBookGroup.Torah, 50),
        new Book(bible, "Shemot", 2, 0, EBookGroup.Torah, 40),
        new Book(bible, "Vaicrá", 3, 0, EBookGroup.Torah, 27),
        new Book(bible, "Bamidbar", 4, 0, EBookGroup.Torah, 36),
        new Book(bible, "Devarim", 5, 0, EBookGroup.Torah, 34),
        new Book(bible, "Iehoshúa", 6, 0, EBookGroup.Neviim, 24),
        new Book(bible, "Shofetim", 7, 0, EBookGroup.Neviim, 21),
        new Book(bible, "Shemuel", 8, 0, EBookGroup.Neviim, 55),
        new Book(bible, "Melahim", 9, 0, EBookGroup.Neviim, 47),
        new Book(bible, "Ieshaiáhu", 10, 0, EBookGroup.Neviim, 66),
        new Book(bible, "Irmiáhu", 11, 0, EBookGroup.Neviim, 52),
        new Book(bible, "Iehezkel", 12, 0, EBookGroup.Neviim, 48),
        new Book(bible, "Hoshêa", 13, 0, EBookGroup.Neviim, 14),
        new Book(bible, "Ioêl", 14, 0, EBookGroup.Neviim, 3),
        new Book(bible, "Amós", 15, 0, EBookGroup.Neviim, 9),
        new Book(bible, "Ovadiá", 16, 0, EBookGroup.Neviim, 1),
        new Book(bible, "Ioná", 17, 0, EBookGroup.Neviim, 4),
        new Book(bible, "Mihá", 18, 0, EBookGroup.Neviim, 7),
        new Book(bible, "Nahum", 19, 0, EBookGroup.Neviim, 3),
        new Book(bible, "Havacuc", 20, 0, EBookGroup.Neviim, 3),
        new Book(bible, "Tsefaniá", 21, 0, EBookGroup.Neviim, 3),
        new Book(bible, "Hagai", 22, 0, EBookGroup.Neviim, 2),
        new Book(bible, "Zehariá", 23, 0, EBookGroup.Neviim, 14),
        new Book(bible, "Malahi", 24, 0, EBookGroup.Neviim, 4),
        new Book(bible, "Salmos", 25, 0, EBookGroup.Ketuvim, 150),
        new Book(bible, "Mishlê", 26, 0, EBookGroup.Ketuvim, 31),
        new Book(bible, "Ióv", 27, 0, EBookGroup.Ketuvim, 42),
        new Book(bible, "Shir Hashirim", 28, 0, EBookGroup.Ketuvim, 8),
        new Book(bible, "Rut", 29, 0, EBookGroup.Ketuvim, 4),
        new Book(bible, "Echá", 30, 0, EBookGroup.Ketuvim, 5),
        new Book(bible, "Cohélet", 31, 0, EBookGroup.Ketuvim, 12),
        new Book(bible, "Ester", 32, 0, EBookGroup.Ketuvim, 10),
        new Book(bible, "Daniel", 33, 0, EBookGroup.Ketuvim, 12),
        new Book(bible, "Ezrá-Nehemiá", 34, 0, EBookGroup.Ketuvim, 23),
        new Book(bible, "Divrê Haiamim", 35, 0, EBookGroup.Ketuvim, 65),
    ];
}
