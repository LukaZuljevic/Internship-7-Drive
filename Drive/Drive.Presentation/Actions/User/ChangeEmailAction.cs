using Drive.Domain.Repositories;
using Drive.Data.Entities.Models;
using Drive.Domain.Enums;
using Drive.Presentation.Helpers;
using Drive.Presentation.Abstractions;

namespace Drive.Presentation.Actions
{
    public class ChangeEmailAction : IAction
    {
        private readonly UserRepository _userRepository;
        public string ActionName { get; set; } = "Change Email";
        public User User { get; set; }

        public ChangeEmailAction(UserRepository userRepository, User user)
        {
            _userRepository = userRepository;
            User = user;
        }

        public void Open()
        {
            var email = string.Empty;
            do
            {
                email = Reader.TryReadEmail("Enter your new email address");
            }
            while (Reader.IsEmailAlreadyInUse(email, _userRepository));

            User.Email = email;
            var result = _userRepository.Update(User, User.UserId);

            Writer.DisplayInfo(result == ResponseResultType.Success
                 ? "\nEmail updated successfully!"
                 : "\nFailed to update email. Please try again.");

            Reader.PressAnyKey();

            Console.Clear();
        }
    }
}
