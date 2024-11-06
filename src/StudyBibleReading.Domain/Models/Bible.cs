using StudyBibleReading.Domain.Common;
using StudyBibleReading.Domain.Enums;

namespace StudyBibleReading.Domain.Models;

public class Bible
{
    public Bible()
    {
    }

    public Bible(string title, Publisher publisher, Translation translation, int pages, bool study = false)
    {
        Id = Guid.NewGuid();
        Title = title;
        PublisherId = publisher.Id;
        Publisher = publisher;
        TranslationId = translation.Id;
        Translation = translation;
        Pages = pages;
        Study = study;

        List<Book> books = new();
        if (Translation.Tradition != ETradition.Other)
        {
            switch (Translation.Tradition)
            {
                case ETradition.Protestant:
                    books = ProtestantOldTestamentBooks.Books(this).ToList();
                    books.AddRange(NewTestamentBooks.Books(this, books.Count));
                    break;
                case ETradition.Catholic:
                    books = CatholicOldTestamentBooks.Books(this).ToList();
                    books.AddRange(NewTestamentBooks.Books(this, books.Count));
                    break;
                case ETradition.Tanak:
                    books = TanakBooks.Books(this).ToList();
                    break;
            }
        }

        Books = books;
        Readings = new List<FullReading>();
    }

    public Guid Id { get; init; }

    public string Title { get; private set; } = string.Empty;

    public Guid PublisherId { get; private set; }

    public Publisher Publisher { get; private set; } = null!;

    public Guid TranslationId { get; private set; }

    public Translation Translation { get; private set; } = null!;

    public int Pages { get; private set; }

    public bool Study { get; private set; }

    public ICollection<Book> Books { get; private set; } = null!;

    public ICollection<FullReading> Readings { get; private set; } = null!;

    public int ReadingQuantity => Readings.Count(l => l.Completed);
}
