using Drive.Presentation.Abstractions;
using Drive.Domain.Repositories;
using Drive.Data.Entities.Models;
using Drive.Presentation.Extensions;

namespace Drive.Presentation.Actions
{
    public class SharedItemsActions : IAction
    {
        private readonly SharedItemRepository SharedItemRepository;
        public string ActionName { get; set; } = "Shared items";
        User User { get; set; }
        public SharedItemsActions(SharedItemRepository sharedItemRepository, User user)
        {
            SharedItemRepository = sharedItemRepository;
            User = user;
        }

        public void Open()
        {

            var actions = new List<IAction>
            {
                new ExitMenuAction()
            };

            actions.PrintActions();
        }
    }
}
