using Drive.Data.Entities.Models;
using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;
using Drive.Domain.Enums;

namespace Drive.Presentation.Actions
{
    public class DiskSharingActions
    {
        private readonly UserRepository _userRepository;

        private readonly SharedItemRepository _sharedItemRepository = RepositoryFactory.Create<SharedItemRepository>();

        private readonly FolderRepository _folderRepository;

        private readonly FileRepository _filesRepository;

        private readonly DiskActionHelper _commandHelper;

        private readonly User _user;//makni

        public DiskSharingActions(UserRepository userRepository, User user, FolderRepository folderRepository, FileRepository fileRepository, DiskActionHelper commandHelper)
        {
            _userRepository = userRepository;
            _user = user;
            _folderRepository = folderRepository;
            _filesRepository = fileRepository;
            _commandHelper = commandHelper;
        }

        public void ShareItem(string command)
        {
            var itemPart = 1;
            var userPart = 3;

            var (itemName, userEmail) = Reader.ParseShareCommand(command, 4, itemPart, userPart);
            if (itemName == null || userEmail == null) return;

            var userToReceiveItem = _userRepository.GetByEmail(userEmail);
            if (userToReceiveItem is null)
            {
                Writer.DisplayError($"User {userEmail} does not exist\n");
                return;
            }

            var selectedItem = GetItemByName(itemName);
            if (selectedItem == null) return;

            if (Reader.IsAlreadyShared(itemName, userToReceiveItem.UserId, _sharedItemRepository)) return;

            ShareSelectedItem(selectedItem, userToReceiveItem, itemName, userEmail);

            if (selectedItem is Folder folder)
            {
                ShareFolderContents(folder, userToReceiveItem);
            }
        }

        private Item? GetItemByName(string itemName)
        {
            var itemFile = _commandHelper.GetFilesInCurrentLocation().Find(f => f.Name == itemName);
            var itemFolder = _commandHelper.GetFoldersInCurrentLocation().Find(f => f.Name == itemName);

            if (itemFile is not null)
            {
                return itemFile;
            }
            else if (itemFolder is not null)
            {
                return itemFolder;
            }
            else
            {
                Writer.DisplayError($"Item {itemName} does not exist\n");
                return null;
            }
        }

        private void ShareSelectedItem(Item selectedItem, User userToReceiveItem, string itemName, string userEmail)
        {
            var itemToShare = new SharedItem(selectedItem.ItemId, userToReceiveItem.UserId, selectedItem.Name);
            var result = _sharedItemRepository.Add(itemToShare);

            if (result == ResponseResultType.Success)
            {
                Writer.DisplaySuccess($"Item {itemName} shared with user {userEmail}\n");
            }
            else
            {
                Writer.DisplayError($"Failed to share item {itemName} with user {userEmail}\n");
            }
        }

        private void ShareFolderContents(Folder folder, User userToReceiveItem)
        {
            foreach (var subFolder in folder.Items.OfType<Folder>())
            {
                var sharedSubFolder = new SharedItem(subFolder.ItemId, userToReceiveItem.UserId, subFolder.Name);
                _sharedItemRepository.Add(sharedSubFolder);
                ShareFolderContents(subFolder, userToReceiveItem);
            }

            foreach (var file in folder.Items.OfType<Files>())
            {
                var sharedFile = new SharedItem(file.ItemId, userToReceiveItem.UserId, file.Name);
                _sharedItemRepository.Add(sharedFile);
            }
        }

        public void StopSharingItem(string command)
        {
            var itemPart = 2;
            var userPart = 4;

            var (itemName, userEmail) = Reader.ParseShareCommand(command, 5, itemPart, userPart);
            if (itemName == null || userEmail == null) return;

            var user = _userRepository.GetByEmail(userEmail);
            if (user is null)
            {
                Writer.DisplayError($"User {userEmail} does not exist\n");
                return;
            }

            var sharedItem = GetSharedItem(itemName, user.UserId);
            if (sharedItem == null) return;

            StopSharing(sharedItem, itemName, userEmail);
        }

        private SharedItem? GetSharedItem(string itemName, int userId)
        {
            var sharedItem = _sharedItemRepository.GetByNameAndUserId(itemName, userId);
            if (sharedItem == null)
            {
                Writer.DisplayError($"Item {itemName} is not shared or does not exist\n");
            }
            return sharedItem;
        }

        private void StopSharing(SharedItem sharedItem, string itemName, string userEmail)
        {
            var result = _sharedItemRepository.Delete(sharedItem.SharedItemId);
            if (result == ResponseResultType.Success)
            {
                Writer.DisplaySuccess($"You stopped sharing item {itemName} with user {userEmail}\n");
            }
            else
            {
                Writer.DisplayError($"Failed to stop sharing item {itemName} with user {userEmail}\n");
            }
        }

    }
}
