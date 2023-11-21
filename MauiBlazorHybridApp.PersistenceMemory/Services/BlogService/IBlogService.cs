using Domain.Entities;

namespace PersistenceinMemory.Services.BlogService
{
    public interface IBlogService
    {
        Task<List<Blog>> GetAll();
        Task<Blog?> GetById(int id);
        Task<Blog> Create(Blog blog);
        Task<int> Update(int id, Blog blog);
        Task<int> DeleteById(int id);
    }
}
