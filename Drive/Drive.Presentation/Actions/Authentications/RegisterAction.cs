using Drive.Presentation.Abstractions;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;
using Drive.Data.Entities.Models;
using Drive.Domain.Enums;
using Drive.Domain.Factories;

namespace Drive.Presentation.Actions.Authentications
{
    public class RegisterAction : IAction
    {
        private readonly UserRepository _userRepository;
        private readonly static DiskRepository _diskRepository = RepositoryFactory.Create<DiskRepository>();
        public string ActionName { get; set; } = "Register";

        public RegisterAction(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Open()
        {
            Console.Clear();
            Writer.DisplayInfo("========== Registration ==========\n");
            Writer.DisplayInfo("(put 'exit' as email to exit registration)\n");

            var email = PromptEmail();
            if (email == null) return;

            var password = Reader.ConfirmPassword("Enter your password");
            if (!Reader.ConfirmCaptcha()) return;

            if (!RegisterUser(email, password)) return;

            var user = _userRepository.GetByEmail(email);

            Reader.TryReadInput("Enter disk name", out string diskName);
            if (!CreateUserDisk(diskName, user)) return;

            Writer.DisplaySuccess("\nRegistration successful!");
            Reader.PressAnyKey();
        }

        private string? PromptEmail()
        {
            string email;
            do
            {
                email = Reader.TryReadEmail("Enter your email address");

                if (email == "exit")
                    return null;

            } while (Reader.IsEmailAlreadyInUse(email, _userRepository));

            return email;
        }

        private bool RegisterUser(string email, string password)
        {
            var newUser = new User(email, password);

            var result = _userRepository.Add(newUser);
            if (result != ResponseResultType.Success)
            {
                Writer.DisplayError("Registration failed. Please try again.\n");
                Reader.PressAnyKey();
                return false;
            }

            return true;
        }

        private bool CreateUserDisk(string diskName, User user)
        {
            var disk = CreateAndAssignDisk(diskName, user);
            if (disk == null)
            {
                Writer.DisplayError("Registration failed due to a disk creation error.");
                return false;
            }

            user.DiskId = disk.DiskId;
            _userRepository.Update(user, user.UserId);

            return true;
        }

        private Disk? CreateAndAssignDisk(string name, User user)
        {
            var newDisk = new Disk(name, user.UserId);
            var diskCreationResult = _diskRepository.Add(newDisk);

            if (diskCreationResult != ResponseResultType.Success)
            {
                Writer.DisplayError($"Error creating disk: {diskCreationResult}");
                return null;
            }

            return _diskRepository.GetById(user.UserId);
        }
    }
}
