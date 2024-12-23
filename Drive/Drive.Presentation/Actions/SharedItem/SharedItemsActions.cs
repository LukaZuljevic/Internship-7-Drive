using Drive.Presentation.Abstractions;
using Drive.Domain.Repositories;
using Drive.Data.Entities.Models;
using Drive.Presentation.Extensions;

namespace Drive.Presentation.Actions
{
    public class SharedItemsActions : IAction
    {
        private readonly SharedItemRepository _sharedItemRepository;
        public string ActionName { get; set; } = "Shared with me";
        User User { get; set; }
        public SharedItemsActions(SharedItemRepository sharedItemRepository, User user)
        {
            _sharedItemRepository = sharedItemRepository;
            User = user;
        }

        public void Open()
        {

            
        }
    }
}
