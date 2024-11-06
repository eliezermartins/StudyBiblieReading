using Microsoft.EntityFrameworkCore;
using StudyBibleReading.Domain.Models;
using StudyBibleReading.Domain.Repositories;
using StudyBibleReading.Infra.Context;

namespace StudyBibleReading.Infra.Repositories;

public class PublisherRepository(SbrContext context) : IPublisherRepository
{
    public async Task<Publisher> AddAsync(Publisher publisher)
    {
        var result = await context.Publishers.AddAsync(publisher);
        return result.Entity;
    }

    public Task Delete(Publisher publisher)
    {
        var result = context.Publishers.Remove(publisher);
        return Task.CompletedTask;
    }

    public async Task<IEnumerable<Publisher>> GetAllAsync()
    {
        return await context.Publishers
            .Include(p => p.Bibles)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Publisher?> GetByIdAsync(Guid id)
    {
        return await context.Publishers
            .Include(p => p.Bibles)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<Publisher> Update(Publisher publisher)
    {
        var result = context.Publishers.Update(publisher);
        return Task.FromResult(result.Entity);
    }
}
