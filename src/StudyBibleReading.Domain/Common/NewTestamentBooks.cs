using StudyBibleReading.Domain.Enums;
using StudyBibleReading.Domain.Models;

namespace StudyBibleReading.Domain.Common;

public static class NewTestamentBooks
{
    public static IEnumerable<Book> Books(Bible bible, int sequence = 0) =>
    [
        new Book(bible, "Mateus", sequence + 1, ETestament.New, EBookGroup.Gospel, 28, "Mt"),
        new Book(bible, "Marcos", sequence + 2, ETestament.New, EBookGroup.Gospel, 16, "Mc"),
        new Book(bible, "Lucas", sequence + 3, ETestament.New, EBookGroup.Gospel, 24, "Lc"),
        new Book(bible, "João", sequence + 4, ETestament.New, EBookGroup.Gospel, 21, "Jo"),
        new Book(bible, "Atos dos Apóstolos", sequence + 5, ETestament.New, EBookGroup.Historical, 28, "At"),
        new Book(bible, "Romanos", sequence + 6, ETestament.New, EBookGroup.PaulsLetter, 16, "Rm"),
        new Book(bible, "1 Coríntios", sequence + 7, ETestament.New, EBookGroup.PaulsLetter, 16, "1Co"),
        new Book(bible, "2 Coríntios", sequence + 8, ETestament.New, EBookGroup.PaulsLetter, 13, "2Co"),
        new Book(bible, "Gálatas", sequence + 9, ETestament.New, EBookGroup.PaulsLetter, 6, "Gl"),
        new Book(bible, "Efésios", sequence + 10, ETestament.New, EBookGroup.PaulsLetter, 6, "Ef"),
        new Book(bible, "Filipenses", sequence + 11, ETestament.New, EBookGroup.PaulsLetter, 4, "Fl"),
        new Book(bible, "Colossenses", sequence + 12, ETestament.New, EBookGroup.PaulsLetter, 4, "Cl"),
        new Book(bible, "1 Tessalonicenses", sequence + 13, ETestament.New, EBookGroup.PaulsLetter, 5, "1Ts"),
        new Book(bible, "2 Tessalonicenses", sequence + 14, ETestament.New, EBookGroup.PaulsLetter, 3, "2Ts"),
        new Book(bible, "1 Timóteo", sequence + 15, ETestament.New, EBookGroup.PaulsLetter, 6, "1Tm"),
        new Book(bible, "2 Timóteo", sequence + 16, ETestament.New, EBookGroup.PaulsLetter, 4, "2Tm"),
        new Book(bible, "Tito", sequence + 17, ETestament.New, EBookGroup.PaulsLetter, 3, "Tt"),
        new Book(bible, "Filemom", sequence + 18, ETestament.New, EBookGroup.PaulsLetter, 1, "Fm"),
        new Book(bible, "Hebreus", sequence + 19, ETestament.New, EBookGroup.Letter, 13, "Hb"),
        new Book(bible, "Tiago", sequence + 20, ETestament.New, EBookGroup.Letter, 5, "Tg"),
        new Book(bible, "1 Pedro", sequence + 21, ETestament.New, EBookGroup.Letter, 5, "1Pe"),
        new Book(bible, "2 Pedro", sequence + 22, ETestament.New, EBookGroup.Letter, 3, "2Pe"),
        new Book(bible, "1 João", sequence + 23, ETestament.New, EBookGroup.Letter, 5, "1Jo"),
        new Book(bible, "2 João", sequence + 24, ETestament.New, EBookGroup.Letter, 1, "2Jo"),
        new Book(bible, "3 João", sequence + 25, ETestament.New, EBookGroup.Letter, 1, "3Jo"),
        new Book(bible, "Judas", sequence + 26, ETestament.New, EBookGroup.Letter, 1, "Jd"),
        new Book(bible, "Apocalipse", sequence + 27, ETestament.New, EBookGroup.Apocalyptic, 22, "Ap"),
    ];
}