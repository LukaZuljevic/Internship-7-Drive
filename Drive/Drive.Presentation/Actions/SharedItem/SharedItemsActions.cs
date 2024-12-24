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
        private static SharedItemRepository _sharedItemRepository;
        User User { get; set; }

        public string ActionName { get; set; } = "Shared With Me";
        public SharedItemsActions(SharedItemRepository sharedItemRepository, User user)
        {
            _sharedItemRepository = sharedItemRepository;
            User = user;
        }

        public void Open()
        {

            Console.Clear();

            var sharedItemCommandActions = new SharedItemCommandActions(_sharedItemRepository, User);
            sharedItemCommandActions.DisplaySharedItems();

            while (true)
            {

                Reader.TryReadInput("Enter a command ('help' to see all commands, 'exit' to quit navigation)", out var command);
                command = command.Trim();

                switch (true)
                {
                    case var _ when Reader.IsCommand(command, "help"):
                        Writer.PrintReducedCommands();
                        break;
                    case var _ when Reader.StartsWithCommand(command, "izbrisi"):
                        sharedItemCommandActions.DeleteSharedItem(command);
                        break;
                    default:
                        Writer.DisplayError("Invalid command. Try again.\n");
                        break;
                }

                if (Reader.IsCommand(command, "exit"))
                    break;
            }       
        }
    }
}
