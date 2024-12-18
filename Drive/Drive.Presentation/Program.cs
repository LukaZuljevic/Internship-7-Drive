using Drive.Presentation.Factories;
using Drive.Presentation.Abstractions;
using Drive.Presentation.Actions;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to your Drive!");
        var actions = AuthenticationFactory.CreateActions();
        while (true)
        {
            Console.WriteLine("\nAvailable Actions:");
            for (int i = 0; i < actions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {actions[i].ActionName}");
            }

            Console.Write("Select an option: ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= actions.Count)
            {
                actions[choice - 1].Open();

                if (actions[choice - 1] is ExitMenuAction)
                {
                    Console.WriteLine("Exiting the application.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
