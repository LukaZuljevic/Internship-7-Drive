using Drive.Data.Entities.Models;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;
using Drive.Domain.Enums;

namespace Drive.Presentation.Actions
{
    public class SharedItemCommandActions
    {
        private readonly SharedItemRepository _sharedItemRepository;

        private readonly ItemRepository _itemRepository;

        private readonly DiskSharingActions _diskSharingActions;

        private readonly User _user;

        public SharedItemCommandActions(SharedItemRepository sharedItemRepository, ItemRepository itemRepository, User user, DiskSharingActions diskSharingActions)
        {
            _sharedItemRepository = sharedItemRepository;
            _itemRepository = itemRepository;
            _user = user;
            _diskSharingActions = diskSharingActions;
        }
        public void DeleteSharedItem(string command)
        {
            var itemName = command.Substring("izbrisi".Length).Trim();

            var sharedItem = _diskSharingActions.GetSharedItem(itemName, _user.UserId);
            if (sharedItem == null) return;

            var fullSharedItem = _itemRepository.GetByItemId(sharedItem.ItemId);

            if (fullSharedItem is Folder folder)
                _diskSharingActions.StopSharingFolderContents(folder, _user.UserId);
           
            var result = _sharedItemRepository.Delete(sharedItem.SharedItemId);

            if (result != ResponseResultType.Success)
            {
                Writer.DisplayError("Failed to delete an item.\n");
                Reader.PressAnyKey();
                return;
            }

            DisplayAllSharedItems();
        }

        public void DisplayAllSharedItems()
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
    }
}
