using Drive.Presentation.Abstractions;

namespace Drive.Presentation.Actions
{
    public class LogoutAction : IAction
    {
        public string ActionName { get; set; } = "Logout";

        public LogoutAction(string actionName)
        {
            ActionName = actionName;
        }
        public void Open()
        {
        }

    }
}