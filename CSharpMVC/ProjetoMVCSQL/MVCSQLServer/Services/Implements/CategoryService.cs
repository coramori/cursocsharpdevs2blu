using MVCSQLServer.Models.Entities;
using MVCSQLServer.Repository;
using MVCSQLServer.Services.Interfaces;

namespace MVCSQLServer.Services.Implements
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryRepository _repository;

        public CategoryService(CategoryRepository repository)
        {
            _repository = repository;
        }
              

        public async Task<IEnumerable<Category>> GetAllCategory()
        {
            return await _repository.GetAll();
        }

        public async Task<int> Save(Category category)
        {
            return await _repository.SaveCategory(category);
        }
    }
}
