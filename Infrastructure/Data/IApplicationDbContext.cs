using System.Threading;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public interface IApplicationDbContext
    {
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken); 
    }
}