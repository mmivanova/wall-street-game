using System.Collections.Generic;
using WallStreet.Models;

namespace WallStreet.Repositories.AccountRepositories
{
    interface IAccountRepository
    {
        Account Create(string username, string password);
        List<Account> GetAll();
        string GetUsername(int accountId);
        Account Get(string username);
        Account Get(int accountId);
        void Delete(int accountId);
        void Update(int accountId, Account account);
    }
}
