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

            if (secondEmailPart.Length < 2 || secondEmailPart[0].Length < 2 || secondEmailPart[1].Length < 2)
                return false;

            return true;
        }

        public static string TryReadEmail(string message)
        {
            while (true)
            {
                TryReadInput(message, out string input);

                if (IsValidEmail(input))
                    return input;

                Writer.DisplayError("Invalid email address. Please try again.\n");
            }
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
            return password.Length >= 5;
        }

        public static string ConfirmPassword()
        {
            while (true)
            {
                var password = TryReadPassword("Enter your password");
                var confirmPassword = TryReadPassword("Confirm your password");

                if (password == confirmPassword)
                    return password;

                Writer.DisplayError("Passwords do not match. Please try again.\n");
            }
        }
    }
}
