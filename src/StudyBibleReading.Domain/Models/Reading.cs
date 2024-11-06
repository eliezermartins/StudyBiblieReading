namespace StudyBibleReading.Domain.Models;

public abstract class Reading
{
    public Reading(DateOnly startDate)
    {
        Id = Guid.NewGuid();
        StartDate = startDate;
        EndDate = null;
        Completed = false;
    }

    protected Reading()
    {
    }

    public Guid Id { get; init; }

    public DateOnly StartDate { get; private set; }

    public DateOnly? EndDate { get; protected set; }

    public bool Completed { get; protected set; }

    public abstract bool CheckIfItIsCompleted();
}
