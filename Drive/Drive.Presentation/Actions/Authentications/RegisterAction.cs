using Drive.Presentation.Abstractions;
using Drive.Domain.Repositories;

namespace Drive.Presentation.Actions.Authentications
{
    public class RegisterAction : IAction
    {
        private readonly UserRepository _userRepository;

        public RegisterAction(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string ActionName { get; set; }

        public void Open()
        {
            Console.WriteLine("Uspjesno si otvoria registracijsku formu");
        }
    }
}
