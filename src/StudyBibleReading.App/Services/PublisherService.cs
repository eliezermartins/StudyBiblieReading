using StudyBibleReading.Domain.Models;
using StudyBibleReading.Domain.UnitOfWork;

namespace StudyBibleReading.App.Services;

public class PublisherService(IUnitOfWork unitOfWork)
{
    public async Task<IEnumerable<Publisher>> GetPublishers()
    {
        return await unitOfWork.Publlishers.GetAllAsync();
    }
}
