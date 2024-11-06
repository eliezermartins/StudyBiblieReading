using StudyBibleReading.Domain.Models;
using StudyBibleReading.Domain.Repositories;
using StudyBibleReading.Infra.Context;

namespace StudyBibleReading.Infra.Repositories;

internal class ReadingRepository(SbrContext context) : IReadingRepository
{
    public Task<Reading> AddAsync(Reading reading)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Reading reading)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Reading>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Reading?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Reading> Update(Reading reading)
    {
        throw new NotImplementedException();
    }
}
