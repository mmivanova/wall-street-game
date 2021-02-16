using System.Collections.Generic;
using WallStreet.Models;

namespace WallStreet.Repositories.AccountRepositories
{
    interface IAccountRepository
    {
        Account CreateAccount(string username, string password);
        List<Account> GetAll();
        Account GetAccount(string username, string password);
        // User GetUser(Account account);
    }
}
