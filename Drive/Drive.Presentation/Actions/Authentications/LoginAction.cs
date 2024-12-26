using Drive.Domain.Repositories;
using Drive.Presentation.Abstractions;
using Drive.Presentation.Extensions;
using Drive.Presentation.Factories;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Actions.Authentications
{
    public class LoginAction : IAction
    {
        private readonly UserRepository _userRepository;

        public string ActionName { get; set; } = "Login";

        public LoginAction(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Open()
        {
            while (true)
            {
                Console.Clear();
                Writer.DisplayInfo("========== Login ==========\n");

                var email = Reader.TryReadEmail("Enter your email");
                var password = Reader.TryReadPassword("Enter your password");

                var user = _userRepository.GetByEmail(email);

                if (user != null && user.Password == password)
                {
                    var userActions = MainMenuFactory.CreateActions(user);

                    Console.Clear();
                    userActions.PrintActions("========== Main Menu ==========\n");
                    return; 
                }

                Writer.DisplayError("Invalid email or password. Please try again in 3 seconds.\n");
                Thread.Sleep(3000);
            }
        }
    }
}
