using ParseContabil.Domain.Entities;
using System.Linq.Expressions;

namespace ParseContabil.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
        Task AddAsync(TEntity entity, bool saveChanges = true);
        Task UpdateAsync(TEntity entity, bool saveChanges = true);
        Task<int> SaveChangesAsync(bool saveChanges = true);
    }
}
