using Drive.Data.Entities.Models;
using Drive.Domain.Repositories;

namespace Drive.Presentation.Helpers
{
    public class Reader
    {   
        public static void PressAnyKey()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(intercept: true);
        }

        public static void TryReadInput(string message, out string input)
        {
            do
            {
                Console.Write($"{message}: ");
                input = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(input))
                    Writer.DisplayError("Input cannot be empty. Please try again.\n");

            } while (string.IsNullOrEmpty(input));
        }

        public static bool IsValidEmail(string email)
        {
            var emailParts = email.Split("@");

            if (emailParts.Length != 2 || emailParts[0].Length < 1)
                return false;

            var secondEmailPart = emailParts[1].Split(".");

            if (secondEmailPart.Length < 2 || secondEmailPart[0].Length < 2 || secondEmailPart[1].Length < 3)
                return false;

            return true;
        }

        public static string TryReadEmail(string message)
        {
            while (true)
            {
                TryReadInput(message, out string input);

                if (input == "exit")
                    return input;

                if (IsValidEmail(input))
                    return input;

                Writer.DisplayError("Invalid email address. Please try again.\n");
            }
        }

        public static bool IsEmailAlreadyInUse(string email, UserRepository userRepository)
        {
            var user = userRepository.GetByEmail(email);

            if (user is not null)
            {
                Writer.DisplayError("Email is already in use. Please try again.\n");
                return true;
            }

            return false;
        }

        public static string TryReadPassword(string message)
        {
            while (true)
            {
                TryReadInput(message, out string input);

                if (IsValidPassword(input))
                    return input;

                Writer.DisplayError("Password must be at least 5 characters long. Please try again.\n");
            }
        }

        public static bool IsValidPassword(string password)
        {
            return password.Length >= 5 && password.Length <= 20;
        }

        public static string ConfirmPassword(string message)
        {
            var password = TryReadPassword(message);

            while (true)
            {
                var confirmPassword = TryReadPassword("Confirm your password");

                if (password == confirmPassword)
                    return password;

                Writer.DisplayError("Passwords do not match. Please try again.\n");
            }
        }

        public static bool ConfirmCaptcha()
        {
            var random = new Random();

            char randomLetter = (char)random.Next('A', 'Z' + 1);
            int randomNumber = random.Next(10, 99);

            var expectedCaptcha = $"{randomLetter}{randomNumber}";

            while (true)
            {
                TryReadInput($"Enter the captcha ({expectedCaptcha})", out string input);

                if (input == expectedCaptcha)
                    return true;

                Writer.DisplayError("Incorrect captcha. Please try again.\n");
            }
        }

        public static bool IsCommand(string input, string expectedCommand)
        {
            return input.Equals(expectedCommand, StringComparison.OrdinalIgnoreCase);
        }

        public static bool StartsWithCommand(string input, string prefix)
        {
            return input.StartsWith(prefix, StringComparison.OrdinalIgnoreCase);
        }

        public static bool CheckIfNameAlreadyExists(string name, List<Folder> folders, List<Files> files)
        {
            if (folders.Any(i => i.Name == name) || files.Any(i => i.Name == name))
            {
                Writer.DisplayError($"Name {name} already exists in this location\n");
                return true;
            }

            return false;
        }

        public static void TryReadCommand(Dictionary<Func<string, bool>, Action<string>> commandDictionary)
        {
            while (true)
            {
                TryReadInput("Enter a command ('help' to see all commands, 'exit' to quit navigation)", out var command);
                command = command.Trim();

                if (IsCommand(command, "exit"))
                    break;

                var matchedCommand = commandDictionary.Keys.FirstOrDefault(predicate => predicate(command));

                if (matchedCommand != null)
                {
                    commandDictionary[matchedCommand](command);
                }
                else
                {
                    Writer.DisplayError("Invalid command. Try again.\n");
                }
            }
        }

        public static (string?, string?) ParseShareCommand(string command, int expectedParts, int firstPart, int secondPart)
        {
            var commandParts = command.Split(" ");

            if (!CheckShareCommand(commandParts.Length, expectedParts)) 
                return (null, null);

            return (commandParts[firstPart], commandParts[secondPart]);
        }

        public static bool CheckShareCommand( int commandPartsLength, int length)
        {
            if (commandPartsLength < length)
            {
                Writer.DisplayError("Invalid command. Try again.\n");
                return false;
            }
            return true;    
        }

        public static bool IsAlreadyShared(string itemName, int userId, SharedItemRepository sharedItemRepository)
        {
            var sharedItem = sharedItemRepository.GetByNameAndUserId(itemName, userId);
            if (sharedItem != null)
            {
                Writer.DisplayError($"Item {itemName} is already being shared\n");
                return true;
            }
            return false;
        }

        public static bool ConfirmAction(string message)
        {
            TryReadInput($"\n{message} (y/n)", out var input);

            while(input != "n" && input != "y")
            {
                Writer.DisplayInfo("Enter n or y");
                TryReadInput($"\n{message} (y/n)", out input);
            }

            return input == "y";
        }
    }
}
