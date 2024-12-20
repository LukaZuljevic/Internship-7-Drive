using Drive.Domain.Repositories;
using Drive.Presentation.Abstractions;
using Drive.Data.Entities.Models;
using Drive.Presentation.Extensions;
using Drive.Presentation.Factories;


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
            var diskMenu = DiskMenuFactory.CreateActions(User);
            diskMenu.PrintActions("========== DUMP Drive ==========\n");
        }
    }
}
