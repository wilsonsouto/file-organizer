internal class Program
{
    // Define the paths as needed
    private const string Source = @"C:\YOUR-PATH\Downloads";

    private const string Documents = @"C:\YOUR-PATH\Documents";

    private const string Pictures = @"C:\YOUR-PATH\Pictures";

    private const string Videos = @"C:\YOUR-PATH\Videos";

    private static void Main(string[] args)
    {
        // Dictionary of extensions
        var extensions = new Dictionary<string, string>
        {
            { "rar", "rar" },
            { "docx", "docx" },
            { "jpg", "jpg" },
            { "png", "png" },
            { "ico", "ico" },
            { "mp4", "mp4" },
            { "avi", "avi" },
            { "mk4", "mk4" },
        };

        foreach (var extension in extensions)
        {
            try
            {
                string destFolder = "";

                // Get all files from the source folder with the corresponding extension
                var files = Directory.GetFiles(Source, $"*.{extension.Key}");

                foreach (var file in files)
                {
                    // Determine the destination folder based on the file extension
                    if (new[] { "rar", "docx" }.Contains(extension.Key))
                    {
                        destFolder = Documents;
                    }
                    else if (new[] { "jpg", "png", "ico" }.Contains(extension.Key))
                    {
                        destFolder = Pictures;
                    }
                    else if (new[] { "mp4", "avi", "mk4" }.Contains(extension.Key))
                    {
                        destFolder = Videos;
                    }

                    // Move the file to the destination folder
                    string destFile = Path.Combine(destFolder, Path.GetFileName(file));
                    File.Move(file, destFile);

                    Console.WriteLine($"File: {Path.GetFileName(file)} moved to: {destFolder}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error moving files with {extension.Key}: {ex.Message}");
            }
        }
    }
}
