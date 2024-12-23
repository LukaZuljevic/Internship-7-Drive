﻿using Drive.Data.Entities.Models;

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
                Console.WriteLine(folder.Name + "/");
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
            Console.WriteLine("\nhelp                                        - Display all commands");
            Console.WriteLine("stvori mapu 'ime mape'                      - Create a folder with the specified name");
            Console.WriteLine("stvori datoteku 'ime datoteke'              - Create a file with the specified name");
            Console.WriteLine("uđi u mapu 'ime mape'                       - Navigate into the specified folder");
            Console.WriteLine("uredi datoteku 'ime datoteke'               - Edit the specified file");
            Console.WriteLine("izbrisi mapu/datoteku 'ime mape/datoteke'   - Delete the specified folder or file");
            Console.WriteLine("promjeni naziv mape/datoteke 'ime' u 'novo' - Rename a folder or file");
            Console.WriteLine("podijeli mapu/datoteku s 'email'            - Share a folder or file");
            Console.WriteLine("prestani dijeliti 'mapu/datoteku' s 'email' - Stop shearing a folder or file");
            Console.WriteLine("nazad                                       - Return to the previous folder\n");
        }

        public static void PrintFileContents(List<string> lines)
        {
            Console.Clear();
            DisplayInfo("========= Edit file =========\n");

            foreach (var line in lines)
                Console.WriteLine("> " + line);

        }

        public static void PrintCurrentFolderContent(Folder? currentFolder, List<Folder> folders, List<Files> files)
        {
            Console.Clear();
            DisplayInfo("========== My Disk ==========");

            var location = currentFolder?.Name ?? "Root";
            PrintLocation(location);

            PrintFolders(folders);
            Console.WriteLine("");
            PrintFiles(files);

            DisplayInfo("\n=============================");
        }

        public static void PrintAllCommands()
        {
            DisplayInfo("\nAvailable commands:\n");
            DisplayInfo(":save - Save and exit\n");
            DisplayInfo(":cancel - Exit without saving\n");
            DisplayInfo(":help - Display available commands\n");
        }
    }
}