using StudyBibleReading.Domain.Enums;

namespace StudyBibleReading.Domain.Attibutes;

[AttributeUsage(AttributeTargets.Field)]
public class BookInfoAttribute
    (string description, string abbreviation, int capitulos, ETestament testament, EBookGroup classification) : Attribute
{
    public string Description { get; set; } = description;

    public string Abbreviation { get; set; } = abbreviation;

    public int NumberOfChapters { get; set; } = capitulos;

    public ETestament Testament { get; set; } = testament;

    public EBookGroup Classification { get; set; } = classification;
}
