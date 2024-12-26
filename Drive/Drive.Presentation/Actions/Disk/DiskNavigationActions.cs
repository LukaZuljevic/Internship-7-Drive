using Drive.Data.Entities.Models;
using Drive.Presentation.Helpers;
using Drive.Presentation.Actions;

namespace Drive.Presentation.Actions
{
    public class DiskNavigationActions
    {
        private CurrentFolder? _currentFolder;

        private readonly Stack<Folder?> _folderHistory;

        private readonly DiskActionHelper _commandHelper;
        public DiskNavigationActions(CurrentFolder? currentFolder, Stack<Folder?> folderHistory, DiskActionHelper commandHelper)
        {
            _currentFolder = currentFolder;
            _folderHistory = folderHistory;
            _commandHelper = commandHelper;
        }

        public void NavigateToFolder(string command)
        {
            var folderName = command.Substring("udi u mapu".Length).Trim();

            if (TryNavigateToFolder(folderName))
            {
                Writer.DisplaySuccess($"Successfully navigated to the folder '{folderName}'.\n");
                _commandHelper.DisplayFolderContents();
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
                _currentFolder.Folder = _folderHistory.Pop();
                Writer.DisplayInfo($"Returned to folder: {_currentFolder?.Folder?.Name ?? "Root"}.\n");
                _commandHelper.DisplayFolderContents();
            }
            else
            {
                Writer.DisplayError("You are already at the root folder.\n");
            }
        }

        public bool TryNavigateToFolder(string folderName)
        {
            var folders = _commandHelper.GetFoldersInCurrentLocation();

            var targetFolder = folders.FirstOrDefault(f => f.Name.Equals(folderName, StringComparison.OrdinalIgnoreCase));

            if (targetFolder != null)
            {
                _folderHistory.Push(_currentFolder.Folder);
                _currentFolder.Folder = targetFolder;
                return true;
            }

            return false;
        }

    }
}
