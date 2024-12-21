using Drive.Data.Entities.Models;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Actions
{
    public class CommandActions
    {
        private Folder? _currentFolder;

        private readonly Stack<Folder?> _folderHistory;

        private readonly UserRepository _userRepository;

        private readonly User _user;

        public CommandActions(Folder? currentFolder, Stack<Folder?> folderHistory, UserRepository userRepository, User user)
        {
            _currentFolder = currentFolder;
            _folderHistory = folderHistory;
            _userRepository = userRepository;
            _user = user;
        }

        public void Open()
        {

            PrintCurrentFolderContent();

            while (true)
            {
                Reader.TryReadInput("Enter a command ('help' to see all commands, 'exit' to quit navigation)", out var command);
                command = command.Trim();

                switch (true)
                {
                    case var _ when command.StartsWith("udi u mapu", StringComparison.OrdinalIgnoreCase):
                        NavigateToFolder(command);
                        break;
                    case var _ when command.Equals("povratak", StringComparison.OrdinalIgnoreCase):
                        ReturnToPreviousFolder();
                        break;
                    default:
                        Writer.DisplayError("Invalid command. Try again.");
                        break;
                }
               
                if (command.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;
            }

        }

        private void NavigateToFolder(string command)
        {
            var folderName = command.Substring("udi u mapu".Length).Trim();

            if (TryNavigateToFolder(folderName))
            {
                Writer.DisplaySuccess($"Successfully navigated to the folder '{folderName}'.");
                PrintCurrentFolderContent();
            }
            else
            {
                Writer.DisplayError($"Folder '{folderName}' not found.");
            }
        }

        private void ReturnToPreviousFolder()
        {
            if (_folderHistory.Count > 0)
            {
                _currentFolder = _folderHistory.Pop();
                Writer.DisplayInfo($"Returned to folder: {_currentFolder?.Name ?? "Root"}.");
                PrintCurrentFolderContent();    
            }
            else
            {
                Writer.DisplayError("You are already at the root folder.");
            }
        }


        public void PrintCurrentFolderContent()
        {
            Console.Clear();
            Writer.DisplayInfo("========== My Disk ==========");

            var location = _currentFolder?.Name ?? "Root";
            Writer.PrintLocation(location);

            var folders = _currentFolder == null
                ? _userRepository.GetUserFolders(_user)
                : _userRepository.GetUserFolders(_user).Where(f => f.ParentFolderId == _currentFolder.ItemId).ToList();

            var files = _currentFolder == null
                ? _userRepository.GetUserFiles(_user)
                : _userRepository.GetUserFiles(_user).Where(f => f.ParentFolderId == _currentFolder.ItemId).ToList();

            Writer.PrintFolders(folders);
            Console.WriteLine("");
            Writer.PrintFiles(files);

            Writer.DisplayInfo("\n=============================");
        }


        public bool TryNavigateToFolder(string folderName)
        {
            var folders = _currentFolder == null
                ? _userRepository.GetUserFolders(_user)
                : _userRepository.GetUserFolders(_user).Where(f => f.ParentFolderId == _currentFolder.ItemId).ToList();

            var targetFolder = folders.FirstOrDefault(f => f.Name.Equals(folderName, StringComparison.OrdinalIgnoreCase));

            if (targetFolder != null)
            {
                _folderHistory.Push(_currentFolder); // Save current folder to history
                _currentFolder = targetFolder;
                return true;
            }

            return false;
        }
    }
}
