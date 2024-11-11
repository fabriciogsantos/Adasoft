using System.Text;
using ParseContabil.Domain.Entities;
using ParseContabil.Domain.Interfaces.Repositories;

namespace ParseContabil.Domain.Services
{
    public class ParserService
    {
        private readonly IRecordTypeRepository _recordRepository;
        private const string Delimiter = ";";
        public ParserService(IRecordTypeRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }

        public async Task ProcessInputFile(IDictionary<string, string[]> filesInput)
        {
            var filesOutput = new Dictionary<string, StringBuilder>();
            var recordTypes = await _recordRepository.GetAllAsync();
            foreach (var fileInput in filesInput)
            {
                filesOutput = ParseFile(fileInput, recordTypes, filesOutput);
            }
        }

        private static Dictionary<string, StringBuilder> ParseFile(KeyValuePair<string, string[]> fileInput, List<RecordType> recordTypes, Dictionary<string, StringBuilder> filesOutput)
        {
            foreach (var line in fileInput.Value)
            {
                char type = line[15];
                var recordType = recordTypes.Find(r=>r.Type == type);
                var lineOutput = ParseLine(recordType.Templates, line);
                if (!filesOutput.ContainsKey(recordType.FileOutPutName))
                    filesOutput.Add(recordType.FileOutPutName,new StringBuilder());

                filesOutput[recordType.FileOutPutName].AppendLine(lineOutput);
            }
            return filesOutput;
        }
        private static string ParseLine(IEnumerable<Template> templates, string line)
        {
            var lineFile = new List<string>();
            var position = 0;
            foreach (var template in templates.OrderBy(s=>s.Order)) 
            {
                lineFile.Add(line.Substring(position,template.Size));
                position += template.Size;
            }

            return string.Join(Delimiter, lineFile);
        }

    }
}
