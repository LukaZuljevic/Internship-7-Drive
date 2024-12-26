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

        //private readonly DiskActionHelper _commandHelper;

        private readonly SharedItemRepository _sharedItemRepository = RepositoryFactory.Create<SharedItemRepository>();

        private readonly FolderRepository _folderRepository = RepositoryFactory.Create<FolderRepository>();

        private readonly FileRepository _filesRepository = RepositoryFactory.Create<FileRepository>();

        private readonly User _user;

        public DiskSharingActions(UserRepository userRepository, User user, DiskActionHelper commandHelper)
        {
            _userRepository = userRepository;
            _user = user;
            //_commandHelper = commandHelper;
        }

  
        public void ShareItem(string command)
        {
            var commandParts = command.Split(" ");
            if (commandParts.Length < 4)
            {
                Writer.DisplayError("Invalid command. Try again.\n");
                return;
            }

            var itemName = commandParts[1];
            var userEmail = commandParts[3];

            var userToReceiveItem = _userRepository.GetByEmail(userEmail);
            if (userToReceiveItem is null)
            {
                Writer.DisplayError($"User {userEmail} does not exits\n");
                return;
            }

            var itemFile = _filesRepository.GetByName(itemName, _user);
            var itemFolder = _folderRepository.GetByName(itemName, _user);
            if (itemFile is null && itemFolder is null)
            {
                Writer.DisplayError($"Item {itemName} does not exist\n");
                return;
            }

            var sharedItem = _sharedItemRepository.GetByNameAndUserId(itemName, userToReceiveItem.UserId);
            if (sharedItem is not null)
            {
                Writer.DisplayError($"Item {itemName} is already being shared\n");
                return;
            }

            Item selectedItem = itemFolder is null ? itemFile : itemFolder;

            if (selectedItem is null)
                Console.WriteLine($"No file or folder found with name {itemName}.\n");

            if (userToReceiveItem is null)
            {
                Writer.DisplayError($"User {userEmail} does not exits\n");
                return;
            }

            SharedItem itemToShare = new SharedItem(selectedItem.ItemId, userToReceiveItem.UserId, selectedItem.Name);
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

        public void StopSharingItem(string command)
        {
            var commandParts = command.Split(" ");
            if (commandParts.Length < 5)
            {
                Writer.DisplayError("Invalid command. Try again.\n");
                return;
            }

            var itemName = commandParts[2];
            var userEmail = commandParts[4];

            var user = _userRepository.GetByEmail(userEmail);
            if (user is null)
            {
                Writer.DisplayError($"User {userEmail} does not exits\n");
                return;
            }

            var sharedItem = _sharedItemRepository.GetByNameAndUserId(itemName, user.UserId);
            if (sharedItem is null)
            {
                Writer.DisplayError($"Item {itemName} is not shared or does not exist\n");
                return;
            }

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
