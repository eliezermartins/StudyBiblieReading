namespace StudyBibleReading.Domain.Repositories;

public interface IBasseRepository<T>
{
    Task<T?> GetByIdAsync(Guid id);

    Task<IEnumerable<T>> GetAllAsync();

    Task<T> AddAsync(T obj);

    Task<T> Update(T obj);

    Task Delete(T obj);
}
