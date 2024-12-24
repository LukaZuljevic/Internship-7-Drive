using Drive.Data.Entities;
using Drive.Domain.Enums;
using Drive.Data.Entities.Models;

namespace Drive.Domain.Repositories
{
    public class SharedItemRepository : BaseRepository
    {
        public SharedItemRepository(DumpDriveDbContext DbContext) : base(DbContext)
        {
        }

        public ResponseResultType Add(SharedItem sharedItem)
        {
            DbContext.SharedItems.Add(sharedItem);

            return SaveChanges();
        }

        public ResponseResultType Delete(int sharedItemId) {
            var sharedItemToDelete = DbContext.SharedItems.Find(sharedItemId);

            if (sharedItemToDelete == null)
                return ResponseResultType.NotFound;

            DbContext.SharedItems.Remove(sharedItemToDelete);

            return SaveChanges();
        }

        public SharedItem? GetByNameAndUserId(string sharedItemName, int userId) => DbContext.SharedItems.FirstOrDefault(f => f.ItemName == sharedItemName && f.UserId == userId);

        public List<SharedItem> GetByUserId(int userId) => DbContext.SharedItems.Where(i => i.UserId == userId).ToList();
    }
}
