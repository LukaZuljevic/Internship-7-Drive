using Drive.Presentation.Abstractions;
using Drive.Domain.Repositories;
using Drive.Data.Entities.Models;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Actions
{
    public class SharedItemsActions : IAction
    {
        private readonly SharedItemRepository _sharedItemRepository;

        private readonly FileRepository _fileRepository;

        private readonly ItemRepository _itemRepository;

        private readonly CommentRepository _commentRepository;

        private readonly UserRepository _userRepository;

        private readonly User _user;
        public string ActionName { get; set; } = "Shared With Me";
        public SharedItemsActions(FileRepository fileRepository, ItemRepository itemRepository, CommentRepository commentRepository, UserRepository userRepository,SharedItemRepository sharedItemRepository, User user)
        {
            _fileRepository = fileRepository;
            _itemRepository = itemRepository;
            _commentRepository = commentRepository;
            _userRepository = userRepository;
            _sharedItemRepository = sharedItemRepository;
            _user = user;
        }

        public void Open()
        {
            Console.Clear();

            var commandHelper = new DiskActionHelper(_itemRepository, _sharedItemRepository, _user);
            var sharingActions = new DiskSharingActions(_user,_itemRepository, _sharedItemRepository, _userRepository, commandHelper);
            var sharedItemActions = new SharedItemCommandActions(_sharedItemRepository, _itemRepository, _user, sharingActions);
            var itemActions = new DiskItemActions(commandHelper, _fileRepository, _userRepository, _commentRepository);

            commandHelper.DisplaySharedItems();

            var commandDictionary = new Dictionary<Func<string, bool>, Action<string>>
            {
                  { command => Reader.IsCommand(command, "help"), _ => Writer.PrintReducedCommands() },

                  { command => Reader.StartsWithCommand(command, "izbrisi"), sharedItemActions.DeleteSharedItem },

                  { command => Reader.StartsWithCommand(command, "uredi datoteku"), command => itemActions.EditFileContents(command, true) }
            };

            Reader.TryReadCommand(commandDictionary);
        }

    }
}
