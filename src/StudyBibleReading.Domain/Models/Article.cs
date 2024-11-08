using StudyBibleReading.Domain.Enums;

namespace StudyBibleReading.Domain.Models;

public class Article
{
    public Article(Guid bibleId, string name, EArticleGroup classification, int sequenceInTheBible)
    {
        Id = Guid.NewGuid();
        BibleId = bibleId;
        Name = name;
        Classification = classification;
        SequenceInTheBible = sequenceInTheBible;
        IsRead = false;
    }

    protected Article()
    {
    }

    public Guid Id { get; init; }

    public Guid BibleId { get; private set; }

    public Bible Bible { get; private set; } = null!;

    public string Name { get; private set; } = string.Empty;

    public EArticleGroup Classification { get; private set; }

    public int SequenceInTheBible { get; private set; }

    public bool IsRead { get; private set; }
}
