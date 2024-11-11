namespace ParseContabil.Domain.Helpers
{
    public static class FilesHandler
    {
        static IDictionary<string, string[]> GetFilesInput(string pathInput)
        {
            var filesInput = new Dictionary<string, string[]>();
            
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
    }
}
