using Drive.Data.Entities.Models;
using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;
using Drive.Domain.Enums;

namespace Drive.Presentation.Actions
{
    public class SharedItemCommandActions
    {
        private readonly SharedItemRepository _sharedItemRepository;

        private readonly FileRepository _fileRepository;

        private readonly ItemRepository _itemRepository;

        private readonly CommentRepository _commentRepository;

        private readonly UserRepository _userRepository;

        private readonly User _user;

        public SharedItemCommandActions(SharedItemRepository sharedItemRepository, FileRepository fileRepository, ItemRepository itemRepository, CommentRepository commentRepository, UserRepository userRepository, User user)
        { 
            _sharedItemRepository = sharedItemRepository;
            _fileRepository = fileRepository;
            _itemRepository = itemRepository;
            _commentRepository = commentRepository;
            _userRepository = userRepository;
            _user = user;
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
        public void DeleteSharedItem(string command)
        {
            var itemName = command.Substring("izbrisi".Length).Trim();

            var sharedItem = _sharedItemRepository.GetByNameAndUserId(itemName, _user.UserId);

            if (sharedItem is null)
            {
                Writer.DisplayError($"Item {itemName} not found.\n");
                return;
            }

            var result = _sharedItemRepository.Delete(sharedItem.SharedItemId);

            if (result != ResponseResultType.Success)
            {
                Writer.DisplayError("Failed to delete an item.\n");
                Reader.PressAnyKey();
                return;
            }

            DisplaySharedItems();
        }
    }
}
