﻿using Drive.Data.Entities.Models;
using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Presentation.Abstractions;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Actions
{
    public class ViewDiskContentAction : IAction
    {
        private readonly DiskRepository _diskRepository;
        private readonly UserRepository _userRepository = RepositoryFactory.Create<UserRepository>();
        private readonly Stack<Folder?> _folderHistory = new Stack<Folder?>();
        private Folder? _currentFolder = null;

        public string ActionName { get; set; } = "View All Items";
        public User User { get; set; }

        public ViewDiskContentAction(DiskRepository diskRepository, User user)
        {
            _diskRepository = diskRepository;
            User = user;
        }

        public void Open()
        {
            Console.Clear();

            var commandActions = new CommandActions(_currentFolder, _folderHistory, _userRepository, User);

            commandActions.PrintCurrentFolderContent();

            while (true)
            {
                Reader.TryReadInput("Enter a command ('help' to see all commands, 'exit' to quit navigation)", out var command);
                command = command.Trim();

                switch (true)
                {
                    case var _ when Reader.IsCommand(command, "help"):
                        Writer.PrintCommands();
                        break;
                    case var _ when Reader.StartsWithCommand(command, "stvori mapu"):
                        commandActions.CreateFolderInCurrentLocation(command);
                        break;
                    case var _ when Reader.StartsWithCommand(command, "udi u mapu"):
                        commandActions.NavigateToFolder(command);
                        break;
                    case var _ when Reader.IsCommand(command, "nazad"):
                        commandActions.ReturnToPreviousFolder();
                        break;
                    default:
                        Writer.DisplayError("Invalid command. Try again.");
                        break;
                }

                if (Reader.IsCommand(command, "exit"))
                    break;
            }
        }
    }
}
