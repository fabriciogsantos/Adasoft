using Microsoft.EntityFrameworkCore;
using ParseContabil.Domain.Entities;
using ParseContabil.Domain.Interfaces.Repositories;
using ParseContabil.Infrastructure.Context;

namespace ParseContabil.Infrastructure.Repositories
{
    public class RecordTypeRepository : Repository<RecordType>, IRecordTypeRepository
    {
        public RecordTypeRepository(ParseContabilContext context) : base(context) { }

        public async Task<List<RecordType>> GetAllAsync()
            => await DbSet.AsNoTracking().Include(r => r.Templates).ToListAsync();
    }
}
