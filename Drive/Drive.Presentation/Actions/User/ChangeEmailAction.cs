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
        private readonly User _user;
        public string ActionName { get; set; } = "Change Email";
        public ChangeEmailAction(UserRepository userRepository, User user)
        {
            _userRepository = userRepository;
            _user = user;
        }

        public void Open()
        {
            string email;
            do
            {
                email = Reader.TryReadEmail("Enter your new email address");
            }
            while (Reader.IsEmailAlreadyInUse(email, _userRepository));

            _user.Email = email;
            var result = _userRepository.Update(_user, _user.UserId);

            Writer.DisplayInfo(result == ResponseResultType.Success
                 ? "\nEmail updated successfully!"
                 : "\nFailed to update email. Please try again.");

            Reader.PressAnyKey();
        }
    }
}
