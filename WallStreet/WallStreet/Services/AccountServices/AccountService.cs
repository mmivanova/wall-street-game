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
            Account findAccount = accountRepository.Get(username);
            bool isExistingUser = findAccount != null;

            return isExistingUser;
        }


        public bool IsExistingAccount(Account account)
        {
            return IsExistingAccount(account.Username, account.Password);
        }

        public Account GetAccount(string username)
        {
            return accountRepository.Get(username);
        }

        public string GetUsername(int accountId)
        {
            return accountRepository.GetUsername(accountId);
        }

        public Account GetAccount(int accountId)
        {
            return accountRepository.Get(accountId);
        }

        public Account CreateAccount(string username, string password)
        {
            return accountRepository.Create(username, password);
        }

        public List<Account> GetAll()
        {
            return accountRepository.GetAll();
        }

        public void Delete(int accountId)
        {
            accountRepository.Delete(accountId);
        }

        public void Update(int accountId, Account account)
        {
            accountRepository.Update(accountId, account);
        }
    }
}
