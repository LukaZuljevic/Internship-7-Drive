﻿using Drive.Presentation.Abstractions;
using Drive.Data.Entities.Models;
using Drive.Presentation.Actions;
using Drive.Domain.Repositories;
using Drive.Domain.Factories;

namespace Drive.Presentation.Factories
{
    public class MainMenuFactory
    {
        public static IList<IAction> CreateActions(User user)
        {
            var actions = new List<IAction>
            {
                new DiskActions(new CurrentFolder(), RepositoryFactory.Create<CommentRepository>(),RepositoryFactory.Create<FolderRepository>(),RepositoryFactory.Create<FileRepository>(),new Stack<Folder?>(), RepositoryFactory.Create<UserRepository>(),user),
                new SharedItemsActions(RepositoryFactory.Create<SharedItemRepository>(), user),
                new ChangeProfileSettingsActions(user),
                new LogoutAction("Logout"),
            };

            return actions;
        }
    }
}
