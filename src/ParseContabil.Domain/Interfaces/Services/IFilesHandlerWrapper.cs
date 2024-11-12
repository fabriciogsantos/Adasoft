using System.Text;

namespace ParseContabil.Domain.Interfaces.Services
{
    public interface IFilesHandlerWrapper
    {
        Task GenerateFilesOutputAsync(Dictionary<string, StringBuilder> filesOutput, string pathOutput);
    }
}
