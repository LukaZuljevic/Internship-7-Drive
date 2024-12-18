using Drive.Presentation.Factories;
using Drive.Presentation.Extensions;
using Drive.Presentation.Helpers;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the DUMP Drive app!");
        Reader.PressAnyKey();

        var authenticationActions = AuthenticationFactory.CreateActions();
        authenticationActions.PrintActions();

    }
}
