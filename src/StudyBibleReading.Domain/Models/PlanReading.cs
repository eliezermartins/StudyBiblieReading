namespace StudyBibleReading.Domain.Models;

public class PlanReading : Reading
{
    public PlanReading(ReadingPlan readingPlan, DateOnly startDate) : base(startDate)
    {
        ReadingPlan = readingPlan;
        ReadingPlanId = readingPlan.Id;
    }

    protected PlanReading()
    {
    }

    public Guid ReadingPlanId { get; private set; }

    public ReadingPlan ReadingPlan { get; private set; } = null!;

    public override bool CheckIfItIsCompleted()
    {
        return Completed = ReadingPlan.Items.All(i => i.Read);
    }
}
