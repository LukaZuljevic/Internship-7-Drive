﻿using Drive.Data.Entities.Models;
using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Presentation.Actions;

namespace Drive.Presentation.Helpers
{
    public class DiskActionHelper
    {

        private readonly User _user;
        private readonly UserRepository _userRepository;
        private readonly CurrentFolder? _currentFolder;
        private readonly SharedItemRepository _sharedItemRepository = RepositoryFactory.Create<SharedItemRepository>();
        private readonly ItemRepository _itemRepository = RepositoryFactory.Create<ItemRepository>();
        private readonly FileRepository _filesRepository = RepositoryFactory.Create<FileRepository>();

        public DiskActionHelper(User user, UserRepository userRepository, CurrentFolder? currentFolder)
        {
            _user = user;
            _userRepository = userRepository;
            _currentFolder = currentFolder;
        }

        public DiskActionHelper(ItemRepository itemRepository, SharedItemRepository sharedItemRepository, User user)
        {
            _sharedItemRepository = sharedItemRepository;
            _itemRepository = itemRepository;
            _user = user;
        }
        public List<Folder> GetFoldersInCurrentLocation()
        {
            return _currentFolder.Folder == null
            ? _userRepository.GetUserFolders(_user).Where(f => f.ParentFolderId == null).ToList()
            : _userRepository.GetUserFolders(_user).Where(f => f.ParentFolderId == _currentFolder.Folder.ItemId).ToList();
        }

        public List<Files> GetFilesInCurrentLocation()
        {
            return _currentFolder.Folder == null
            ? _userRepository.GetUserFiles(_user).Where(f => f.ParentFolderId == null).ToList()
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

        public void DisplaySharedItems()
        {
            var sharedItems = _sharedItemRepository.GetByUserId(_user.UserId);

            List<Item> items = new List<Item>();

            foreach (var sharedItem in sharedItems)
            {
                var item = _itemRepository.GetByItemId(sharedItem.ItemId);

                if (item is not null)
                    items.Add(item);
            }

            Writer.PrintSharedContent(items);
        }

        public Files? GetFile(string fileName, bool isShared)
        {
            if (isShared)
            {
                var sharedFile = _sharedItemRepository.GetByNameAndUserId(fileName, _user.UserId);
                if (sharedFile == null)
                    return null;

                return _filesRepository.GetById(sharedFile.ItemId);
            }

            return _filesRepository.GetByName(fileName, _user);
        }
    }
}