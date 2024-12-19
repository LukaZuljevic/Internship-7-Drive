using Drive.Domain.Repositories;
using Drive.Presentation.Abstractions;
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
            Writer.DisplayInfo("========== Login ==========\n");

            var email = Reader.TryReadEmail("Enter your email address");

            var password = Reader.TryReadPassword("Enter your password");

            var user = _userRepository.GetByEmail(email);

            if(user is null || user.Password != password)
            {
                Writer.DisplayError("Invalid email or password. Please try again in 3 seconds.\n");
                Thread.Sleep(3000);
                Open();
            }
        }
    }
}
