using Microsoft.Extensions.Logging;
using System.Text;

namespace ParseContabil.Domain.Helpers
{
    public static class FilesHandler
    {
        const string Processing = nameof(Processing);
        const string Processed = nameof(Processed);
        public static IDictionary<string, string[]> GetFilesInput(string pathInput)
        {
            var filesInput = new Dictionary<string, string[]>();
            pathInput = Path.Combine(Directory.GetCurrentDirectory(), pathInput);
            if (Directory.Exists(pathInput))
            {
                var files = Directory.GetFiles(pathInput);

                if (files.Length <= 0) return filesInput;

                foreach (var file in files)
                {
                    var content = File.ReadAllLines(file);
                    filesInput.Add(file, content);
                }
            }
            else
                Directory.CreateDirectory(pathInput);

            return filesInput;
        }

        public static async Task GenerateFilesOutputAsync(Dictionary<string, StringBuilder> filesOutput, string pathOutput)
        {
            pathOutput = Path.Combine(Directory.GetCurrentDirectory(), pathOutput);
            if (!Directory.Exists(pathOutput))
                Directory.CreateDirectory(pathOutput);

            foreach (var file in filesOutput)
            {
                var fileOutput = Path.Combine(pathOutput, string.Concat(file.Key, "_", DateTime.Now.ToString("yyyymmddHHmmss"), ".csv"));
                await File.WriteAllTextAsync(fileOutput, file.Value.ToString());
            }
        }

        public static bool MoveFilesProcessing(string pathInput, ILogger logger)
            => MoveFiles(pathInput, Path.Combine(pathInput, Processing), logger, rename:true);
        
        public static bool MoveFilesProcessed(string pathInput, ILogger logger)
            => MoveFiles(Path.Combine(pathInput, Processing), Path.Combine(pathInput, Processed), logger);
        
        private static bool MoveFiles(string pathInput, string pathDestination, ILogger logger, bool rename = false)
        {
            
            if (!Directory.Exists(pathDestination))
                Directory.CreateDirectory(pathDestination);

            var files = Directory.GetFiles(pathInput);
            foreach (var file in files)
            {
                try
                {
                    var fileName = rename? string.Concat(Path.GetFileNameWithoutExtension(file), "_", DateTime.Now.ToString("yyyymmddHHmmss"), Path.GetExtension(file)) : Path.GetFileName(file);
                    File.Move(file, Path.Combine(pathDestination, fileName));
                }
                catch (Exception ex)
                {
                    logger.LogError(ex.Message,ex);
                    return false;
                }
            }

            return true;
        }
    }
}
