using System.Threading;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IApplicationDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken); 
    }
}