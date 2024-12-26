using Drive.Data.Entities.Models;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;
using Drive.Domain.Enums;

namespace Drive.Presentation.Actions
{
    public class DiskItemActions
    {
        private readonly DiskActionHelper _commandHelper;

        private readonly UserRepository _userRepository;

        private readonly CommentRepository _commentRepository;

        private readonly FolderRepository _folderRepository;

        private readonly FileRepository _filesRepository;

        private readonly User _user;

        public DiskItemActions(CommentRepository commentRepository, FolderRepository folderRepository, FileRepository filesRepository, UserRepository userRepository, User user, DiskActionHelper commandHelper)
        {
            _commentRepository = commentRepository;
            _folderRepository = folderRepository;
            _filesRepository = filesRepository;
            _userRepository = userRepository;
            _user = user;
            _commandHelper = commandHelper;
        }

        public void CreateFolderInCurrentLocation(string command)
        {
            var folderName = command.Substring("stvori mapu".Length).Trim();

            if (_commandHelper.IsNameDuplicate(folderName))
                return;

            if (folderName.Length == 0)
            {
                Writer.DisplayError("Folder name cannot be empty\n");
                return;
            }

            var newFolder = _commandHelper.CreateFolder(folderName);

            var result = _folderRepository.Add(newFolder);

            if (result != ResponseResultType.Success)
            {
                Writer.DisplayError($"Failed to create folder '{folderName}'. Please try again.\n");

            }

            _commandHelper.DisplayFolderContents();
        }

        public void CreateFileInCurrentLocation(string command)
        {
            var fileName = command.Substring("stvori datoteku".Length).Trim();

            if (_commandHelper.IsNameDuplicate(fileName))
                return;

            if (fileName.Length == 0)
            {
                Writer.DisplayError("File name cannot be empty\n");
                return;
            }

            var newFile = _commandHelper.CreateFile(fileName);

            var result = _filesRepository.Add(newFile);

            if (result != ResponseResultType.Success)
            {
                Writer.DisplayError($"Failed to create folder '{fileName}'. Please try again.\n");

            }

            _commandHelper.DisplayFolderContents();
        }

        public void EditFileContents(string command)
        {
            var fileName = command.Substring("uredi datoteku".Length).Trim();

            var file = _filesRepository.GetByName(fileName, _user);

            if (file is null)
            {
                Writer.DisplayError($"File {fileName} does not exist\n");
                return;
            }

            Console.Clear();

            var lines = string.IsNullOrEmpty(file.Content)
                ? new List<string>()
                : file.Content.Trim().Split('\n').Where(line => !string.IsNullOrEmpty(line)).ToList();

            int activeLineIndex = lines.Count;

            while (true)
            {
                Writer.PrintFileContents(lines);
                Console.Write("> ");
                var input = Console.ReadLine().Trim();

                switch (input.ToLower())
                {
                    case ":save":
                        var contents = string.Join("\n", lines);

                        Files newFile = new Files(fileName, contents, file.ParentFolderId, file.DiskId);

                        var result = _filesRepository.Update(newFile, file.ItemId);

                        Writer.DisplayInfo("\nSaving...");
                        Reader.PressAnyKey();

                        _commandHelper.DisplayFolderContents();
                        return;

                    case ":cancel":
                        Writer.DisplayInfo("\nExiting without saving...");
                        Reader.PressAnyKey();

                        _commandHelper.DisplayFolderContents();
                        return;

                    case ":help":
                        Writer.PrintFileEditCommands();
                        Reader.PressAnyKey();
                        break;

                    case ":otvori komentare":
                        var commentActions = new CommentActions(_userRepository, _commentRepository, file.ItemId, _user);
                        commentActions.Open();
                        break;
                    default:
                        if (string.IsNullOrEmpty(input))
                        {
                            if (activeLineIndex > 0)
                            {
                                activeLineIndex--;
                                lines.RemoveAt(activeLineIndex);
                                Writer.PrintFileContents(lines);
                            }
                        }
                        else
                        {
                            if (activeLineIndex < lines.Count)
                            {
                                lines[activeLineIndex] = input;
                            }
                            else
                            {
                                lines.Add(input);
                            }

                            activeLineIndex = lines.Count;
                        }
                        break;
                }
            }
        }

        public void DeleteItem(string command)
        {
            var itemName = string.Empty;

            //pogledaj jel se sve ovo moze zaminit sa itemrepository
            if (Reader.StartsWithCommand(command, "izbrisi mapu"))
            {
                itemName = command.Substring("izbrisi mapu".Length).Trim();

                var folder = _folderRepository.GetByName(itemName, _user);

                if (folder != null)
                {
                    _folderRepository.Delete(folder.ItemId);
                    _commandHelper.DisplayFolderContents();
                }
                else
                {
                    Writer.DisplayError($"Folder {itemName} does not exist");
                }
            }
            else if (Reader.StartsWithCommand(command, "izbrisi datoteku"))
            {
                itemName = command.Substring("izbrisi datoteku".Length).Trim();

                var file = _filesRepository.GetByName(itemName, _user);

                if (file != null)
                {
                    _filesRepository.Delete(file.ItemId);
                    _commandHelper.DisplayFolderContents();
                }
                else
                {
                    Writer.DisplayError($"File {itemName} does not exist");
                }
            }

        }

        public void ChangeItemName(string command)
        {
            if (command.Split(" ").Length < 6)
            {
                Writer.DisplayError("Invalid command. Try again.\n");
                return;
            }
            var oldName = command.Split(" ")[3];
            var newName = command.Split(" ")[5];

            if (_commandHelper.IsNameDuplicate(newName))
                return;

            if (Reader.StartsWithCommand(command, "promjeni naziv mape"))
            {
                var folder = _folderRepository.GetByName(oldName, _user);

                if (folder != null)
                {
                    folder.Name = newName;
                    var result = _folderRepository.Update(folder, folder.ItemId);

                    if (result == ResponseResultType.Success)
                    {
                        _commandHelper.DisplayFolderContents();
                    }
                    else
                    {
                        Writer.DisplayError($"Failed to rename folder '{oldName}'. Please try again.\n");
                    }
                }
                else
                {
                    Writer.DisplayError($"Folder {oldName} does not exist");
                }
            }
            else if (Reader.StartsWithCommand(command, "promjeni naziv datoteke"))
            {
                var file = _filesRepository.GetByName(oldName, _user);

                if (file != null)
                {
                    file.Name = newName;
                    var result = _filesRepository.Update(file, file.ItemId);

                    if (result == ResponseResultType.Success)
                    {
                        _commandHelper.DisplayFolderContents();
                    }
                    else
                    {
                        Writer.DisplayError($"Failed to rename file '{oldName}'. Please try again.\n");
                    }
                }
                else
                {
                    Writer.DisplayError($"File {oldName} does not exist");
                }
            }
        }

    }
}
