using Drive.Domain.Repositories;
using Drive.Presentation.Abstractions;
using Drive.Presentation.Extensions;
using Drive.Presentation.Factories;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Actions.Authentications
{
    public class LoginAction : IAction
    {
        private readonly UserRepository UserRepository;

        public string ActionName { get; set; } = "Login";

        public LoginAction(UserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public void Open()
        {
            Writer.DisplayInfo("========== Login ==========\n");

            var email = Reader.TryReadEmail("Enter your email address");

            var password = Reader.TryReadPassword("Enter your password");

            var user = UserRepository.GetByEmail(email);

            if(user is null || user.Password != password)
            {
                Writer.DisplayError("Invalid email or password. Please try again in 3 seconds.\n");
                Thread.Sleep(3000);
                Open();
            }

            var userActions = MainMenuFactory.CreateActions(user);
            userActions.PrintActions();
        }
    }
}
