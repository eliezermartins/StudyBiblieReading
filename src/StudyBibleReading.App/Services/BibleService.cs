using StudyBibleReading.Domain.Models;
using StudyBibleReading.Domain.UnitOfWork;

namespace StudyBibleReading.App.Services;

public class BibleService(IUnitOfWork uow)
{
    public async Task<IEnumerable<Bible>> GetAll()
    {
        try
        {
            var result = await uow.Bibles.GetAllAsync();
            await uow.CompleteAsync();
            return result;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }

    public async Task<Bible?> GetById(Guid id)
    {
        try
        {
            var bible = await uow.Bibles.GetByIdAsync(id);
            await uow.CompleteAsync();
            return bible;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }

    public async Task<Bible> Create(Bible bible)
    {
        try
        {
            var result = await uow.Bibles.AddAsync(bible);
            await uow.CompleteAsync();
            return result;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }

    public async Task<Bible> Update(Bible bible)
    {
        try
        {
            var bibleDb = await uow.Bibles.GetByIdAsync(bible.Id);
            bibleDb?.Update(bible.Title, bible.Pages, bible.Study);
            var result = await uow.Bibles.Update(bibleDb!);
            await uow.CompleteAsync();
            return result;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }

    public async Task Delete(Bible bible)
    {
        try
        {
            await uow.Bibles.Delete(bible);
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
