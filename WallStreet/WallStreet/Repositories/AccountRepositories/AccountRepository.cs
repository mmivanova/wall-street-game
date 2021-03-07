using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WallStreet.Models;

namespace WallStreet.Repositories.AccountRepositories
{
    class AccountRepository : IAccountRepository
    {
        private readonly Database.DbContext context = new Database.DbContext();

        public List<Account> GetAll()
        {
            List<Account> accounts = new List<Account>();
            context.OpenConnection();
            string query = "SELECT * FROM Account";
            MySqlCommand cmd = new MySqlCommand(query, context.GetConnection());
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Account account = new Account();
                account.AccountId = int.Parse(dataReader["AccountId"] + "");
                account.Username = dataReader["Username"] + "";
                account.Password = dataReader["Password"] + "";
                accounts.Add(account);
            }
            dataReader.Close();
            context.CloseConnection();

            return accounts;
        }

        public Account Get(string username)
        {
            Account account = GetAll().Find(a => a.Username.Equals(username));
            return account;
        }
        public string GetUsername(int accountId)
        {
            Account account = GetAll().Find(u => u.AccountId.Equals(accountId));
            string username = account.Username;
            return username;
        }
        public Account Get(int accountId)
        {
            Account account = GetAll().Find(a => a.AccountId.Equals(accountId));
            return account;
        }

        public void Delete(int accountId)
        {
            string query = $"DELETE FROM Account WHERE AccountId={accountId}";

            if (context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, context.GetConnection());
                cmd.ExecuteNonQuery();
                context.CloseConnection();
            }
        }

        public void Update(int accountId, Account account)
        {
            string query = $"UPDATE Account SET Username={account.Username}, password={account.Password} WHERE AccountId={accountId}";

            if (context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = context.GetConnection();

                cmd.ExecuteNonQuery();

                context.CloseConnection();
            }
        }

        public Account Create(string username, string password)
        {
            string query = $"INSERT INTO Account (Username, Password) VALUES ('{username}', '{password}')";

            if (context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, context.GetConnection());

                cmd.ExecuteNonQuery();

                context.CloseConnection();
            }
            return Get(username);
        }
    }
}
