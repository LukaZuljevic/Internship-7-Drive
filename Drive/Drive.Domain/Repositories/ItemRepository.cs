using Drive.Data.Entities;
using Drive.Data.Entities.Models;
using Drive.Domain.Enums;

namespace Drive.Domain.Repositories
{
    public class ItemRepository : BaseRepository
    {
        public ItemRepository(DumpDriveDbContext DbContext) : base(DbContext)
        {
        }

        public Item? GetByItemId(int itemId) => DbContext.Items.FirstOrDefault(i => i.ItemId == itemId);
    }
}

