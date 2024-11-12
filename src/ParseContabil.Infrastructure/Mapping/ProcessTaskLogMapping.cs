using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParseContabil.Domain.Entities;

namespace ParseContabil.Infrastructure.Mapping
{
    public class ProcessTaskLogMapping : IEntityTypeConfiguration<ProcessTaskLog>
    {
        public void Configure(EntityTypeBuilder<ProcessTaskLog> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("ProcessTaskLogs");
        }
    }
}
