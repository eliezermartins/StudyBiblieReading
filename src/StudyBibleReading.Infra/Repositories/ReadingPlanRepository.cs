using StudyBibleReading.Domain.Models;
using StudyBibleReading.Domain.Repositories;
using StudyBibleReading.Infra.Context;

namespace StudyBibleReading.Infra.Repositories;

internal class ReadingPlanRepository(SbrContext context) : IReadingPlanRepository
{
    public Task<ReadingPlan> AddAsync(ReadingPlan readingPlan)
    {
        throw new NotImplementedException();
    }

    public Task Delete(ReadingPlan readingPlan)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ReadingPlan>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ReadingPlan?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ReadingPlan> Update(ReadingPlan readingPlan)
    {
        throw new NotImplementedException();
    }
}
