namespace StudyBibleReading.Domain.Models;

public class PartialReading : Reading
{
    public PartialReading(List<Book> books, DateOnly startDate) : base(startDate)
    {
        var bibles = books.Select(l => l.Bible).Distinct().ToList();
        if (bibles.Count > 1)
        {
            throw new Exception("Biblias diferentes");
        }

        Books = books;
    }

    public ICollection<Book> Books { get; private set; } = null!;

    public override bool CheckIfItIsCompleted()
    {
        return Completed = Books.All(l => l.Read);
    }
}
