using Drive.Presentation.Abstractions;

namespace Drive.Presentation.Actions
{
    public class LogoutAction : IAction
    {
        public string ActionName { get; set; } = "Logout";

        public LogoutAction()
        {
        }

        public void Open()
        {
        }

    }
}