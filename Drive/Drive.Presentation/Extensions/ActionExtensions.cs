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

                    var actionHandlers = new Dictionary<string, Action> 
                    {
                          { "Logout", () => { Writer.DisplayInfo("Logging out..."); } },
                          { "Exit the app", () => { Writer.DisplayInfo("Exiting the app..."); } },
                          { "Return", () => { Writer.DisplayInfo("Returning..."); } }
                    };

                    if (actionHandlers.TryGetValue(selectedAction.ActionName, out var handler))
                    {
                        handler();
                        return;
                    }

                    selectedAction.Open();
                    Console.Clear();
                    PrintActions(actions, header);
                    return;
                }
                else
                {
                    Writer.DisplayError("Invalid option. Please try again.");
                }
            }
        }

    }
}
    



