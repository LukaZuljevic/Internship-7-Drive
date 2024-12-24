using Drive.Data.Entities.Models;
using Drive.Domain.Enums;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Actions
{
    public class CommentActions
    {
        private readonly CommentRepository _commentRepository;
        private readonly int _itemId;
        User _user;
        public CommentActions(CommentRepository commentRepository, int itemId, User user)
        {
            _commentRepository = commentRepository;
            _itemId = itemId;
            _user = user;
        }

        public void Open()
        {
 
            var commentCommandActions = new CommentCommandActions(_commentRepository, _itemId, _user);
            commentCommandActions.OpenComments();

            while (true)
            {
                Reader.TryReadInput("Enter a command ('help' to see all commands, 'exit' to quit navigation)", out var command);
                command = command.Trim();

                switch (command)
                {
                    case var _ when Reader.IsCommand(command, "help"):
                        Writer.PrintCommentCommands();
                        break;
                    case var _ when Reader.IsCommand(command, "dodaj komentar"):
                        commentCommandActions.AddComment();
                        break;
                    case var _ when Reader.IsCommand(command, "uredi komentar"):
                        commentCommandActions.EditComment();
                        break;
                    case var _ when Reader.IsCommand(command, "izbrisi komentar"):
                        commentCommandActions.DeleteComment();
                        break;
                    default:
                        Writer.DisplayError("Invalid command. Try again.\n");
                        break;
                }
                if (Reader.IsCommand(command, "exit"))
                    break;
            }
        }
    }
}
