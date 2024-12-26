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
            var sharedFile = _sharedItemRepository.GetByNameAndUserId(fileName, _user.UserId);

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
                    case ":otvori komentare":
                        var commentActions = new CommentActions(_userRepository, _commentRepository, file.ItemId, _user);
                        commentActions.Open();
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
