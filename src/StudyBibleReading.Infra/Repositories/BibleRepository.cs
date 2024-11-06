using Microsoft.EntityFrameworkCore;
using StudyBibleReading.Domain.Models;
using StudyBibleReading.Domain.Repositories;
using StudyBibleReading.Infra.Context;

namespace StudyBibleReading.Infra.Repositories;

public class BibleRepository(SbrContext context) : IBibleRepository
{
    public Task<Bible> AddAsync(Bible bible)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Bible bible)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Bible>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Bible?> GetByIdAsync(Guid id)
    {
        return await context.Bibles
            .Include(b => b.Translation)
            .Include(b => b.Books)
            .Include(b => b.Readings)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<Bible> Update(Bible bible)
    {
        throw new NotImplementedException();
    }
}
