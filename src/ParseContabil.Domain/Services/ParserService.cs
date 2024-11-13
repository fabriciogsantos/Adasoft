using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ParseContabil.Domain.Dtos;
using ParseContabil.Domain.Entities;
using ParseContabil.Domain.Interfaces.Repositories;
using ParseContabil.Domain.Interfaces.Services;
using ParseContabil.Domain.Resources;
using System.Text;

namespace ParseContabil.Domain.Services
{
    public class ParserService : IParserService
    {
        private readonly IRecordTypeRepository _recordRepository;
        private readonly IProcessTaskLogRepository _processTaskLogRepository;
        private readonly IOptions<Configuration> _configurationOptions;
        private readonly ILogger<ParserService> _logger;
        private readonly IFilesHandlerWrapper _filesHandlerWrapper;
        private const string Delimiter = ";";
        private const int PositionRecordType = 14;
        private const int SizeLine = 510;
        public ParserService(IRecordTypeRepository recordRepository, IProcessTaskLogRepository processTaskLogRepository, IOptions<Configuration> configurationOptions, ILogger<ParserService> logger, IFilesHandlerWrapper filesHandlerWrapper)
        {
            _recordRepository = recordRepository;
            _processTaskLogRepository = processTaskLogRepository;
            _configurationOptions = configurationOptions;
            _filesHandlerWrapper = filesHandlerWrapper;
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
                    await _filesHandlerWrapper.GenerateFilesOutputAsync(filesOutput, _configurationOptions.Value.PathOutput);

                processTask.Status = (short)TaskStatus.RanToCompletion;
                processTask.Result = string.Format(Messages.CountFilesGenrated, filesOutput.Count);
            }
            catch (Exception ex)
            {
                processTask.Status = (short)TaskStatus.Faulted;
                processTask.Result = ex.Message;
                _logger.LogError(ex.Message, ex);
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
                if(!IsValidLine(line))
                    continue;

                var type = line[PositionRecordType];
                var recordType = GetRecordType(type, recordTypes);

                if (recordType == null || recordType?.Templates == null)
                    continue;
                
                var lineOutput = ParseLine(recordType.Templates, line);
                if (!filesOutput.ContainsKey(recordType.FileOutPutName!))
                    filesOutput.Add(recordType.FileOutPutName!, StartFile(recordType.Templates.Select(t => t.Head).ToList()));

                filesOutput[recordType.FileOutPutName!].AppendLine(lineOutput);
            }
            return filesOutput;
        }

        private RecordType? GetRecordType(char type, List<RecordType> recordTypes)
        {
            var recordType = recordTypes.Find(r => r.Type == type);
            if (recordType == null)
                _logger.LogError(string.Format(Messages.FileNotConfigured, type));

            if (recordType?.Templates == null)
                _logger.LogError(string.Format(Messages.TemplateNotConfigured, type));
            
            return recordType;
        }

        private bool IsValidLine(string line)
        {
            if (line.Length == SizeLine) return true;
            _logger.LogError(string.Format(Messages.SizeLineError, SizeLine,line.Length));
            return false;
        }

        private StringBuilder StartFile(List<string?> heads)
            => new(string.Concat(string.Join(Delimiter, heads), Environment.NewLine));
       
        private string ParseLine(IEnumerable<Template> templates, string line)
        {
            try
            {
                var lineFile = new List<string>();
                var position = 0;
                foreach (var template in templates)
                {
                    lineFile.Add(line.Substring(position, template.Size));
                    position += template.Size;
                }

                return string.Join(Delimiter, lineFile);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw;
            }
        }
    }
}
