using StudyBibleReading.Domain.Enums;

namespace StudyBibleReading.Domain.Models;

public class Translation
{
    public Translation(string description, string acronym, ETradition tradition)
    {
        Id = Guid.NewGuid();
        Description = description;
        Acronym = acronym;
        Tradition = tradition;
        Bibles = new List<Bible>();
    }

    public Guid Id { get; init; }

    public string Description { get; private set; }

    public string Acronym { get; private set; }

    public ETradition Tradition { get; private set; }

    public ICollection<Bible> Bibles { get; private set; }

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
