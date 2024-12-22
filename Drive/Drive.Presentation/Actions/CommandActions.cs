using Drive.Data.Entities.Models;
using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;
using Drive.Domain.Enums;

namespace Drive.Presentation.Actions
{
    public class CommandActions
    {
        private Folder? _currentFolder;

        private readonly Stack<Folder?> _folderHistory;

        private readonly UserRepository _userRepository;

        private static SharedItemRepository _sharedItemRepository = RepositoryFactory.Create<SharedItemRepository>();

        private static FolderRepository _folderRepository = RepositoryFactory.Create<FolderRepository>();

        private static FileRepository _filesRepository = RepositoryFactory.Create<FileRepository>();

        private readonly User _user;

        public CommandActions(Folder? currentFolder, Stack<Folder?> folderHistory, UserRepository userRepository, User user)
        {
            _currentFolder = currentFolder;
            _folderHistory = folderHistory;
            _userRepository = userRepository;
            _user = user;
        }
        public void NavigateToFolder(string command)
        {
            var folderName = command.Substring("udi u mapu".Length).Trim();

            if (TryNavigateToFolder(folderName))
            {
                Writer.DisplaySuccess($"Successfully navigated to the folder '{folderName}'.\n");
                PrintCurrentFolderContent();
            }
            else
            {
                Writer.DisplayError($"Folder '{folderName}' not found.\n");
            }
        }

        public void ReturnToPreviousFolder()
        {
            if (_folderHistory.Count > 0)
            {
                _currentFolder = _folderHistory.Pop();
                Writer.DisplayInfo($"Returned to folder: {_currentFolder?.Name ?? "Root"}.\n");
                PrintCurrentFolderContent();
            }
            else
            {
                Writer.DisplayError("You are already at the root folder.\n");
            }
        }

        public void PrintCurrentFolderContent()
        {
            Console.Clear();
            Writer.DisplayInfo("========== My Disk ==========");

            var location = _currentFolder?.Name ?? "Root";
            Writer.PrintLocation(location);

            var folders = GetFoldersInCurrentLocation();
            var files = GetFilesInCurrentLocation();

            Writer.PrintFolders(folders);
            Console.WriteLine("");
            Writer.PrintFiles(files);

            Writer.DisplayInfo("\n=============================");
        }

        public bool TryNavigateToFolder(string folderName)
        {
            var folders = GetFoldersInCurrentLocation();

            var targetFolder = folders.FirstOrDefault(f => f.Name.Equals(folderName, StringComparison.OrdinalIgnoreCase));

            if (targetFolder != null)
            {
                _folderHistory.Push(_currentFolder);
                _currentFolder = targetFolder;
                return true;
            }

            return false;
        }

        public void CreateFolderInCurrentLocation(string command)
        {
            var folderName = command.Substring("stvori mapu".Length).Trim();

            if (folderName.Length == 0)
            {
                Writer.DisplayError("Folder name cannot be empty\n");
                return;
            }

            var newFolder = CreateFolder(folderName);

            var result = _folderRepository.Add(newFolder);

            if (result == ResponseResultType.Success)
            {
                PrintCurrentFolderContent();
            }
            else
            {
                Writer.DisplayError($"Failed to create folder '{folderName}'. Please try again.\n");
            }
        }

        public void CreateFileInCurrentLocation(string command)
        {
            var fileName = command.Substring("stvori datoteku".Length).Trim();

            if (fileName.Length == 0)
            {
                Writer.DisplayError("File name cannot be empty\n");
                return;
            }

            var newFile = CreateFile(fileName);

            var result = _filesRepository.Add(newFile);

            if (result == ResponseResultType.Success)
            {
                PrintCurrentFolderContent();
            }
            else
            {
                Writer.DisplayError($"Failed to create file '{fileName}'. Please try again.\n");
            }
        }

        public void EditFileContents(string command)
        {
            var fileName = command.Substring("uredi datoteku".Length).Trim();

            var file = _filesRepository.GetByName(fileName, _user);

            if (file == null)
            {
                Writer.DisplayError($"File {fileName} does not exist\n");
                return;
            }

            Console.Clear();

            var lines = string.IsNullOrEmpty(file.Content)
                ? new List<string>()
                : file.Content.Trim().Split('\n').Where(line => !string.IsNullOrEmpty(line)).ToList();

            int activeLineIndex = lines.Count;

            while (true)
            {
                PrintFileContents(lines);
                Console.Write("> ");
                var input = Console.ReadLine().Trim();

                switch (input.ToLower())
                {
                    case ":save":
                        var contents = string.Join("\n", lines);

                        Files newFile = new Files(fileName, contents, file.ParentFolderId, file.DiskId);

                        var result = _filesRepository.Update(newFile, file.ItemId);

                        Writer.DisplayInfo("\nSaving...");
                        Reader.PressAnyKey();

                        PrintCurrentFolderContent();
                        return;

                    case ":cancel":
                        Writer.DisplayInfo("\nExiting without saving...");
                        Reader.PressAnyKey();

                        PrintCurrentFolderContent();
                        return;

                    case ":help":
                        Writer.DisplayInfo("\nAvailable commands:\n");
                        Writer.DisplayInfo(":save - Save and exit\n");
                        Writer.DisplayInfo(":cancel - Exit without saving\n");
                        Writer.DisplayInfo(":help - Display available commands\n");
                        Reader.PressAnyKey();
                        break;

                    default:
                        if (string.IsNullOrEmpty(input))
                        {
                            if (activeLineIndex > 0)
                            {
                                activeLineIndex--;
                                lines.RemoveAt(activeLineIndex);
                                PrintFileContents(lines);
                            }
                        }
                        else
                        {
                            if (activeLineIndex < lines.Count)
                            {
                                lines[activeLineIndex] = input;
                            }
                            else
                            {
                                lines.Add(input);
                            }

                            activeLineIndex = lines.Count;
                        }
                        break;
                }
            }
        }

        public void DeleteItem(string command)
        {
            var itemName = string.Empty;

            if(Reader.StartsWithCommand(command, "izbrisi mapu"))
            {
                itemName = command.Substring("izbrisi mapu".Length).Trim();

                var folder = _folderRepository.GetByName(itemName, _user);

                if (folder != null) {
                    _folderRepository.Delete(folder.ItemId);
                    PrintCurrentFolderContent();
                }
                else
                {
                    Writer.DisplayError($"Folder {itemName} does not exist");
                }
            }
            else if(Reader.StartsWithCommand(command, "izbrisi datoteku"))
            {
                itemName = command.Substring("izbrisi datoteku".Length).Trim();

                var file = _filesRepository.GetByName(itemName, _user);

                if (file != null) {
                    _filesRepository.Delete(file.ItemId);
                    PrintCurrentFolderContent();
                }
                else
                {
                    Writer.DisplayError($"File {itemName} does not exist");
                }
            }

        }

        private void PrintFileContents(List<string> lines)
        {
            Console.Clear();
            Writer.DisplayInfo("========= Edit file =========\n");
            foreach (var line in lines)
            {
                Console.WriteLine("> " + line);
            }
        }

        private List<Folder> GetFoldersInCurrentLocation()
        {

            return _currentFolder == null
                ? _userRepository.GetUserFolders(_user)
                : _userRepository.GetUserFolders(_user).Where(f => f.ParentFolderId == _currentFolder.ItemId).ToList();
        }

        private List<Files> GetFilesInCurrentLocation()
        {
            return _currentFolder == null
                ? _userRepository.GetUserFiles(_user)
                : _userRepository.GetUserFiles(_user).Where(f => f.ParentFolderId == _currentFolder.ItemId).ToList();
        }

        private Folder CreateFolder(string folderName)
        {
            return _currentFolder == null
                ? new Folder(folderName, null, _user.DiskId)
                : new Folder(folderName, _currentFolder.ItemId, _user.DiskId);
        }

        private Files CreateFile(string fileName)
        {
            return _currentFolder == null
                ? new Files(fileName, " ", null, _user.DiskId)
                : new Files(fileName, " ", _currentFolder.ItemId, _user.DiskId);
        }
    }
}



//public void ShareItemWith(string command)
//{
//    var userEmail = command.Split(" ")[3];

//    var itemName = command.Split(" ")[1];

//    var user = _userRepository.GetByEmail(userEmail);

//    var itemFile = _filesRepository.GetByName(itemName, user);

//    var itemFolder = _folderRepository.GetByName(itemName, user);

//    if(user == null)
//    {
//        Writer.DisplayError($"User {userEmail} does not exits");
//        return;
//    }         
//}
