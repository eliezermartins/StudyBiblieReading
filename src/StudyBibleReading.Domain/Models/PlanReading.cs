namespace StudyBibleReading.Domain.Models;

public class PlanReading(ReadingPlan readingPlan, DateOnly startDate) : Reading(startDate)
{
    public int ReadingPlanId { get; private set; }

    public ReadingPlan ReadingPlan { get; private set; } = readingPlan;

    public override bool CheckIfItIsCompleted()
    {
        return Completed = ReadingPlan.Items.All(i => i.Read);
    }
}
