﻿using Drive.Data.Entities.Models;
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

        private readonly CurrentFolder? _currentFolder;

        private readonly FolderRepository _folderRepository;

        private readonly FileRepository _filesRepository;

        private readonly ItemRepository _itemRepository;

        private readonly User _user;

        public DiskItemActions(ItemRepository itemRepository, CurrentFolder? currentFolder, CommentRepository commentRepository, FolderRepository folderRepository, FileRepository filesRepository, UserRepository userRepository, User user, DiskActionHelper commandHelper)
        {
            _itemRepository = itemRepository;
            _commentRepository = commentRepository;
            _folderRepository = folderRepository;
            _filesRepository = filesRepository;
            _userRepository = userRepository;
            _user = user;
            _currentFolder = currentFolder;
            _commandHelper = commandHelper;
        }

        public DiskItemActions(DiskActionHelper commandHelper, FileRepository filesRepository, UserRepository userRepository, CommentRepository commentRepository) 
        {
            _commandHelper = commandHelper;
            _filesRepository = filesRepository;
            _userRepository = userRepository;
            _commentRepository = commentRepository;
        }

        public void CreateFolderInCurrentLocation(string command)
        {
            var folderName = command.Substring("stvori mapu".Length).Trim();

            if (!CheckIfValidName(folderName))
                return;

            if (!Reader.ConfirmAction($"Are you sure you want to create folder '{folderName}'?"))
                return;

            var newFolder = _commandHelper.CreateFolder(folderName);

            _folderRepository.Add(newFolder);

            _commandHelper.DisplayFolderContents();
        }

        public void CreateFileInCurrentLocation(string command)
        {
            var fileName = command.Substring("stvori datoteku".Length).Trim();

            if(!CheckIfValidName(fileName))
                return;

            if (!Reader.ConfirmAction($"Are you sure you want to create file '{fileName}'?"))
                return;

            var newFile = _commandHelper.CreateFile(fileName);

            _filesRepository.Add(newFile);

            _commandHelper.DisplayFolderContents();
        }

        private bool CheckIfValidName(string name)
        {
            if (_commandHelper.IsNameDuplicate(name))
                return false;

            if (name.Length == 0)
            {
                Writer.DisplayError("Name cannot be empty\n");
                return false;
            }

            return true;
        }

        public void DeleteItem(string command)
        {

            var itemName = string.Empty;
            var itemType = string.Empty;

            (itemType, itemName) = ParseDeleteCommand(command);

            if (itemType == null && itemName == null)
                return;

            if (!Reader.ConfirmAction($"Are you sure you want to delete '{itemName}'?"))
                return;

            var currentFolderId = _currentFolder?.Folder?.ItemId ?? null;
            var item = _itemRepository.GetByName(itemName, currentFolderId, itemType);

            if (item is not null)
            {
                _itemRepository.Delete(item.ItemId);
                _commandHelper.DisplayFolderContents();
            }
            else
            {
                Writer.DisplayError($"{(itemType == "folder" ? "Folder" : "File")} {itemName} does not exist in this location\n");
            }
        }

        private static (string? itemType, string? itemName) ParseDeleteCommand(string command)
        {
            string? itemType = null;
            string? itemName = null;

            if (Reader.StartsWithCommand(command, "izbrisi mapu"))
            {
                itemType = "folder";
                itemName = command.Substring("izbrisi mapu".Length).Trim();
            }
            else if (Reader.StartsWithCommand(command, "izbrisi datoteku"))
            {
                itemType = "file";
                itemName = command.Substring("izbrisi datoteku".Length).Trim();
            }
            else
            {
                Writer.DisplayError("Invalid command. Try again.\n");
                return (null, null);
            }

            return (itemType, itemName);
        }

        public void ChangeItemName(string command)
        {
            var oldNamePart = 3;
            var newNamePart = 5;

            var (oldName, newName) = Reader.ParseShareCommand(command, 6, oldNamePart, newNamePart);
            if (oldName == null || newName == null) 
                return;

            if (_commandHelper.IsNameDuplicate(newName))
                return;

            if (!Reader.ConfirmAction($"Are you sure you want to rename '{oldName}'?"))
                return;

            if (Reader.StartsWithCommand(command, "promjeni naziv mape"))
            {
               RenameFolder(oldName, newName);
            }
            else if (Reader.StartsWithCommand(command, "promjeni naziv datoteke"))
            {
                RenameFile(oldName, newName);
            }
        }

        private void RenameFolder(string oldName, string newName)
        {
            var folder = _folderRepository.GetByName(oldName, _user);
            if (folder is null)
            {
                Writer.DisplayError($"Folder {oldName} does not exist\n");
                return;
            }

            folder.Name = newName;
            var result = _folderRepository.Update(folder, folder.ItemId);

            if (result != ResponseResultType.Success)
            {
                Writer.DisplayError($"Failed to rename folder '{oldName}'. Please try again.\n");
                return;
            }

            _commandHelper.DisplayFolderContents();
        }

        private void RenameFile(string oldName, string newName)
        {
            var file = _filesRepository.GetByName(oldName, _user);
            if (file is null)
            {
                Writer.DisplayError($"File {oldName} does not exist\n");
                return;
            }

            file.Name = newName;
            var result = _filesRepository.Update(file, file.ItemId);
             
            if (result != ResponseResultType.Success)
            {
                Writer.DisplayError($"Failed to rename file '{oldName}'. Please try again.\n");
                return;
            }

            _commandHelper.DisplayFolderContents();
        }

        public void EditFileContents(string command, bool isShared)
        {
            var fileName = command.Substring("uredi datoteku".Length).Trim();
            var file = _commandHelper.GetFile(fileName, isShared);

            if (file == null)
            {
                Writer.DisplayError($"File {fileName} does not exist or is not shared with you\n");
                return;
            }

            Console.Clear();

            var fileContent = file.Content;
            var lines = string.IsNullOrEmpty(fileContent)
                ? new List<string>()
                : fileContent.Trim().Split('\n').Where(line => !string.IsNullOrEmpty(line)).ToList();

            EditFile(lines, file, fileName, isShared);
        }

        private void EditFile(List<string> lines, Files file, string fileName, bool isShared)
        {
            int activeLineIndex = lines.Count;

            while (true)
            {
                Writer.PrintFileContents(lines);
                Console.Write("> ");
                var input = Console.ReadLine().Trim();

                if (ProcessInput(input, lines, ref activeLineIndex, file, fileName, isShared))
                    return;
            }
        }

        private bool ProcessInput(string input, List<string> lines, ref int activeLineIndex, Files file, string fileName, bool isShared)
        {
            switch (input)
            {
                case ":save":
                    SaveFile(lines, file, fileName, isShared);
                    return true;

                case ":cancel":
                    CancelEditing(isShared);
                    return true;

                case ":help":
                    Writer.PrintFileEditCommands();
                    Reader.PressAnyKey();
                    return false;

                case ":otvori komentare":
                    OpenComments(file.ItemId);
                    return false;

                default:
                    HandleDefaultInput(input, lines, ref activeLineIndex);
                    return false;
            }
        }

        private void SaveFile(List<string> lines, Files file, string fileName, bool isShared)
        {
            var contents = string.Join("\n", lines);
            var updatedFile = new Files(fileName, contents, file.ParentFolderId, file.DiskId);
            _filesRepository.Update(updatedFile, file.ItemId);

            file.Content = updatedFile.Content;

            Writer.DisplayInfo("\nSaving...");
            Reader.PressAnyKey();

            if (isShared)
                _commandHelper.DisplaySharedItems();
            else
                _commandHelper.DisplayFolderContents();
        }

        private void CancelEditing(bool isShared)
        {
            Writer.DisplayInfo("\nExiting without saving...");
            Reader.PressAnyKey();

            if (isShared)
                _commandHelper.DisplaySharedItems();
            else
                _commandHelper.DisplayFolderContents();
        }

        private void OpenComments(int itemId)
        {
            var commentActions = new CommentActions(_userRepository, _commentRepository, itemId, _user);
            commentActions.Open();
        }

        private void HandleDefaultInput(string input, List<string> lines, ref int activeLineIndex)
        {
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
        }

    }
}
