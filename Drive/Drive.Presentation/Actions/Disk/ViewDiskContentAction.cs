using Drive.Data.Entities.Models;
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
            Writer.DisplayInfo("========== My Disk ==========\n");

            var commandActions = new CommandActions(_currentFolder, _folderHistory, _userRepository, User);
            commandActions.PrintCurrentFolderContent(); 

            commandActions.Open(); 
        }
    }
}
