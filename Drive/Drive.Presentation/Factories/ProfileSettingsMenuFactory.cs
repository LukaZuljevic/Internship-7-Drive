using Drive.Data.Entities.Models;
using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Presentation.Abstractions;
using Drive.Presentation.Actions;

namespace Drive.Presentation.Factories
{
    public class ProfileSettingsMenuFactory
    {
        public static IList<IAction> CreateActions(User user)
        {
            var actions = new List<IAction>
            {
                new ChangeEmailAction(RepositoryFactory.Create<UserRepository>(), user),
                new ChangePasswordAction(RepositoryFactory.Create<UserRepository>(), user),
                new LogoutAction(),
            };

            return actions;
        }
    }
}
