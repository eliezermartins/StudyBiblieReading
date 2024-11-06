using StudyBibleReading.Domain.Enums;

namespace StudyBibleReading.Domain.Models;

public class Translation(string description, string acronym, ETradition tradition)
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public string Description { get; private set; } = description;

    public string Acronym { get; private set; } = acronym;

    public ETradition Tradition { get; private set; } = tradition;

    public ICollection<Bible> Bibles { get; private set; } = new List<Bible>();

    public void Update(string description, string acronym)
    {
        if (Description != description)
        {
            Description = description;
        }

        if (Acronym != acronym)
        {
            Acronym = acronym;
        }
    }
}
