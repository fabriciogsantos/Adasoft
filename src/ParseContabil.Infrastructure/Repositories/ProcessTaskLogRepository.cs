using ParseContabil.Domain.Entities;
using ParseContabil.Domain.Interfaces.Repositories;
using ParseContabil.Infrastructure.Context;

namespace ParseContabil.Infrastructure.Repositories
{
    public class ProcessTaskLogRepository: Repository<ProcessTaskLog>, IProcessTaskLogRepository
    {
        public ProcessTaskLogRepository(ParseContabilContext context) : base(context)
        {
        }

        public async Task<ProcessTaskLog> StartAsync()
        {
            var taskLog = new ProcessTaskLog
            {
                Status = (short)TaskStatus.Running,
                Start = DateTime.Now
            };

            await AddAsync(taskLog);
            return taskLog;
        } 
        
        public async Task StopAsync(ProcessTaskLog taskLog)
        => await UpdateAsync(taskLog);
        

    }
}
