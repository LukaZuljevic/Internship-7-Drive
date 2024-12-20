using Drive.Presentation.Abstractions;
using Drive.Presentation.Actions;
using Drive.Presentation.Helpers;

namespace Drive.Presentation.Extensions
{
    public static class ActionExtensions
    {
        public static void PrintActions(this IList<IAction> actions, string header = "")
        {
            if (!string.IsNullOrWhiteSpace(header))
            {
                Console.Clear();
                Writer.DisplayInfo(header);
            }

            for (int i = 0; i < actions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {actions[i].ActionName}");
            }

            HandleUserSelection(actions, header);
        }

        private static void HandleUserSelection(IList<IAction> actions, string header)
        {
            while (true)
            {
                Console.Write("\nSelect an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= actions.Count)
                {
                    var selectedAction = actions[choice - 1];

                    if (selectedAction is LogoutAction)
                    {
                        Writer.DisplayInfo("Logging out.");
                        return; 
                    }

                    if (selectedAction is ExitAppAction)
                    {
                        Writer.DisplayInfo("Exiting the application.");
                        Environment.Exit(0);
                    }

                    selectedAction?.Open();

                    Console.Clear();
                    PrintActions(actions, header);
                    return;
                }
                else
                {
                    Writer.DisplayError($"Invalid input. Please enter a number between 1 and {actions.Count}");
                }
            }
        }
    }
}
    



