namespace StudyBibleReading.Domain.Models;

public class Chapter
{
    public Chapter(Book book, int id)
    {
        Id = id;
        Book = book;
        BookId = book.Id;
        Bible = book.Bible;
        BibleId = book.Bible.Id;
    }

    protected Chapter()
    {
    }

    public int Id { get; private set; }

    public Guid BookId { get; private set; }

    public Book Book { get; private set; } = null!;

    public Guid BibleId { get; private set; }

    public Bible Bible { get; private set; } = null!;

    public bool IsRead { get; private set; }
}
