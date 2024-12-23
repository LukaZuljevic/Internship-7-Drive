using Drive.Data.Entities.Models;
using Drive.Domain.Enums;
using Drive.Domain.Repositories;
using Drive.Presentation.Abstractions;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Actions
{
    public class ChangePasswordAction : IAction
    {
        private readonly UserRepository _userRepository;
        public string ActionName { get; set; } = "Change Password";
        public User User { get; set; }

        public ChangePasswordAction(UserRepository userRepository, User user)
        {
            _userRepository = userRepository;
            User = user;
        }

        public void Open()
        {
            var password = Reader.ConfirmPassword();

            User.Password = password;
            var result = _userRepository.Update(User, User.UserId);

            Writer.DisplayInfo(result == ResponseResultType.Success
                  ? "\nPassword updated successfully!"
                  : "\nFailed to update Password. Please try again.");

            Reader.PressAnyKey();

            Console.Clear();
        }
    }
}
