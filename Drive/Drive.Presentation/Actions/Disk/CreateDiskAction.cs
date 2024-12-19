using Drive.Data.Entities.Models;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;
using Drive.Domain.Factories;


namespace Drive.Presentation.Actions
{
    public class CreateDiskAction
    {
        private static DiskRepository DiskRepository = RepositoryFactory.Create<DiskRepository>();
        private static UserRepository UserRepository = RepositoryFactory.Create<UserRepository>();
        public static void Open(string email)
        {
            User user = UserRepository.GetByEmail(email);

            Reader.TryReadInput("Enter disk name", out string name);

            var disk = new Disk(name, user.UserId);

            var result = DiskRepository.Add(disk);
        }
    }
}
