using System.Text;
using ParseContabil.Domain.Helpers;
using ParseContabil.Domain.Interfaces.Services;

namespace ParseContabil.Domain.Services
{
    public class FilesHandlerWrapper: IFilesHandlerWrapper
    {
        public async Task GenerateFilesOutputAsync(Dictionary<string, StringBuilder> filesOutput, string pathOutput)
            => await FilesHandler.GenerateFilesOutputAsync(filesOutput, pathOutput);
    }
}
