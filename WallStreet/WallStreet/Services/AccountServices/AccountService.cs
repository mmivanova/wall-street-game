using System.Collections.Generic;
using WallStreet.Models;
using WallStreet.Repositories.AccountRepositories;

namespace WallStreet.Services.AccountServices
{
    class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository = new AccountRepository();
        public bool IsExistingAccount(string username, string password)
        {
            Account findAccount = accountRepository.GetAccount(username, password);
            bool isExistingUser = findAccount != null;

            return isExistingUser;
        }

        public bool IsExistingAccount(Account account)
        {
            return IsExistingAccount(account.Username, account.Password);
        }

        public Account GetAccount(string username, string pasword)
        {
            return accountRepository.GetAccount(username, pasword);
        }

        public Account CreateAccount(string username, string pasword)
        {
            return accountRepository.CreateAccount(username, pasword);
        }

        public List<Account> GetAll()
        {
            return accountRepository.GetAll();
        }
    }
}
