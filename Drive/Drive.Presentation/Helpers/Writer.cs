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
            Console.WriteLine("\nhelp                          - Display all commands");
            Console.WriteLine("stvori mapu 'ime mape'        - Create a folder with the specified name");
            Console.WriteLine("stvori datoteku 'ime datoteke'- Create a file with the specified name");
            Console.WriteLine("uđi u mapu 'ime mape'         - Navigate into the specified folder");
            Console.WriteLine("uredi datoteku 'ime datoteke' - Edit the specified file");
            Console.WriteLine("izbrisi 'ime mape/datoteke'   - Delete the specified folder or file");
            Console.WriteLine("promjeni naziv 'ime' u 'novo' - Rename a folder or file");
            Console.WriteLine("povratak                      - Return to the previous folder\n");
        }

    }
}

