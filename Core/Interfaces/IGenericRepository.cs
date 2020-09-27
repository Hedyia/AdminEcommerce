using System.Threading;
using System.Threading.Tasks;
using Core.Common;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : AuditEntity 
    {
        public Task<int> AddAsync(T entity, CancellationToken cancellationToken);
        public Task<int> UpdateAsync (T entity);
        public Task<int> DeleteAsync(int id);
    }
}