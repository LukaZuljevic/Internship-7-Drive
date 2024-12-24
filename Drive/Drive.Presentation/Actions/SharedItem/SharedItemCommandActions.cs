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

        private readonly FolderRepository _folderRepository = RepositoryFactory.Create<FolderRepository>();

        private readonly FileRepository _fileRepository = RepositoryFactory.Create<FileRepository>();

        private readonly ItemRepository _itemRepository = RepositoryFactory.Create<ItemRepository>();

        User User { get; set; }

        public SharedItemCommandActions(SharedItemRepository sharedItemRepository, User user)
        {
            _sharedItemRepository = sharedItemRepository;
            User = user;
        }

        public void DisplaySharedItems()
        {
            var sharedItems = _sharedItemRepository.GetByUserId(User.UserId);

            List<Item> items = new List<Item>();

            //stavi u funkciju
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

            var sharedItem = _sharedItemRepository.GetByNameAndUserId(itemName, User.UserId);

            if (sharedItem is null)
            {
                Writer.DisplayError($"Item {itemName} not found.\n");
                return;
            }

            var result = _sharedItemRepository.Delete(sharedItem.SharedItemId);

            if (result == ResponseResultType.Success)
            {
                DisplaySharedItems();
            }
            else
            {
                Writer.DisplayError("Failed to delete an item.\n");
                Reader.PressAnyKey();
            }
        }
    }
}
