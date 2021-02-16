using System.Collections.Generic;
using WallStreet.Models;
using WallStreet.Services.AccountServices;

namespace WallStreet.Repositories.UserRepositories
{
    class UserRepository : IUserRepository
    {
        private readonly IAccountService accountService = new AccountService();
        private static readonly List<User> users = new List<User>();

        public UserRepository()
        {
            users.Add(new User("Ivan", "Petrov", "ipetrov@gmail.com", accountService.GetAccount("Ivancho", "ivan123")));
            users.Add(new User("Maria", "Kotseva", "maria_k89@gmail.com", accountService.GetAccount("MariaK", "mimi123")));
            users.Add(new User("Ivan", "Petrov", "ipetrov@gmail.com", accountService.GetAccount("Ivanka", "ivanka123")));
            users.Add(new User("admin", "admin", "admin@gmail.com", accountService.GetAccount("username", "password")));
        }

        public User CreateUser(string firstName, string lastName, string email, string username, string password)
        {
            users.Add(new User(firstName, lastName, email, accountService.CreateAccount(username, password)));
            return users.Find(a => a.Account.Username.Equals(username));
        }

        public User GetUser(string username)
        {
            return users.Find(u => u.Account.Username.Equals(username));
        }
       
        public User GetUser(Account account)
        {
            return users.Find(u => u.Account.Equals(account));
        }

        public bool IsSuccessfulCreationOfUser(string username)
        {
            return users.Find(a => a.Account.Username.Equals(username)) != null;
        }
    }
}
