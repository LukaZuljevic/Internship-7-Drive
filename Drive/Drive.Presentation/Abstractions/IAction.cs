using Drive.Presentation.Actions;

namespace Drive.Presentation.Abstractions
{
    public interface IAction
    {
        string ActionName { get; set; }
        void Open();    }
}