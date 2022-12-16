using MVCSQLServer.Models.Entities;

namespace MVCSQLServer.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategory();
        Task<int> Save(Category category);
    }
}
