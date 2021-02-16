using System.Collections.Generic;
using WallStreet.Models;
using WallStreet.Services.UserServices;

namespace WallStreet.Repositories.AccountRepositories
{
    class AccountRepository : IAccountRepository
    {
        private static readonly List<Account> accounts = new List<Account>();
        public AccountRepository()
        {
            accounts.Add(new Account("Ivancho", "ivan123"));
            accounts.Add(new Account("MariaK", "mimi123"));
            accounts.Add(new Account("Ivanka", "ivanka123"));
            accounts.Add(new Account("username", "password"));
        }

        public List<Account> GetAll()
        {
            return accounts;
        }

        public Account GetAccount(string username, string password)
        {
            return accounts.Find(a => a.Username.Equals(username) && a.Password.Equals(password));
        }

        public Account CreateAccount(string username, string password)
        {
            accounts.Add(new Account(username, password));
            return GetAccount(username, password);
        }
    }
}
