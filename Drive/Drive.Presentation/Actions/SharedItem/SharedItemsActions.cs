using Drive.Presentation.Abstractions;
using Drive.Domain.Repositories;
using Drive.Data.Entities.Models;
using Drive.Presentation.Extensions;
using Drive.Presentation.Helpers;
using Drive.Domain.Factories;

namespace Drive.Presentation.Actions
{
    public class SharedItemsActions : IAction
    {
        private readonly SharedItemRepository _sharedItemRepository;

        private readonly FileRepository _fileRepository = RepositoryFactory.Create<FileRepository>();

        private readonly ItemRepository _itemRepository = RepositoryFactory.Create<ItemRepository>();

        private readonly CommentRepository _commentRepository = RepositoryFactory.Create<CommentRepository>();

        private readonly UserRepository _userRepository = RepositoryFactory.Create<UserRepository>();

        private readonly User _user;
        public string ActionName { get; set; } = "Shared With Me";
        public SharedItemsActions(SharedItemRepository sharedItemRepository, User user)
        {
            _sharedItemRepository = sharedItemRepository;
            _user = user;
        }

        public void Open()
        {
            Console.Clear();

            var commandHelper = new DiskActionHelper(_itemRepository, _sharedItemRepository, _user);
            var sharedItemCommandActions = new SharedItemCommandActions(_sharedItemRepository, _fileRepository, _itemRepository, _commentRepository, _userRepository, _user);
            var itemActions = new DiskItemActions(commandHelper, _fileRepository, _userRepository, _commentRepository);

            commandHelper.DisplaySharedItems();

            var commandDictionary = new Dictionary<Func<string, bool>, Action<string>>
            {
                  { command => Reader.IsCommand(command, "help"), _ => Writer.PrintReducedCommands() },
                  { command => Reader.StartsWithCommand(command, "izbrisi"), sharedItemCommandActions.DeleteSharedItem },
                  { command => Reader.StartsWithCommand(command, "uredi datoteku"), command => itemActions.EditFileContents(command, true) }
            };

            Reader.TryReadCommand(commandDictionary);
        }

    }
}
