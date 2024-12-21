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
                _folderHistory.Push(_currentFolder); 
                _currentFolder = targetFolder;
                return true;
            }

            return false;
        }

        public void CreateFolderInCurrentLocation(string command)
        {

            var folderName = command.Substring("stvori mapu".Length).Trim();

            if(folderName.Length == 0)
            {
                Writer.DisplayError("Folder name cannot be empty\n");
                return;
            }

            Folder newFolder;

            newFolder = _currentFolder is null
                 ? new Folder(folderName, null, _user.DiskId)
                 : new Folder(folderName, _currentFolder.ItemId, _user.DiskId);


            var result = _folderRepository.Add(newFolder);

            if (result == ResponseResultType.Success)
            {
                Writer.DisplaySuccess($"Folder '{folderName}' successfully created.\n");
                PrintCurrentFolderContent();
            }
            else
            {
                Writer.DisplayError($"Failed to create folder '{folderName}'. Please try again.\n");
            }
        }

        //public void CreateFileInCurrentLocation(string command)
        //{
        //    var fileName = command.Substring("stvori datoteku".Length).Trim();

        //    if (fileName.Length == 0)
        //    {
        //        Writer.DisplayError("File name cannot be empty\n");
        //        return;
        //    }

        //    var newFile = new Files(fileName, _currentFolder?.ItemId, _user.DiskId);

        //    var result = _filesRepository.Add(newFile);

        //    if (result == ResponseResultType.Success)
        //    {
        //        Writer.DisplaySuccess($"File '{fileName}' successfully created.\n");
        //        PrintCurrentFolderContent();
        //    }
        //    else
        //    {
        //        Writer.DisplayError($"Failed to create file '{fileName}'. Please try again.\n");
        //    }
        //} 
    }
}
