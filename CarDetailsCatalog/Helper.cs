using System.IO;

namespace CarDetailsCatalog
{
    public static class Helper
    {
        public static string GetRootPath()
        {
            var currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (currentDirectory != null && !File.Exists(Path.Combine(currentDirectory.FullName, "CarDetailsCatalog.sln")))
            {
                currentDirectory = currentDirectory.Parent;
            }
            return currentDirectory?.FullName;
        }
    }
}