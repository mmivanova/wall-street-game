using System.Collections.Generic;
using WallStreet.Models;
using WallStreet.Repositories.UserRepositories;

namespace WallStreet.Services.UserServices
{
    class UserService : IUserService
    {
        private readonly IUserRepository userRepository = new UserRepository();

        public User Create(string firstName, string lastName, string email, int accountId)
        {
            return userRepository.Create(firstName, lastName, email, accountId);
        }

        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public User GetByUserId(int userId)
        {
            return userRepository.GetByUserId(userId);
        }

        public User Get(int accountId)
        {
            return userRepository.Get(accountId);
        }

        public void Update(string email, User user)
        {
            userRepository.Update(email, user);
        }

        public void Delete(int accountId)
        {
            userRepository.Delete(accountId);
        }

        public bool IsSuccessfulCreationOfUser(string email)
        {
            return userRepository.IsSuccessfulCreationOfUser(email);
        }
    }
}
