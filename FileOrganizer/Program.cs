internal class Program
{
  private static void Main(string[] args)
  {
    // Define the paths as needed
    string source = @"C:\YOUR-PATH\Downloads";
    string documents = @"C:\YOUR-PATH\Documents";
    string pictures = @"C:\YOUR-PATH\Pictures";
    string videos = @"C:\YOUR-PATH\Videos";

    // Dictionary of extensions
    var extensions = new System.Collections.Generic.Dictionary<string, string>
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
    {
      try
      {
        string destFolder = string.Empty;

        // Get all files from the source folder with the corresponding extension
        var files = Directory.GetFiles(source, $"*.{extension.Key}");

        foreach (var file in files)
        {
          // Determine the destination folder based on the file extension
          if (new[] { "rar", "docx" }.Contains(extension.Key))
          {
            destFolder = documents;
          }
          else if (new[] { "jpg", "png", "ico" }.Contains(extension.Key))
          {
            destFolder = pictures;
          }
          else if (new[] { "mp4", "avi", "mk4" }.Contains(extension.Key))
          {
            destFolder = videos;
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
