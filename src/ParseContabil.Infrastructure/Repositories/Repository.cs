using Microsoft.EntityFrameworkCore;
using ParseContabil.Domain.Entities;
using ParseContabil.Domain.Interfaces.Repositories;
using System.Linq.Expressions;
using ParseContabil.Infrastructure.Context;

namespace ParseContabil.Infrastructure.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly ParseContabilContext Context;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(ParseContabilContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }
        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        => await DbSet.AsNoTracking().Where(predicate).ToListAsync();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
