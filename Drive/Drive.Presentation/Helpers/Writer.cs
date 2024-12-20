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

        public static void PrintLocation(string location)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Current Location: {location}");
            Console.ResetColor();
        }

        public static void PrintCommands()
        {
            Console.WriteLine("help");
            Console.WriteLine("stvori mapu 'ime mape'");
            Console.WriteLine("stvori datoteku 'ime datoteke'");
            Console.WriteLine("uđi u mapu 'ime mape'");
            Console.WriteLine("uredi datoteku 'ime datoteke'");
            Console.WriteLine("izbrisi mapu/datoteku 'ime mape/datoteke'");
            Console.WriteLine("promjeni naziv mape/datoteke 'ime mape/datoteke' u 'novo ime mape/datoteke'");
            Console.WriteLine("povratak");
        }
    }
}

