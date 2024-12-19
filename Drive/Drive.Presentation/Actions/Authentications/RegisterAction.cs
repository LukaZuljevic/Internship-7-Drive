using Drive.Presentation.Abstractions;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;
using Drive.Data.Entities.Models;


namespace Drive.Presentation.Actions.Authentications
{
    public class RegisterAction : IAction
    {
        private readonly UserRepository _userRepository;

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
            while (UserActions.IsEmailAlreadyInUse(email));

            var password = Reader.ConfirmPassword();

            var captchaConfirmation = Reader.ConfirmCaptcha();

            UserActions.RegisterUser(email, password);

            Writer.DisplaySuccess("\nRegistration successful!");
            Reader.PressAnyKey();
        }
    }
}
