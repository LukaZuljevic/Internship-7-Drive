using Drive.Presentation.Abstractions;

namespace Drive.Presentation.Actions
{
    public class ExitAppAction : IAction
    {
        public string ActionName { get; set; } = "Exit the app";

        public ExitAppAction()
        {
        }

        public void Open()
        {
        }

    }
}
