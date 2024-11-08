namespace StudyBibleReading.Domain.Models;

public class ReadingPlanItem
{
    public ReadingPlanItem(ReadingPlan plan, int id, DateOnly date)
    {
        Id = id;
        ReadingPlan = plan;
        ReadingPlanId = plan.Id;
        Date = date;
    }

    protected ReadingPlanItem()
    {
    }

    public int Id { get; set; }

    public Guid ReadingPlanId { get; set; }

    public ReadingPlan ReadingPlan { get; set; } = null!;

    public DateOnly Date { get; set; }

    public bool Read { get; set; } = false;
}
