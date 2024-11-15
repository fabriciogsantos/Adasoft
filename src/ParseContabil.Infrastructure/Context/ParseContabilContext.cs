using Microsoft.EntityFrameworkCore;
using ParseContabil.Domain.Dtos;
using ParseContabil.Domain.Entities;

namespace ParseContabil.Infrastructure.Context
{
    public sealed class ParseContabilContext: DbContext
    {
        public ParseContabilContext(DbContextOptions<ParseContabilContext> options): base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ParseContabilContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
