using Drive.Data.Entities.Models;
using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Presentation.Abstractions;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Actions
{
    public class PrintAllDiskItemsAction : IAction
    {
        private readonly DiskRepository DiskRepository;
        private static UserRepository UserRepository = RepositoryFactory.Create<UserRepository>();
        public string ActionName { get; set; } = "View All Items";

        public User User { get; set; }
        public PrintAllDiskItemsAction(DiskRepository diskRepository, User user)
        {
            DiskRepository = diskRepository;
            User = user;
        }

        public void Open()
        {
            Console.Clear();
            Writer.DisplayInfo("========== All Items on your disk ==========\n");

            var listOfFiles = UserRepository.GetUserFiles(User);
            var listOfFolders = UserRepository.GetUserFolders(User);

            Writer.PrintFolders(listOfFolders);
            Console.WriteLine("");
            Writer.PrintFiles(listOfFiles);
        }
    }
}
