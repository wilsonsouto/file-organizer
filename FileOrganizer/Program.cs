namespace FileOrganizer;

public static class Program
{
    public static void Main(string[] args)
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
            { "mk4", "mk4" }
        };

        foreach (var extension in extensions)
            try
            {
                var destFolder = "";

                // Get all files from the source folder with the corresponding extension
                var files = Directory.GetFiles(Configuration.Source, $"*.{extension.Key}");

                foreach (var file in files)
                {
                    // Determine the destination folder based on the file extension
                    if (new[] { "rar", "docx" }.Contains(extension.Key))
                        destFolder = Configuration.Documents;

                    if (new[] { "jpg", "png", "ico" }.Contains(extension.Key))
                        destFolder = Configuration.Pictures;

                    if (new[] { "mp4", "avi", "mk4" }.Contains(extension.Key))
                        destFolder = Configuration.Videos;

                    // Move the file to the destination folder
                    var destFile = Path.Combine(destFolder, Path.GetFileName(file));
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