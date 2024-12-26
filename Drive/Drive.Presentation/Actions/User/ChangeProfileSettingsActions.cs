using Drive.Data.Entities.Models;
using Drive.Domain.Repositories;
using Drive.Presentation.Helpers;
using Drive.Presentation.Abstractions;
using Drive.Presentation.Factories;
using Drive.Presentation.Extensions;

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
            var settingsActions = ProfileSettingsMenuFactory.CreateActions(User);

            Console.Clear();
            settingsActions.PrintActions("========== Profile Settings ==========\n");
        }       
    }
}
