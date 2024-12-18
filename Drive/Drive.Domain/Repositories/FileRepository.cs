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

            return SaveChanges();
        }

        public ResponseResultType Delete(int fileId) {
            var fileToDelete = DbContext.Files.Find(fileId);

            if (fileToDelete == null)
                return ResponseResultType.NotFound;

            DbContext.Files.Remove(fileToDelete);

            return SaveChanges();
        }

        public Files? GetById(int fileId) => DbContext.Files.FirstOrDefault(f => f.ItemId == fileId);
    }
}
