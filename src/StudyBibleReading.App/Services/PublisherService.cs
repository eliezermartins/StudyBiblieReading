using StudyBibleReading.Domain.Models;
using StudyBibleReading.Domain.UnitOfWork;

namespace StudyBibleReading.App.Services;

public class PublisherService(IUnitOfWork uow)
{
    public async Task<IEnumerable<Publisher>> GetAll()
    {
        try
        {
            var result = await uow.Publlishers.GetAllAsync();
            await uow.CompleteAsync();
            return result;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }

    public async Task<Publisher?> GetById(Guid id)
    {
        try
        {
            var publisher = await uow.Publlishers.GetByIdAsync(id);
            await uow.CompleteAsync();
            return publisher;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }

    public async Task<Publisher> Create(Publisher publisher)
    {
        try
        {
            var result = await uow.Publlishers.AddAsync(publisher);
            await uow.CompleteAsync();
            return result;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }

    public async Task<Publisher> Update(Publisher publisher)
    {
        try
        {
            var publisherDb = await uow.Publlishers.GetByIdAsync(publisher.Id);
            publisherDb?.Update(publisher.Name);
            var result = await uow.Publlishers.Update(publisherDb);
            await uow.CompleteAsync();
            return result;
        }
        catch
        {
            uow.UndoChanges();
            throw;
        }
    }

    public async Task Delete(Publisher publisher)
    {
        try
        {
            await uow.Publlishers.Delete(publisher);
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
