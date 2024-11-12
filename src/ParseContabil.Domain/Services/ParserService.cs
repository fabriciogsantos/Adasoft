using Microsoft.Extensions.Options;
using ParseContabil.Domain.Dtos;
using ParseContabil.Domain.Entities;
using ParseContabil.Domain.Helpers;
using ParseContabil.Domain.Interfaces.Repositories;
using ParseContabil.Domain.Interfaces.Services;
using System.Text;
using Microsoft.Extensions.Logging;

namespace ParseContabil.Domain.Services
{
    public class ParserService : IParserService
    {
        private readonly IRecordTypeRepository _recordRepository;
        private readonly IProcessTaskLogRepository _processTaskLogRepository;
        private readonly IOptions<Configuration> _configurationOptions;
        private readonly ILogger<ParserService> _logger;
        private const string Delimiter = ";";
        public ParserService(IRecordTypeRepository recordRepository, IProcessTaskLogRepository processTaskLogRepository, IOptions<Configuration> configurationOptions, ILogger<ParserService> logger)
        {
            _recordRepository = recordRepository;
            _processTaskLogRepository = processTaskLogRepository;
            _configurationOptions = configurationOptions;
            _logger = logger;
        }

        public async Task ProcessInputFileAsync(IDictionary<string, string[]> filesInput)
        {
            var processTask = await _processTaskLogRepository.StartAsync();
            try
            {
                var filesOutput = new Dictionary<string, StringBuilder>();
                var recordTypes = await _recordRepository.GetAllAsync();
                foreach (var fileInput in filesInput)
                    filesOutput = ParseFile(fileInput, recordTypes, filesOutput);
                
                if (filesOutput.Any())
                    await FilesHandler.GenerateFilesOutputAsync(filesOutput, _configurationOptions.Value.PathOutput);

                processTask.Status = (short)TaskStatus.RanToCompletion;
                processTask.Result = $"{filesOutput.Count} file(s) generated";
            }
            catch (Exception ex)
            {
                var message = string.Concat($"Error: {ex.Message}, Method :{nameof(ProcessInputFileAsync)}, {ex.StackTrace}");
                processTask.Status = (short)TaskStatus.Faulted;
                processTask.Result = message;
                _logger.LogError(message,ex);
            }
            finally
            {
                processTask.End = DateTime.Now;
                await _processTaskLogRepository.StopAsync(processTask);
            }
            
        }

        private Dictionary<string, StringBuilder> ParseFile(KeyValuePair<string, string[]> fileInput, List<RecordType> recordTypes, Dictionary<string, StringBuilder> filesOutput)
        {
            foreach (var line in fileInput.Value)
            {
                var type = line[14];
                var recordType = recordTypes.Find(r=>r.Type == type);
                if (recordType == null)
                {
                    _logger.LogError($"file of type :{type} not yet configured");
                    continue;
                }

                if (recordType.Templates != null)
                {
                    var lineOutput = ParseLine(recordType.Templates, line);
                    if (!filesOutput.ContainsKey(recordType.FileOutPutName!))
                        filesOutput.Add(recordType.FileOutPutName!, StartFile(recordType.Templates.Select(t => t.Head).ToList()));

                    filesOutput[recordType.FileOutPutName!].AppendLine(lineOutput);
                }
                else
                    _logger.LogError($"Templates of type :{type} not yet configured");
                
            }
            return filesOutput;
        }

        private StringBuilder StartFile(List<string?> heads)
            => new(string.Concat(string.Join(Delimiter, heads), Environment.NewLine));
       
        private static string ParseLine(IEnumerable<Template> templates, string line)
        {
            var lineFile = new List<string>();
            var position = 0;
            foreach (var template in templates) 
            {
                lineFile.Add(line.Substring(position,template.Size));
                position += template.Size;
            }

            return string.Join(Delimiter, lineFile);
        }
    }
}
