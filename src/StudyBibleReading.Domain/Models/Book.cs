using StudyBibleReading.Domain.Enums;

namespace StudyBibleReading.Domain.Models;

public class Book
{
    public Book()
    {
    }

    public Book(Bible bible, string name, int sequence, ETestament testament, EGroup classification, int numOfChapters = 0, string? abbreviation = null)
    {
        Id = Guid.NewGuid();
        BibleId = bible.Id;
        Bible = bible;
        Name = name;
        Abbreviation = abbreviation;
        Testament = testament;
        Classification = classification;
        SequenceInTheBible = sequence;
        Chapters = new Dictionary<int, bool>();

        for (var i = 1; i <= numOfChapters; i++)
        {
            Chapters.Add(i, false);
        }

        Readings = new List<PartialReading>();
    }

    public Guid Id { get; init; }

    public Guid BibleId { get; private set; }

    public Bible Bible { get; private set; } = null!;

    public string Name { get; private set; } = string.Empty;

    public string? Abbreviation { get; private set; }

    public ETestament Testament { get; private set; }

    public EGroup Classification { get; private set; }

    public int SequenceInTheBible { get; private set; }

    public IDictionary<int, bool> Chapters { get; private set; } = null!;

    public ICollection<PartialReading> Readings { get; private set; } = null!;

    public bool Read => Chapters.All(c => c.Value);
}
