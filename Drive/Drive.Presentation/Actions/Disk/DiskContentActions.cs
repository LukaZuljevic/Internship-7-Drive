using Drive.Data.Entities.Models;
using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Presentation.Abstractions;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Actions
{
    public class DiskContentActions : IAction
    {
        private readonly UserRepository _userRepository = RepositoryFactory.Create<UserRepository>();
        private readonly Stack<Folder?> _folderHistory = new Stack<Folder?>();
        private readonly Folder? _currentFolder = null;

        public string ActionName { get; set; } = "My Disk";
        public User User { get; set; }

        public DiskContentActions(User user)
        {
            User = user;
        }

        public void Open()
        {
            Console.Clear();

            var commandActions = new CommandActions(_currentFolder, _folderHistory, _userRepository, User);
            commandActions.DisplayFolderContents();

            var commandDictionary = new Dictionary<string, Action<string>>
            {
                { "help", _ => Writer.PrintCommands() },
                { "stvori mapu", commandActions.CreateFolderInCurrentLocation },
                { "stvori datoteku", commandActions.CreateFileInCurrentLocation },
                { "udi u mapu", commandActions.NavigateToFolder },
                { "uredi datoteku", commandActions.EditFileContents },
                { "nazad", _ => commandActions.ReturnToPreviousFolder() },
                { "izbrisi", commandActions.DeleteItem },
                { "promjeni naziv", commandActions.ChangeItemName },
                { "podijeli", commandActions.ShareItem },
                { "prestani dijeliti", commandActions.StopSharingItem }
            };

            while (true)
            {
                Reader.TryReadInput("Enter a command ('help' to see all commands, 'exit' to quit navigation)", out var command);
                command = command.Trim();

                if (Reader.IsCommand(command, "exit"))
                    break;

                var matchedCommand = commandDictionary.Keys.FirstOrDefault(key => Reader.IsCommand(command, key) || Reader.StartsWithCommand(command, key));

                if (matchedCommand != null)
                {
                    commandDictionary[matchedCommand](command);
                }
                else
                {
                    Writer.DisplayError("Invalid command. Try again.\n");
                }
            }
        }

    }
}