using StudyBibleReading.Domain.Enums;

namespace StudyBibleReading.Domain.Models;

public class Book
{
    public Book(Bible bible, string name, int sequence, ETestament testament, EBookGroup classification, int numOfChapters = 0, string? abbreviation = null)
    {
        Id = Guid.NewGuid();
        BibleId = bible.Id;
        Bible = bible;
        Name = name;
        Abbreviation = abbreviation;
        Testament = testament;
        Classification = classification;
        SequenceInTheBible = sequence;
        ReadingQuantity = 0;
        Chapters = new List<Chapter>();

        for (var i = 1; i <= numOfChapters; i++)
        {
            Chapters.Add(new Chapter(this, i));
        }

        Readings = new List<PartialReading>();
    }

    protected Book()
    {
    }

    public Guid Id { get; init; }

    public Guid BibleId { get; private set; }

    public Bible Bible { get; private set; } = null!;

    public string Name { get; private set; } = string.Empty;

    public string? Abbreviation { get; private set; }

    public ETestament Testament { get; private set; }

    public EBookGroup Classification { get; private set; }

    public int SequenceInTheBible { get; private set; }

    public ICollection<Chapter> Chapters { get; private set; } = null!;

    public ICollection<PartialReading> Readings { get; private set; } = null!;

    public int ReadingQuantity { get; private set; }

    public void AddReadingQuantity()
    {
        ReadingQuantity++;
    }
}
