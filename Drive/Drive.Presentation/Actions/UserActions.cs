using Drive.Presentation.Helpers;
using Drive.Domain.Factories;
using Drive.Domain.Repositories;
using Drive.Domain.Enums;
using Drive.Data.Entities.Models;

namespace Drive.Presentation.Actions
{
    public class UserActions
    {
        private static UserRepository _userRepository = RepositoryFactory.Create<UserRepository>();
        public static bool IsEmailAlreadyInUse(string email)
        {
            var user = _userRepository.GetByEmail(email);

            if (user is not null)
            {
                Writer.DisplayError("Email is already in use. Please try again.\n");
                return true;
            }

            return false;
        }

        public static void RegisterUser(string email, string password)
        {   
            var user = new User(email, password);

            var result = _userRepository.Add(user);

            if (result != ResponseResultType.Success)
            {
                Writer.DisplayError("Registration failed. Please try again.\n");
                Reader.PressAnyKey();
            }
        }
    }
}
