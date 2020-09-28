using System.Threading;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IApplicationDbContext _context;
        public CategoryRepository(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> AddAsync(Category entity, CancellationToken cancellationToken)
        {
            await _context.Categories.AddAsync(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> UpdateAsync(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}