using ParseContabil.Domain.Entities;
using System.Linq.Expressions;

namespace ParseContabil.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
    }
}
