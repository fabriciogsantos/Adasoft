using ParseContabil.Domain.Entities;
using ParseContabil.Domain.Interfaces.Repositories;
using ParseContabil.Infrastructure.Context;

namespace ParseContabil.Infrastructure.Repositories
{
    public class TemplateRepository : Repository<Template>, ITemplateRepository
    {
        public TemplateRepository(ParseContabilContext context) : base(context) { }
    }
}
