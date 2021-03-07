using System.Collections.Generic;
using WallStreet.Models;

namespace WallStreet.Services.AccountServices
{
    interface IAccountService
    {
        bool IsExistingAccount(string username, string password);
        bool IsExistingAccount(Account account);
        Account GetAccount(string username);
        string GetUsername(int accountId);
        Account GetAccount(int accountId);
        Account CreateAccount(string username, string password);
        List<Account> GetAll();
        void Delete(int accountId);
        void Update(int accountId, Account account);
    }
}
