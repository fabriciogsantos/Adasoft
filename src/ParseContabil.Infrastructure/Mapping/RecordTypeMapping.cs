using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParseContabil.Domain.Entities;
using ParseContabil.Infrastructure.Seeds;

namespace ParseContabil.Infrastructure.Mapping
{
    public class RecordTypeMapping : IEntityTypeConfiguration<RecordType>
    {
        public void Configure(EntityTypeBuilder<RecordType> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasMany(r => r.Templates)
                .WithOne(t => t.RecordType)
                .HasForeignKey(t => t.RecordTypeId);
            builder.HasData(SeedParse.Seeds().recordTypes);
            builder.ToTable("RecordTypes");
        }
    }
}
