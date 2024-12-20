using Drive.Presentation.Abstractions;
using Drive.Data.Entities.Models;
using Drive.Presentation.Actions;
using Drive.Domain.Repositories;
using Drive.Domain.Factories;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Factories
{
    public class DiskMenuFactory
    {
        public static IList<IAction> CreateActions(User user)
        {
            var actions = new List<IAction>
            {
                new PrintDiskItemsAction(RepositoryFactory.Create<DiskRepository>(), user),
                new ExitAppAction(),
            };

            return actions;
        }
    }
}
