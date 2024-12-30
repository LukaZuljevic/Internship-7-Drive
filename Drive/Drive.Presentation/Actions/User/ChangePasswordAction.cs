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
        private readonly User _user;
        public string ActionName { get; set; } = "Change Password";
        public ChangePasswordAction(UserRepository userRepository, User user)
        {
            _userRepository = userRepository;
            _user = user;
        }

        public void Open()
        {
            var password = Reader.ConfirmPassword("Enter your new password");

            _user.Password = password;
            var result = _userRepository.Update(_user, _user.UserId);

            Writer.DisplayInfo(result == ResponseResultType.Success
                  ? "\nPassword updated successfully!"
                  : "\nFailed to update Password. Please try again.;");

            Reader.PressAnyKey();
        }
    }
}
