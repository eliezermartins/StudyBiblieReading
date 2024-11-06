namespace StudyBibleReading.Domain.Models;

public class ReadingPlanItem(ReadingPlan plan, int id, DateOnly date)
{
    public int Id { get; set; } = id;

    public int ReadingPlanId { get; set; }

    public ReadingPlan ReadingPlan { get; set; } = plan;

    public DateOnly Date { get; set; } = date;

    public bool Read { get; set; } = false;
}
