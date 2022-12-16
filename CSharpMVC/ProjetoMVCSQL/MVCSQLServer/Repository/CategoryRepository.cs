using MVCSQLServer.Models.Entities;
using MVCSQLServer.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCSQLServer.Repository
{
    public class CategoryRepository
    {
        private readonly ContextDatabase _context;

        public CategoryRepository(ContextDatabase context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task<int> SaveCategory(Category category)
        {
            _context.Add(category);
            return await _context.SaveChangesAsync();
        }
    }
}
