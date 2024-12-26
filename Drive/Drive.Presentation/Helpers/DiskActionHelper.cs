using Drive.Data.Entities.Models;
using Drive.Domain.Repositories;
using Drive.Presentation.Actions;

namespace Drive.Presentation.Helpers
{
    public class DiskActionHelper
    {

        private readonly User _user;
        private readonly UserRepository _userRepository;
        private readonly CurrentFolder? _currentFolder;

        public DiskActionHelper(User user, UserRepository userRepository, CurrentFolder? currentFolder)
        {
            _user = user;
            _userRepository = userRepository;
            _currentFolder = currentFolder;
        }
        public List<Folder> GetFoldersInCurrentLocation()
        {
            return _currentFolder.Folder == null
            ? _userRepository.GetUserFolders(_user)
            : _userRepository.GetUserFolders(_user).Where(f => f.ParentFolderId == _currentFolder.Folder.ItemId).ToList();
        }

        public List<Files> GetFilesInCurrentLocation()
        {
            return _currentFolder.Folder == null
            ? _userRepository.GetUserFiles(_user)
            : _userRepository.GetUserFiles(_user).Where(f => f.ParentFolderId == _currentFolder.Folder.ItemId).ToList();
        }

        public Folder CreateFolder(string folderName)
        {
            return _currentFolder.Folder == null
            ? new Folder(folderName, null, _user.DiskId)
                : new Folder(folderName, _currentFolder.Folder.ItemId, _user.DiskId);
        }

        public Files CreateFile(string fileName)
        {
            return _currentFolder.Folder == null
                ? new Files(fileName, " ", null, _user.DiskId)
                : new Files(fileName, " ", _currentFolder.Folder.ItemId, _user.DiskId);
        }

        public bool IsNameDuplicate(string name)
        {
            var folders = GetFoldersInCurrentLocation();
            var files = GetFilesInCurrentLocation();

            return Reader.CheckIfNameAlreadyExists(name, folders, files);
        }

        public void DisplayFolderContents()
        {
            var folders = GetFoldersInCurrentLocation();
            var files = GetFilesInCurrentLocation();

            Writer.PrintCurrentFolderContent(_currentFolder, folders, files);
        }
    }
}
