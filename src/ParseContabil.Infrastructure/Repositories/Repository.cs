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

        public async Task AddAsync(TEntity entity, bool saveChanges = true)
        {
            await DbSet.AddAsync(entity);
            await SaveChangesAsync(saveChanges);
        }

        public async Task UpdateAsync(TEntity entity, bool saveChanges = true)
        {
            DbSet.Update(entity);
            await SaveChangesAsync(saveChanges);
        }

        public async Task<int> SaveChangesAsync(bool saveChanges = true)
            =>  saveChanges ?  await Context.SaveChangesAsync() : 0;
        
        public void Dispose()
            => Context.Dispose();
    }
}
