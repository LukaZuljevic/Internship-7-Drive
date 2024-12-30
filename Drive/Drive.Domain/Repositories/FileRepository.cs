using Drive.Data.Entities;
using Drive.Domain.Enums;
using Drive.Data.Entities.Models;

namespace Drive.Domain.Repositories
{
    public class FileRepository : BaseRepository
    {
        public FileRepository(DumpDriveDbContext DbContext) : base(DbContext)
        {
        }

        public ResponseResultType Add(Files file)
        {
            DbContext.Files.Add(file);

            return SaveChanges();
        }

        public ResponseResultType Update(Files file, int fileId)
        {
            var fileToUpdate = DbContext.Files.Find(fileId);

            if (fileToUpdate == null)
                return ResponseResultType.NotFound;

            fileToUpdate.Name = file.Name;
            fileToUpdate.Content = file.Content;
            fileToUpdate.LastChangedAt = DateTime.UtcNow;

            return SaveChanges();
        }

        public Files? GetById(int fileId) => DbContext.Files.FirstOrDefault(f => f.ItemId == fileId);
        public Files? GetByName(string fileName, User user) => DbContext.Files.FirstOrDefault(f => f.Name == fileName && user.DiskId == f.DiskId);
    }
}
