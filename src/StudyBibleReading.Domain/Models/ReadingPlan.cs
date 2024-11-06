using StudyBibleReading.Domain.Enums;

namespace StudyBibleReading.Domain.Models;

public class ReadingPlan(string name, string description, ETradition tradition)
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = name;

    public string Description { get; set; } = description;

    public ETradition Tradition { get; set; } = tradition;

    public ICollection<ReadingPlanItem> Items { get; set; } = new List<ReadingPlanItem>();

    public ICollection<PlanReading> Readings { get; set; } = new List<PlanReading>();

    public int ReadingQuantity => Readings.Count(l => l.Completed);

    public int DurationInDays => Items.Select(pd => pd.Date).Distinct().Count();

    public int DurationInMonths
    {
        get
        {
            if (Items.Count != 0)
            {
                return 0;
            }

            var firstDate = Items.Min(pd => pd.Date);
            var lastData = Items.Max(pd => pd.Date);

            var totalMonths = ((lastData.Year - firstDate.Year) * 12) + lastData.Month - firstDate.Month;

            return totalMonths >= 1 ? totalMonths : 0;
        }
    }

    public int DurationInYears
    {
        get
        {
            if (Items.Count == 0)
            {
                return 0;
            }

            var firstDate = Items.Min(pd => pd.Date);
            var lastData = Items.Max(pd => pd.Date);

            var totalYears = lastData.Year - firstDate.Year;

            return totalYears >= 1 ? totalYears : 0;
        }
    }

    public void AddItem(DateOnly date)
    {
        Items.Add(new ReadingPlanItem(this, GetNextItemId(), date));
    }

    private int GetNextItemId()
    {
        return (Items.Count > 0 ? Items.Max(x => x.Id) : 0) + 1;
    }
}
