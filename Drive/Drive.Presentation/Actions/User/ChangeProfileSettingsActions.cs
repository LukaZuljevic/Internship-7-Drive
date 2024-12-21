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
            Console.Clear();

            while (true)
            {
                Writer.DisplayInfo("========== Profile Settings ==========\n");
                Console.WriteLine("1. Change Email\n2. Change Password\n3. Back to Main Menu");

                Reader.TryReadInput("\nSelect an option", out var input);

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
            var email = string.Empty;
            do
            {
                email = Reader.TryReadEmail("Enter your new email address");
            }
            while (UserActions.IsEmailAlreadyInUse(email));

            User.Email = email;
            var result = _userRepository.Update(User, User.UserId);

            Writer.DisplayInfo(result == ResponseResultType.Success
                 ? "Email updated successfully!"
                 : "Failed to update email. Please try again.");

            Reader.PressAnyKey();

            Console.Clear();
        }

        private void ChangePassword()
        {
            var password = Reader.ConfirmPassword();

            User.Password = password;
            var result = _userRepository.Update(User, User.UserId);

            Writer.DisplayInfo(result == ResponseResultType.Success
                  ? "Password updated successfully!"
                  : "Failed to update Password. Please try again.");

            Reader.PressAnyKey();

            Console.Clear();
        }
    }
}
