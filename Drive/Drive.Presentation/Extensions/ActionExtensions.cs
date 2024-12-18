using Drive.Presentation.Abstractions;
using Drive.Presentation.Actions;

namespace Drive.Presentation.Extensions
{
    public static class ActionExtensions
    {
        public static void PrintActions(this IList<IAction> actions)
        {
            Console.Clear();

            for (int i = 0; i < actions.Count; i++)
                Console.WriteLine($"{i + 1}. {actions[i].ActionName}");


            while (true)
            {
                Console.Write("\nSelect an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= actions.Count)
                {
                    actions[choice - 1].Open();

                    if (actions[choice - 1] is ExitMenuAction)
                    {
                        Console.WriteLine("Exiting the application.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input. Please enter a number between 1 and {actions.Count}.");
                }
            }

        }
    }
}
