using System.Collections.Generic;
using WallStreet.Models;

namespace WallStreet.Services.AccountServices
{
    interface IAccountService
    {
        bool IsExistingAccount(string username, string password);
        bool IsExistingAccount(Account user);
        Account GetAccount(string username, string pasword);
        Account CreateAccount(string username, string pasword);
        List<Account> GetAll();
    }
}
