using FormEase.Core.Models.WebApplication.MetadataModels;

namespace FormEase.Core.Interfaces.WebApplication.MetadataModels
{
    public interface ITopicRepository
    {
        Task<List<Topic>> GetAllAsync();
    }
}
