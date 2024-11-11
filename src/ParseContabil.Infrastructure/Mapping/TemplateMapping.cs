using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParseContabil.Domain.Entities;

namespace ParseContabil.Infrastructure.Mapping
{
    public class TemplateMapping : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("Templates");
        }
    }
}
