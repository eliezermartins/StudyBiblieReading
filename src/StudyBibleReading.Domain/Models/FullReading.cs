namespace StudyBibleReading.Domain.Models;

public class FullReading(Bible bible, DateOnly startDate) : Reading(startDate)
{
    public Guid BibleId { get; private set; } = bible.Id;

    public Bible Bible { get; private set; } = bible;

    public override bool CheckIfItIsCompleted()
    {
        return Completed = Bible.Books.All(l => l.Read);
    }
}
