using Domain.Types;

namespace Domain.Repositories
{
    internal interface IGenericRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity> AddAsync(TEntity entity);
        TEntity Update(TEntity entity);

    }
}
