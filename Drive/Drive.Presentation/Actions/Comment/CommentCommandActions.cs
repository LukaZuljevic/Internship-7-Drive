using Drive.Data.Entities.Models;
using Drive.Domain.Enums;
using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Actions
{
    public class CommentCommandActions
    {
        private static UserRepository userRepository = RepositoryFactory.Create<UserRepository>();
        private static CommentRepository _commentRepository;
        private static int _itemId;
        User _user;

        public CommentCommandActions(CommentRepository commentRepository, int itemId, User user)
        {
            _commentRepository = commentRepository;
            _itemId = itemId;
            _user = user;
        }

        public void OpenComments()
        {
            Console.Clear();

            var comments = _commentRepository.GetAll(_itemId);

            if (comments.Count == 0)
            {
                Writer.DisplayInfo("No comments found.\n");
                return;
            }

            Writer.PrintComments(comments, userRepository);
        }

        public void AddComment()
        {
            Console.Write("Enter your comment: ");
            string content = Console.ReadLine();

            var comment = new Comment(content, _user.UserId, _itemId);

            var result = _commentRepository.Add(comment);

            if (result != ResponseResultType.Success)
            {
                Writer.DisplayError("Failed to add comment.\n");
                return;
            }

            OpenComments();
        }

        public void EditComment()
        {
            Console.Write("Enter the ID of the comment to edit: ");
            if (int.TryParse(Console.ReadLine(), out int commentId))
            {
                var existingComment = _commentRepository.GetByIdAndItemId(commentId, _itemId);

                if (existingComment is null)
                {
                    Writer.DisplayError($"Comment with id {commentId} not found.\n");
                    return;
                }

                Console.Write("Enter new content: ");
                existingComment.Content = Console.ReadLine();

                var result = _commentRepository.Update(existingComment, commentId);

                if(result != ResponseResultType.Success)
                {
                    Writer.DisplayError("Failed to update comment.\n");
                    return;
                }

                OpenComments();
            }
            else
            {
                Writer.DisplayError("Invalid ID.\n");
            }
        }

        public void DeleteComment()
        {
            Console.Write("Enter the ID of the comment to delete: ");
            if (int.TryParse(Console.ReadLine(), out int commentId))
            {
                var commentToDelete = _commentRepository.GetByIdAndItemId(commentId, _itemId);

                if (commentToDelete is null)
                {
                    Writer.DisplayError($"Comment with id {commentId} not found.\n");
                    return;
                }

                var result = _commentRepository.Delete(commentId);

                if (result != ResponseResultType.Success)
                {
                    Writer.DisplayError("Failed to delete comment.\n");
                    return;
                }

                OpenComments();
            }
            else
            {
                Writer.DisplayError("Invalid ID.\n");
            }
        }
    }
}
