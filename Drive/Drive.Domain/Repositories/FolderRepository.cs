using Drive.Data.Entities;
using Drive.Data.Entities.Models;
using Drive.Domain.Enums;

namespace Drive.Domain.Repositories
{
    public class FolderRepository : BaseRepository
    {
        public FolderRepository(DumpDriveDbContext DbContext) : base(DbContext)
        {
        }

        public ResponseResultType Add(Folder folder)
        {
            DbContext.Folders.Add(folder);

            return SaveChanges();
        }

        public ResponseResultType Update(Folder folder, int folderId) 
        {
            var folderToUpdate = DbContext.Folders.Find(folderId);

            if (folderToUpdate == null)
                return ResponseResultType.NotFound;

            folderToUpdate.Name = folder.Name;

            return SaveChanges();
        }

        public ResponseResultType Delete(int folderId) 
        {
            var folderToDelete = DbContext.Folders.Find(folderId);

            if (folderToDelete == null)
                return ResponseResultType.NotFound;

            DbContext.Folders.Remove(folderToDelete);

            return SaveChanges();
        }
        public Folder? GetByName(string folderName, User user) => DbContext.Folders.FirstOrDefault(f => f.Name == folderName && user.DiskId == f.DiskId);

        public Folder? GetById(int folderId) => DbContext.Folders.FirstOrDefault(f => f.ItemId == folderId);
    }
}

