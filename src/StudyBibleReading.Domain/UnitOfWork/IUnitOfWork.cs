using StudyBibleReading.Domain.Repositories;

namespace StudyBibleReading.Domain.UnitOfWork;

public interface IUnitOfWork
{
    IPublisherRepository Publlishers { get; }

    ITranslationRepository Translations { get; }

    IBibleRepository Bibles { get; }

    IReadingRepository Readings { get; }

    IReadingPlanRepository ReadingPlans { get; }

    Task CompleteAsync();

    void UndoChanges();
}
