using Drive.Data.Entities.Models;
using Drive.Domain.Repositories;
using Drive.Presentation.Abstractions;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Actions
{
    public class DiskActions : IAction
    {
        private readonly User _user;

        private readonly UserRepository _userRepository;

        private readonly Stack<Folder?> _folderHistory;

        private readonly CurrentFolder _currentFolder;

        private readonly CommentRepository _commentRepository;

        private readonly FolderRepository _folderRepository;

        private readonly FileRepository _filesRepository;
        public string ActionName { get; set; } = "My Disk";
        public DiskActions(CurrentFolder currentFolder, CommentRepository commentRepository, FolderRepository folderRepository, FileRepository fileRepository, Stack<Folder?> folderHistory,UserRepository userRepository ,User user)
        {
            _folderHistory = folderHistory;
            _userRepository = userRepository;
            _user = user;
            _commentRepository = commentRepository;
            _folderRepository = folderRepository;
            _filesRepository = fileRepository;
            _currentFolder = new CurrentFolder();
        }

        public void Open()
        {
            Console.Clear();
            var commandHelper = new DiskActionHelper(_user, _userRepository, _currentFolder);

            var navigationActions = new DiskNavigationActions(_currentFolder, _folderHistory, commandHelper);
            var sharingActions = new DiskSharingActions(_userRepository, _user, commandHelper);
            var itemActions = new DiskItemActions(_commentRepository, _folderRepository, _filesRepository, _userRepository, _user, commandHelper);

            commandHelper.DisplayFolderContents();

            var commandDictionary = new Dictionary<Func<string, bool>, Action<string>>
            {
                { command => Reader.IsCommand(command, "help"), _ => Writer.PrintCommands() },
                { command => Reader.StartsWithCommand(command, "stvori mapu"), itemActions.CreateFolderInCurrentLocation },
                { command => Reader.StartsWithCommand(command, "stvori datoteku"), itemActions.CreateFileInCurrentLocation},
                { command => Reader.StartsWithCommand(command, "udi u mapu"), navigationActions.NavigateToFolder },
                { command => Reader.StartsWithCommand(command, "uredi datoteku"), itemActions.EditFileContents },
                { command => Reader.StartsWithCommand(command, "izbrisi"), itemActions.DeleteItem },
                { command => Reader.StartsWithCommand(command, "promjeni naziv"), itemActions.ChangeItemName },
                { command => Reader.StartsWithCommand(command, "podijeli"), sharingActions.ShareItem },
                { command => Reader.StartsWithCommand(command, "prestani dijeliti"), sharingActions.StopSharingItem },
                { command => Reader.IsCommand(command, "nazad"), _ => navigationActions.ReturnToPreviousFolder() },
            };

            Reader.TryReadCommand(commandDictionary);
        }
    }
}
