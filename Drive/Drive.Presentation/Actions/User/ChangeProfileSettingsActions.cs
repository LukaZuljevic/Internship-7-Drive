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
        private readonly User _user;
        public string ActionName { get; set; } = "Profile settings";
        public ChangeProfileSettingsActions(User user)
        {
            _user = user;
        }

        public void Open()
        {
            var settingsActions = ProfileSettingsMenuFactory.CreateActions(_user);

            Console.Clear();
            settingsActions.PrintActions("========== Profile Settings ==========\n");
        }       
    }
}
