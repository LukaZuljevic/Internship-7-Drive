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
        private static DiskRepository _diskRepository = RepositoryFactory.Create<DiskRepository>();
        public string ActionName { get; set; } = "Register";

        public RegisterAction(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Open()
        {
            Console.Clear();
            Writer.DisplayInfo("========== Registration ==========\n");

            var email = string.Empty;
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
            }

            User user = _userRepository.GetByEmail(email);

            Reader.TryReadInput("Enter disk name", out string name);

            var disk = new Disk(name, user.UserId);

            result = _diskRepository.Add(disk);
            if (result != ResponseResultType.Success)
                Writer.DisplayError("Error creating disk");

            Writer.DisplaySuccess("\nRegistration successful!");
            Reader.PressAnyKey();

            var loginAction = new LoginAction(_userRepository);
            loginAction.Open();

        }
    }
}
