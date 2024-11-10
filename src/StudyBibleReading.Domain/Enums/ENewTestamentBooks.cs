using StudyBibleReading.Domain.Attibutes;

namespace StudyBibleReading.Domain.Enums;

public enum ENewTestamentBooks
{
    [BookInfo("Mateus", "Mt", 28, ETestament.New, EBookGroup.Gospel)]
    Mateus = 1,

    [BookInfo("Marcos", "Mc", 16, ETestament.New, EBookGroup.Gospel)]
    Marcos = 2,

    [BookInfo("Lucas", "Lc", 24, ETestament.New, EBookGroup.Gospel)]
    Lucas = 3,

    [BookInfo("João", "Jo", 21, ETestament.New, EBookGroup.Gospel)]
    Joao = 4,

    [BookInfo("Atos dos Apóstolos", "At", 28, ETestament.New, EBookGroup.Historical)]
    Atos = 5,

    [BookInfo("Romanos", "Rm", 16, ETestament.New, EBookGroup.PaulsLetter)]
    Romanos = 6,

    [BookInfo("1 Coríntios", "1Co", 16, ETestament.New, EBookGroup.PaulsLetter)]
    PrimeiraCorintios = 7,

    [BookInfo("2 Coríntios", "2Co", 13, ETestament.New, EBookGroup.PaulsLetter)]
    SegundaCorintios = 8,

    [BookInfo("Gálatas", "Gl", 6, ETestament.New, EBookGroup.PaulsLetter)]
    Galatas = 9,

    [BookInfo("Efésios", "Ef", 6, ETestament.New, EBookGroup.PaulsLetter)]
    Efesios = 10,

    [BookInfo("Filipenses", "Fl", 4, ETestament.New, EBookGroup.PaulsLetter)]
    Filipenses = 11,

    [BookInfo("Colossenses", "Cl", 4, ETestament.New, EBookGroup.PaulsLetter)]
    Colossenses = 12,

    [BookInfo("1 Tessalonicenses", "1Ts", 5, ETestament.New, EBookGroup.PaulsLetter)]
    PrimeiraTessalonicenses = 13,

    [BookInfo("2 Tessalonicenses", "2Ts", 3, ETestament.New, EBookGroup.PaulsLetter)]
    SegundaTessalonicenses = 14,

    [BookInfo("1 Timóteo", "1Tm", 6, ETestament.New, EBookGroup.PaulsLetter)]
    PrimeiraTimoteo = 15,

    [BookInfo("2 Timóteo", "2Tm", 4, ETestament.New, EBookGroup.PaulsLetter)]
    SegundaTimoteo = 16,

    [BookInfo("Tito", "Tt", 3, ETestament.New, EBookGroup.PaulsLetter)]
    Tito = 17,

    [BookInfo("Filemom", "Fm", 1, ETestament.New, EBookGroup.PaulsLetter)]
    Filemom = 18,

    [BookInfo("Hebreus", "Hb", 13, ETestament.New, EBookGroup.Letter)]
    Hebreus = 19,

    [BookInfo("Tiago", "Tg", 5, ETestament.New, EBookGroup.Letter)]
    Tiago = 20,

    [BookInfo("1 Pedro", "1Pe", 5, ETestament.New, EBookGroup.Letter)]
    PrimeiraPedro = 21,

    [BookInfo("2 Pedro", "2Pe", 3, ETestament.New, EBookGroup.Letter)]
    SegundaPedro = 22,

    [BookInfo("1 João", "1Jo", 5, ETestament.New, EBookGroup.Letter)]
    PrimeiraJoao = 23,

    [BookInfo("2 João", "2Jo", 1, ETestament.New, EBookGroup.Letter)]
    SegundaJoao = 24,

    [BookInfo("3 João", "3Jo", 1, ETestament.New, EBookGroup.Letter)]
    TerceiraJoao = 25,

    [BookInfo("Judas", "Jd", 1, ETestament.New, EBookGroup.Letter)]
    Judas = 26,

    [BookInfo("Apocalipse", "Ap", 22, ETestament.New, EBookGroup.Apocalyptic)]
    Apocalipse = 27
}
