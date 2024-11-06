using Microsoft.EntityFrameworkCore;
using StudyBibleReading.Domain.Models;
using StudyBibleReading.Domain.Repositories;
using StudyBibleReading.Infra.Context;

namespace StudyBibleReading.Infra.Repositories;

public class TranslationRepository(SbrContext context) : ITranslationRepository
{
    public async Task<Translation> AddAsync(Translation translation)
    {
        var result = await context.Translations.AddAsync(translation);
        return result.Entity;
    }

    public Task Delete(Translation translation)
    {
        var result = context.Translations.Remove(translation);
        return Task.CompletedTask;
    }

    public async Task<IEnumerable<Translation>> GetAllAsync()
    {
        return await context.Translations
            .Include(p => p.Bibles)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Translation?> GetByIdAsync(Guid id)
    {
        return await context.Translations
            .Include(p => p.Bibles)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<Translation> Update(Translation translation)
    {
        throw new NotImplementedException();
    }
}
