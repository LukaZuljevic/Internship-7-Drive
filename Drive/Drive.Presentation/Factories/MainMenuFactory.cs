using Drive.Presentation.Abstractions;
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
                new DiskContentActions(RepositoryFactory.Create<DiskRepository>(), user),
                new SharedItemsActions(RepositoryFactory.Create<SharedItemRepository>(), user),
                new ChangeProfileSettingsActions(RepositoryFactory.Create<UserRepository>(), user),
                new LogoutAction(),
            };

            return actions;
        }
    }
}
