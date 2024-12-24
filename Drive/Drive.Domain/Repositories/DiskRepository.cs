using Drive.Data.Entities;
using Drive.Domain.Enums;
using Drive.Data.Entities.Models;

namespace Drive.Domain.Repositories
{
    public class DiskRepository : BaseRepository
    {
        public DiskRepository(DumpDriveDbContext DbContext) : base(DbContext)
        {
        }
        public ResponseResultType Add(Disk disk)
        {
            DbContext.Disks.Add(disk);

            return SaveChanges();
        }

        public ResponseResultType Delete(int diskId)
        {
            var diskToDelete = DbContext.Disks.Find(diskId);

            if (diskToDelete == null)
                return ResponseResultType.NotFound;

            DbContext.Disks.Remove(diskToDelete);

            return SaveChanges();
        }

        public Disk? GetById(int diskId) => DbContext.Disks.FirstOrDefault(d => d.DiskId == diskId);

    }
}
