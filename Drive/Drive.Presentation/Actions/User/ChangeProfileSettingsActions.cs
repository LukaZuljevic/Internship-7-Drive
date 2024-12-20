using Drive.Data.Entities.Models;
using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;
using Drive.Presentation.Abstractions;
using Drive.Domain.Enums;

namespace Drive.Presentation.Actions
{
    public class ChangeProfileSettingsActions : IAction
    {
        private readonly UserRepository _userRepository;
        public string ActionName { get; set; } = "Profile settings";
        public User User { get; set; }

        public ChangeProfileSettingsActions(UserRepository userRepository, User user)
        {
            _userRepository = userRepository;
            User = user;
        }

        public void Open()
        {
            Writer.DisplayInfo("========== Profile Settings ==========");

            while (true)
            {
                Writer.DisplayInfo("1. Change Email\n2. Change Password\n3. Back to Main Menu");

                Reader.TryReadInput("Select an option", out var input);

                switch (input)
                {
                    case "1":
                        ChangeEmail();
                        break;
                    case "2":
                        ChangePassword();
                        break;
                    case "3":
                        return;
                    default:
                        Writer.DisplayError("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private void ChangeEmail()
        {
            var email = Reader.TryReadEmail("Enter your new email address");

            if (IsEmailAlreadyInUse(email)) return;

            User.Email = email;
            var result = _userRepository.Update(User, User.UserId);

            if (result == ResponseResultType.Success)
            {
                Writer.DisplaySuccess("Email updated successfully!");
            }
            else
            {
                Writer.DisplayError("Failed to update email. Please try again.");
            }
        }

        private void ChangePassword()
        {
            var password = Reader.ConfirmPassword();

            User.Password = password;
            var result = _userRepository.Update(User, User.UserId);

            if (result == ResponseResultType.Success)
            {
                Writer.DisplaySuccess("Password updated successfully!");
            }
            else
            {
                Writer.DisplayError("Failed to update password. Please try again.");
            }
        }

        private bool IsEmailAlreadyInUse(string email)
        {
            var user = _userRepository.GetByEmail(email);

            if (user is not null)
            {
                Writer.DisplayError("Email is already in use. Please try again.");
                return true;
            }

            return false;
        }
    }
}
