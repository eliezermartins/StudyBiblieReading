namespace StudyBibleReading.Domain.Models;

public class Publisher(string name)
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public string Name { get; private set; } = name;

    public ICollection<Bible> Bibles { get; private set; } = new List<Bible>();

    public void Update(string name)
    {
        Name = name;
    }

    public override string ToString() => Name;
}
