﻿using Drive.Data.Entities.Models;
using Drive.Domain.Enums;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Actions
{
    public class CommentCommandActions
    {
        private readonly UserRepository _userRepository;

        private readonly CommentRepository _commentRepository;

        private static int _itemId;

        private readonly User _user;
        public CommentCommandActions(UserRepository userRepository , CommentRepository commentRepository, int itemId, User user)
        {
            _userRepository = userRepository;
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

            Writer.PrintComments(comments, _userRepository);
        }

        public void AddComment()
        {
            Reader.TryReadInput("Enter a new comment", out var content);

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
            Console.Write("Enter an ID of the comment to edit: ");
            if (int.TryParse(Console.ReadLine(), out int commentId))
            {
                var existingComment = _commentRepository.GetByIdAndItemId(commentId, _itemId);

                if (existingComment is null)
                {
                    Writer.DisplayError($"Comment with ID {commentId} not found.\n");
                    return;
                }

                Reader.TryReadInput("Enter new content", out var newContent);
                existingComment.Content = newContent;

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
                    Writer.DisplayError($"Comment with ID {commentId} not found.\n");
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
