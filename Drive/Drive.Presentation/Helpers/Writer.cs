using Drive.Data.Entities.Models;
using Drive.Domain.Repositories;

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

        public static void PrintFileEditCommands()
        {
            Console.WriteLine(":save                - Save and exit");
            Console.WriteLine(":cancel              - Exit without saving");
            Console.WriteLine(":otvori komentare    - Open comments");
            Console.WriteLine(":help                - Display available commands");
        }

        public static void PrintSharedContent(List<Item> items)
        {
            Console.Clear();
            DisplayInfo("========== Shared With Me ==========");

            List<Folder> folders = new List<Folder>();
            List<Files> files = new List<Files>();

            foreach (var item in items)
            {
                if (item is Folder folder)
                    folders.Add(folder);
                else if (item is Files file)
                    files.Add(file);
            }

            PrintFolders(folders);
            Console.WriteLine("");
            PrintFiles(files);

            DisplayInfo("\n=============================");
        }

        public static void PrintReducedCommands()
        {
            Console.WriteLine("\nhelp                                        - Display all commands");
            Console.WriteLine("uredi datoteku 'ime datoteke'               - Edit the specified file");
            Console.WriteLine("izbrisi 'ime mape/datoteke'                 - Delete the specified folder or file\n");
        }

        public static void PrintCommentCommands()
        {
            Console.WriteLine("\nhelp                                         - Display all commands");
            Console.WriteLine("dodaj komentar                               - Add a new comment");
            Console.WriteLine("uredi komentar                               - Edit a comment");
            Console.WriteLine("izbriši komentar                             - Delete a comment\n");
        }

        public static void PrintComments(List<Comment> comments, UserRepository userRepository)
        {
            DisplayInfo("=========== Comments ===========");

            foreach (var comment in comments)
            {
                var userEmail = userRepository.GetById(comment.UserId).Email;

                Console.WriteLine($"{comment.CommentId} - {userEmail} - {comment.CreatedAt}");
                Console.WriteLine($"{comment.Content}\n");
            }

            DisplayInfo("==============================\n");
        }
    }
}