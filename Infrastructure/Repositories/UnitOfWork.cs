using Core.Interfaces;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ICategoryRepository categoryRepository)
        {
            Categories = categoryRepository;
        }
        public ICategoryRepository Categories {get;}
    }
}