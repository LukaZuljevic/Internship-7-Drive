using Drive.Presentation.Abstractions;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;
using Drive.Data.Entities.Models;
using Drive.Presentation.Factories;

namespace Drive.Presentation.Actions.Authentications
{
    public class RegisterAction : IAction
    {
        private readonly UserRepository UserRepository;

        public string ActionName { get; set; } = "Register";

        public RegisterAction(UserRepository userRepository)
        {
            UserRepository = userRepository;
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
            while (UserActions.IsEmailAlreadyInUse(email));

            var password = Reader.ConfirmPassword();

            var captchaConfirmation = Reader.ConfirmCaptcha();

            UserActions.RegisterUser(email, password);

            CreateDiskAction.Open(email);

            Writer.DisplaySuccess("\nRegistration successful!");
            Reader.PressAnyKey();

            var loginAction = new LoginAction(UserRepository);
            loginAction.Open();

        }
    }
}
