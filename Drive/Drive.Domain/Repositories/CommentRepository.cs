﻿using Drive.Data.Entities;
using Drive.Domain.Enums;
using Drive.Data.Entities.Models;

namespace Drive.Domain.Repositories
{
    public class CommentRepository : BaseRepository
    {
        public CommentRepository(DumpDriveDbContext DbContext) : base(DbContext)
        {
        }

        public ResponseResultType Add(Comment comment)
        {
            DbContext.Comments.Add(comment);

            return SaveChanges();
        }

        public ResponseResultType Update(Comment comment, int commentId)
        {
            var commentToUpdate = DbContext.Comments.Find(commentId);

            if (commentToUpdate == null)
                return ResponseResultType.NotFound;

            commentToUpdate.Content = comment.Content;

            return SaveChanges();
        }

        public ResponseResultType Delete(int commentId) {
            var commentToDelete = DbContext.Comments.Find(commentId);

            if (commentToDelete == null)
                return ResponseResultType.NotFound;

            DbContext.Comments.Remove(commentToDelete);

            return SaveChanges();
        }

        public Comment? GetById(int commentId) => DbContext.Comments.FirstOrDefault(c => c.CommentId == commentId);
    }
}
