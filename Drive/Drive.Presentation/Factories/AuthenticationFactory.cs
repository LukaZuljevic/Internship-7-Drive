using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Presentation.Abstractions;
using Drive.Presentation.Actions;
using Drive.Presentation.Actions.Authentications;


namespace Drive.Presentation.Factories
{
    public class AuthenticationFactory
    {
        public static IList<IAction> CreateActions()
        {
            var actions = new List<IAction>
            {
                new RegisterAction(RepositoryFactory.Create<UserRepository>()),
                new ExitMenuAction()
            };

            return actions;
        }
    }
}
