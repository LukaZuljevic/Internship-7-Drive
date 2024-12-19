using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Presentation.Abstractions;
using Drive.Presentation.Helpers;
using Drive.Data.Entities.Models;
using Drive.Presentation.Extensions;


namespace Drive.Presentation.Actions
{
    public class DiskActions : IAction
    {
        private static DiskRepository DiskRepository;
        public string ActionName { get; set; } = "My disk";
        public User User { get; set; }
        public DiskActions(DiskRepository diskRepository, User user)
        {
            DiskRepository = diskRepository;
            User = user;
        }

        public void Open()
        {
            Writer.DisplayInfo("========== My Disk ==========");

            var actions = new List<IAction>
            {
                new PrintAllDiskItemsAction(DiskRepository, User),
                //new DiskAddItemAction(_diskRepository, User),
                //new DiskDeleteItemAction(_diskRepository, User),
                //new DiskShareItemAction(_diskRepository, User),
                new ExitMenuAction()
            };

            actions.PrintActions();
        }
    }
}
