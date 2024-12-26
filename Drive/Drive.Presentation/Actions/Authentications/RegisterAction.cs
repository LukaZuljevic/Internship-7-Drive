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

            string email;
            do
            {
                email = Reader.TryReadEmail("Enter your email address");
            }
            while (Reader.IsEmailAlreadyInUse(email, _userRepository));

            var password = Reader.ConfirmPassword();
            var captchaConfirmation = Reader.ConfirmCaptcha();

            var newUser = new User(email, password);

            var result = _userRepository.Add(newUser);
            if (result != ResponseResultType.Success)
            {
                Writer.DisplayError("Registration failed. Please try again.\n");
                Reader.PressAnyKey();
                return;
            }

            User user = _userRepository.GetByEmail(email);

            Reader.TryReadInput("Enter disk name", out string diskName);

            var disk = CreateAndAssignDisk(diskName, user);
            if (disk is null)
            {
                Writer.DisplayError("Registration failed due to a disk creation error.");
                return;
            }

            user.DiskId = disk.DiskId;
            _userRepository.Update(user, user.UserId);

            Writer.DisplaySuccess("\nRegistration successful!");
            Reader.PressAnyKey();
        }

        private Disk CreateAndAssignDisk(string name, User user)
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
