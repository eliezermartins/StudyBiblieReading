using StudyBibleReading.Domain.Models;
using StudyBibleReading.Domain.UnitOfWork;

namespace StudyBibleReading.App.Services;

public class TranslationService(IUnitOfWork uow)
{
    public async Task<IEnumerable<Translation>> GetAll()
    {
        try
        {
            var result = await uow.Translations.GetAllAsync();
            await uow.CompleteAsync();
            return result;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }

    public async Task<Translation?> GetById(Guid id)
    {
        try
        {
            var publisher = await uow.Translations.GetByIdAsync(id);
            await uow.CompleteAsync();
            return publisher;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }

    public async Task<Translation> Create(Translation translation)
    {
        try
        {
            var result = await uow.Translations.AddAsync(translation);
            await uow.CompleteAsync();
            return result;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }

    public async Task<Translation> Update(Translation translation)
    {
        try
        {
            var translationDb = await uow.Translations.GetByIdAsync(translation.Id);
            translationDb?.Update(translation.Description, translation.Acronym);
            var result = await uow.Translations.Update(translationDb!);
            await uow.CompleteAsync();
            return result;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }

    public async Task Delete(Translation translation)
    {
        try
        {
            await uow.Translations.Delete(translation);
            await uow.CompleteAsync();
            return;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }
}
