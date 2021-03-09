using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WallStreet.Models;

namespace WallStreet.Repositories.UserRepositories
{
    class UserRepository : IUserRepository
    {
        private Database.DbContext _context = new Database.DbContext();

        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            _context.OpenConnection();
            string query = "SELECT * FROM User";
            MySqlCommand cmd = new MySqlCommand(query, _context.GetConnection());
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                User user = new User();
                user.UserId = int.Parse(dataReader["UserId"] + "");
                user.FirstName = dataReader["FirstName"] + "";
                user.LastName = dataReader["LastName"] + "";
                user.Email = dataReader["Email"] + "";
                user.AccountId = int.Parse(dataReader["AccountId"] + "");
                user.Money = decimal.Parse(dataReader["Money"] + "");
                user.StockCapacity = int.Parse(dataReader["StockCapacity"] + "");
                users.Add(user);
            }
            dataReader.Close();
            _context.CloseConnection();

            return users;
        }

        public User Create(string firstName, string lastName, string email, int accountId)
        {
            string query = $"INSERT INTO User (FirstName, LastName, Email, AccountId, Money, StockCapacity) VALUES ('{firstName}', '{lastName}', '{email}', {accountId}, {10000}, {100})";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, _context.GetConnection());

                cmd.ExecuteNonQuery();

                _context.CloseConnection();
            }
            return Get(email);
        }

        public User Get(string email)
        {
            User user = GetAll().Find(u => u.Email.Equals(email));
            return user;
        }

        public User GetByUserId(int userId)
        {
            User user = GetAll().Find(u => u.UserId.Equals(userId));
            return user;
        }

        public User Get(int accountId)
        {
            User user = GetAll().Find(u => u.AccountId.Equals(accountId));
            return user;
        }

        public void Delete(int accountId)
        {
            string query = $"DELETE FROM User WHERE AccountId={accountId}";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, _context.GetConnection());
                cmd.ExecuteNonQuery();
                _context.CloseConnection();
            }
        }

        public void Update(string email, User user)
        {
            string query = $"UPDATE User SET firstName={user.FirstName}, lastName={user.LastName}, {user.Email} WHERE email={email}";

            if (_context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _context.GetConnection();

                cmd.ExecuteNonQuery();

                _context.CloseConnection();
            }
        }

        public bool IsSuccessfulCreationOfUser(string email)
        {
            if (GetAll().Find(u=>u.Email.Equals(email)) != null)
            {
                return true;
            }
            return false;
        }

    }
}
