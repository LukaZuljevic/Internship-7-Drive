using Drive.Data.Entities;
using Drive.Data.Entities.Models;
using Drive.Domain.Enums;

namespace Drive.Domain.Repositories
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(DumpDriveDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(User user)
        {
            DbContext.Users.Add(user);

            return SaveChanges();
        }

        public ResponseResultType Update(User user, int userId)
        {
            var userToUpdate = DbContext.Users.Find(userId);

            if (userToUpdate == null)
                return ResponseResultType.NotFound;

            userToUpdate.Email = user.Email;
            userToUpdate.Password = user.Password;

            return SaveChanges();
        }

        public User? GetById(int userId) => DbContext.Users.FirstOrDefault(u => u.UserId == userId);
        public User? GetByEmail(string email) => DbContext.Users.FirstOrDefault(u => u.Email == email);

        public List<Folder> GetUserFolders(User user) => DbContext.Folders.Where(f => f.DiskId == user.DiskId).ToList();
        public List<Files> GetUserFiles(User user) => DbContext.Files.Where(f => f.DiskId == user.DiskId).ToList();
    }
}
