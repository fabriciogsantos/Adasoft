using ParseContabil.Domain.Entities;

namespace ParseContabil.Domain.Interfaces.Repositories
{
    public interface IProcessTaskLogRepository : IRepository<ProcessTaskLog>
    {
        Task<ProcessTaskLog> StartAsync();
        Task StopAsync(ProcessTaskLog taskLog);
    }
}
