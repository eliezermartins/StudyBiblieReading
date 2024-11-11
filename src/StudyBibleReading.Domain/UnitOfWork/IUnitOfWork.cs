using StudyBibleReading.Domain.Repositories;

namespace StudyBibleReading.Domain.UnitOfWork;

public interface IUnitOfWork
{
    //IApplicationSettingRepository ApplicationSettings { get; }

    IPublisherRepository Publlishers { get; }

    ITranslationRepository Translations { get; }

    IBibleRepository Bibles { get; }

    IReadingRepository Readings { get; }

    IReadingPlanRepository ReadingPlans { get; }

    Task CompleteAsync();

    void UndoChanges();

    void Dispose();
}
