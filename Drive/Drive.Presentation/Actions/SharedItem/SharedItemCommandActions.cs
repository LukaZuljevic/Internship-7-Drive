using Drive.Data.Entities.Models;
using Drive.Domain.Factories;
using Drive.Domain.Repositories;

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

            foreach(var sharedItem in sharedItems) 
            {
                var item = _itemRepository.GetByItemId(sharedItem.ItemId);

                if(item is not null)
                   items.Add(item);
            }

            foreach(var item in items)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
