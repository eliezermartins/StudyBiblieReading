namespace StudyBibleReading.Domain.Models;

public class FullReading : Reading
{
    public FullReading(Bible bible, DateOnly startDate) : base(startDate)
    {
        Bible = bible;
        BibleId = bible.Id;
    }

    protected FullReading()
    {
    }

    public Guid BibleId { get; private set; }

    public Bible Bible { get; private set; } = null!;

    public override bool CheckIfItIsCompleted()
    {
        return Completed = Bible.Books.All(l => l.IsRead);
    }
}
