namespace StudyBibleReading.Domain.Models;

public class Chapter
{
    public Chapter(Book book, int id)
    {
        Id = id;
        Book = book;
    }

    protected Chapter()
    {
    }

    public int Id { get; private set; }

    public int BookId { get; private set; }

    public Book Book { get; private set; } = null!;

    public bool IsRead { get; private set; }
}
