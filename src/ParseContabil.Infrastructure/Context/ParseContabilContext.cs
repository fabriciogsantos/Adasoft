using Microsoft.EntityFrameworkCore;
using ParseContabil.Domain.Dtos;
using ParseContabil.Domain.Entities;

namespace ParseContabil.Infrastructure.Context
{
    public sealed class ParseContabilContext: DbContext
    {
        public ParseContabilContext()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ParseContabilContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<RecordType> RecordTypes { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Configuration> Configurations { get; set; }

    }
}
