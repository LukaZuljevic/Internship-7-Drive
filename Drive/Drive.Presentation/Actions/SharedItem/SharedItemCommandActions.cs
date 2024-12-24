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

        public void EditSharedFileContents(string command)
        {
            var fileName = command.Substring("uredi datoteku".Length).Trim();            
            var sharedFile = _sharedItemRepository.GetByNameAndUserId(fileName, User.UserId);

            if (sharedFile is null)
            {    
                Writer.DisplayError($"File {fileName} is not shared with you\n");
                return;
            }

            var file = _fileRepository.GetById(sharedFile.ItemId);
            
            if (file == null)
            {
                Writer.DisplayError($"File {fileName} does not exist\n");
                return;
            }

            Console.Clear();

            var lines = string.IsNullOrEmpty(file.Content)
                ? new List<string>()
                : file.Content.Trim().Split('\n').Where(line => !string.IsNullOrEmpty(line)).ToList();

            int activeLineIndex = lines.Count;

            while (true)
            {
                Writer.PrintFileContents(lines);
                Console.Write("> ");
                var input = Console.ReadLine().Trim();

                switch (input.ToLower())
                {
                    case ":save":
                        var contents = string.Join("\n", lines);

                        Files newFile = new Files(fileName, contents, file.ParentFolderId, file.DiskId);

                        var result = _fileRepository.Update(newFile, file.ItemId);

                        Writer.DisplayInfo("\nSaving...");
                        Reader.PressAnyKey();

                        DisplaySharedItems();
                        return;

                    case ":cancel":
                        Writer.DisplayInfo("\nExiting without saving...");
                        Reader.PressAnyKey();

                        DisplaySharedItems();
                        return;

                    case ":help":
                        Writer.PrintFileEditCommands();
                        Reader.PressAnyKey();
                        break;

                    default:
                        if (string.IsNullOrEmpty(input))
                        {
                            if (activeLineIndex > 0)
                            {
                                activeLineIndex--;
                                lines.RemoveAt(activeLineIndex);
                                Writer.PrintFileContents(lines);
                            }
                        }
                        else
                        {
                            if (activeLineIndex < lines.Count)
                            {
                                lines[activeLineIndex] = input;
                            }
                            else
                            {
                                lines.Add(input);
                            }

                            activeLineIndex = lines.Count;
                        }
                        break;
                }
            }
        }

    }
}
