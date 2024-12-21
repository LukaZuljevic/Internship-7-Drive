using Drive.Data.Entities.Models;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;
using Drive.Domain.Factories;


namespace Drive.Presentation.Actions
{
    public class CreateDiskAction
    {
        private static DiskRepository _diskRepository = RepositoryFactory.Create<DiskRepository>();
        private static UserRepository _userRepository = RepositoryFactory.Create<UserRepository>();
        public static void Open(string email)
        {
            User user = _userRepository.GetByEmail(email);

            Reader.TryReadInput("Enter disk name", out string name);

            var disk = new Disk(name, user.UserId);

            var result = _diskRepository.Add(disk);
        }
    }
}
