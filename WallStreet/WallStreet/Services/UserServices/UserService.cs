using WallStreet.Models;
using WallStreet.Repositories.UserRepositories;

namespace WallStreet.Services.UserServices
{
    class UserService : IUserService
    {
        private readonly IUserRepository userRepository = new UserRepository();

        public User CreateUser(string firstName, string lastName, string email, string username, string password)
        {
            return userRepository.CreateUser(firstName, lastName, email, username, password);
        }

        public User GetUser(string username)
        {
            return userRepository.GetUser(username);
        }

        public User GetUser(Account account)
        {
            return userRepository.GetUser(account);
        }

        public bool IsSuccessfulCreationOfUser(string username)
        {
            return userRepository.IsSuccessfulCreationOfUser(username);
        }
    }
}
