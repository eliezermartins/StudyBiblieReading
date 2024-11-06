using Microsoft.EntityFrameworkCore;
using StudyBibleReading.Domain.Repositories;
using StudyBibleReading.Domain.UnitOfWork;
using StudyBibleReading.Infra.Context;
using StudyBibleReading.Infra.Repositories;

namespace StudyBibleReading.Infra.UnitOfWork;

public class UnitOfWork(SbrContext context) : IUnitOfWork, IDisposable
{
    private PublisherRepository publisherRepository = null!;
    private TranslationRepository translationRepository = null!;
    private BibleRepository bibleRepository = null!;
    private ReadingRepository readingRepository = null!;
    private ReadingPlanRepository readingPlanRepository = null!;

    public IPublisherRepository Publlishers => publisherRepository ??= new PublisherRepository(context);

    public ITranslationRepository Translations => translationRepository ??= new TranslationRepository(context);

    public IBibleRepository Bibles => bibleRepository ??= new BibleRepository(context);

    public IReadingRepository Readings => readingRepository ??= new ReadingRepository(context);

    public IReadingPlanRepository ReadingPlans => readingPlanRepository ??= new ReadingPlanRepository(context);

    public async Task CompleteAsync()
    {
        await context.SaveChangesAsync();
    }

    public void Dispose() => context.Dispose();

    public void UndoChanges()
    {
        if (context.ChangeTracker.Entries().Any(e => e.State != EntityState.Unchanged))
        {
            foreach (var entry in context.ChangeTracker.Entries().Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
        }
    }
}
