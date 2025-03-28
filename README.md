&#xa0;

<h1 align="center">File Organizer</h1>

<p align="center">
  <img alt="Github top language" src="https://img.shields.io/github/languages/top/wilsonsouto/file-organizer?color=56BEB8">

  <img alt="Github language count" src="https://img.shields.io/github/languages/count/wilsonsouto/file-organizer?color=56BEB8">

  <img alt="Repository size" src="https://img.shields.io/github/repo-size/wilsonsouto/file-organizer?color=56BEB8">

  <img alt="License" src="https://img.shields.io/github/license/wilsonsouto/file-organizer?color=56BEB8">
</p>

<p align="center">
  <a href="#dart-about">About</a> &#xa0; | &#xa0; 
  <a href="#sparkles-features">Features</a> &#xa0; | &#xa0;
  <a href="#rocket-technologies">Technologies</a> &#xa0; | &#xa0;
  <a href="#white_check_mark-requirements">Requirements</a> &#xa0; | &#xa0;
  <a href="#checkered_flag-starting">Starting</a> &#xa0; | &#xa0;
  <a href="#memo-license">License</a> &#xa0; | &#xa0;
  <a href="https://github.com/wlsonsouto" target="_blank">Author</a>
</p>

<br>

## :dart: About

This script organizes files by extension, saving time and reducing manual effort. It scans a source directory, categorizes files into groups like documents, images, and videos, and moves them into corresponding folders. With built-in error handling, it ensures a smooth and efficient process.

## :sparkles: Features

:heavy_check_mark: **Reading Files**: The code reads files from the specified source directory.\
:heavy_check_mark: **Filtering by Extension**: Filters files in the source directory based on extensions in the extensions object.\
:heavy_check_mark: **Moving Files**: Moves files to corresponding folders (documents, pictures, videos) based on their extension.\
:heavy_check_mark: **Error Handling**: Uses try...catch to capture errors, ensuring a more reliable process.

## :rocket: Technologies

The following tools were used in this project:

- .NET 8.0
- C#

## :white_check_mark: Requirements

Before starting :checkered_flag:, you need to have [Git](https://git-scm.com) and [.NET SDK](https://dotnet.microsoft.com/en-us/download) installed.

## :checkered_flag: Starting

```bash
# Clone this project
$ git clone https://github.com/wlsonsouto/file-organizer

# Access the project folder
$ cd file-organizer/FileOrganizer

# Open Configuration.cs and update the paths below to match your local directories
public const string Source = @"C:\YOUR-PATH\Downloads";
public const string Documents = @"C:\YOUR-PATH\Documents";
public const string Pictures = @"C:\YOUR-PATH\Pictures";
public const string Videos = @"C:\YOUR-PATH\Videos";

# Run the project
$ dotnet run
```

## :memo: License

This project is under license from MIT. For more details, see the [LICENSE](LICENSE) file.

Made with :heart: by [wilsonsouto](https://github.com/wilsonsouto)

&#xa0;

<a href="#top">Back to top</a>
