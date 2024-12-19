using Drive.Data.Entities.Models;

namespace Drive.Presentation.Helpers
{
    public class Writer
    {
        public static void DisplayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void DisplaySuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void DisplayInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintFolders(List<Folder> folders)
        {
            var sortedFolders = folders.OrderBy(f => f.Name).ToList();

            DisplayInfo("Folders:");

            foreach (var folder in sortedFolders)
            {
                Console.WriteLine(folder.Name + "/");
            }
        }
        public static void PrintFiles(List<Files> files)
        {
            var sortedFiles = files.OrderByDescending(f => f.LastChangedAt ?? f.CreatedAt).ToList();

            DisplayInfo("Files:");

            foreach (var file in sortedFiles)
            {
                var lastChanged = file.LastChangedAt ?? file.CreatedAt;
                Console.WriteLine($"{file.Name} (Last Changed: {lastChanged:yyyy-MM-dd HH:mm:ss})");
            }
        }


    }
}

