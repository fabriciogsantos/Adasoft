namespace ParseContabil.Domain.Interfaces.Services
{
    public interface IParserService
    {
        Task ProcessInputFileAsync(IDictionary<string, string[]> filesInput);
    }
}
