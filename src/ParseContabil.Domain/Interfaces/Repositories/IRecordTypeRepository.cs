using ParseContabil.Domain.Entities;

namespace ParseContabil.Domain.Interfaces.Repositories
{
    public interface IRecordTypeRepository : IRepository<RecordType>
    {
        Task<List<RecordType>> GetAllAsync();
    }
}
