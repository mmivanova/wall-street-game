using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WallStreet.Models;
using WallStreet.Services.UserServices;

namespace WallStreet.Repositories.TransactionRepositories
{
    class TransactionRepository : ITransactionRepository
    {
        private readonly Database.DbContext context = new Database.DbContext();
        private readonly IUserService userService = new UserService();

        public List<Transaction> GetAll()
        {
            List<Transaction> transactions = new List<Transaction>();
            context.OpenConnection();
            string query = @"SELECT Transaction.Id as Id, Transaction.Quantity as Quantity, Transaction.Price as TransactionPrice, Transaction.IsBought as IsBought,
            Stock.StockId as StockId, Stock.Ticker as Ticker, Stock.Company as Company, Stock.Price as StockPrice,
            User.UserId as UserId, User.FirstName as FirstName, User.LastName as LastName, User.Email as Email, User.AccountId as AccountId, User.Money as Money, User.StockCapacity as Capacity
                FROM Transaction 
            INNER JOIN User
                ON Transaction.UserId = User.UserId
            INNER JOIN Stock
                ON Transaction.StockId = Stock.StockId";
            MySqlCommand cmd = new MySqlCommand(query, context.GetConnection());
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Transaction transaction = new Transaction();
                transaction.TransactionId = int.Parse(dataReader["Id"] + "");
                Stock stock = new Stock
                {
                    StockId = int.Parse(dataReader["StockId"] + ""),
                    Ticker = dataReader["Ticker"] + "",
                    Company = dataReader["Company"] + "",
                    Price = decimal.Parse(dataReader["StockPrice"] + "")
                };
                transaction.Stock = stock;
                User user = new User
                {
                    UserId = int.Parse(dataReader["UserId"] + ""),
                    FirstName = dataReader["FirstName"] + "",
                    LastName = dataReader["LastName"] + "",
                    Email = dataReader["Email"] + "",
                    AccountId = int.Parse(dataReader["AccountId"] + ""),
                    Money = decimal.Parse(dataReader["Money"] + ""),
                    StockCapacity = int.Parse(dataReader["Capacity"] + "")

                };
                transaction.User = user;
                transaction.Price = decimal.Parse(dataReader["TransactionPrice"] + "");
                transaction.Quantity = int.Parse(dataReader["Quantity"] + "");
                transaction.IsBought = bool.Parse(dataReader["IsBought"] + "");
                transactions.Add(transaction);
            }
            dataReader.Close();
            context.CloseConnection();

            return transactions;
        }

        public List<Transaction> GetTransactionsByUser(int userId)
        {
            List<Transaction> transactions = new List<Transaction>();
            foreach (var transaction in GetAll().FindAll(u=>u.User.UserId.Equals(userId)))
            {
                transactions.Add(transaction);
            }
            return transactions;
        }

        public Transaction Get(int transactionId)
        {
            Transaction transaction = GetAll().Find(t => t.TransactionId.Equals(transactionId));
            return transaction;
        }

        public Transaction GetByUser(int userId)
        {
            Transaction transaction = GetAll().Find(t => t.User.UserId.Equals(userId));
            return transaction;
        }

        public void Create(int stockId, int usesrId, int  quantity, decimal price, bool isBought)
        {
            string query = $"INSERT INTO Transaction (StockId, UserId, Quantity, Price, IsBought) VALUES ('{stockId}', '{usesrId}', '{quantity}', {price}, {isBought})";

            if (context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, context.GetConnection());

                cmd.ExecuteNonQuery();

                context.CloseConnection();
            }
        }

        public bool BuyStocks(int quantity, Stock stock, int userId)
        {
            bool isBought = true;
            User user = userService.GetByUserId(userId);
            decimal finalPrice = stock.Price * quantity;
            if (user.Money < finalPrice)
            {
                return false;
            }
            user.Money -= finalPrice;
            user.StockCapacity -= quantity;
            Create(stock.StockId, userId, quantity, finalPrice, isBought);
            Update(userId, user);
            return true;
        }


        public void SellStocks(int quantity, Stock stock, int userId)
        {
            // TODO can't sell stocks if you don't have any 
            bool isBought = false;
            decimal finalIncome = stock.Price * quantity;
            User user = userService.GetByUserId(userId);
            user.Money += finalIncome;
            user.StockCapacity += quantity;
            Create(stock.StockId, userId, quantity, finalIncome, isBought);
            Update(userId, user);
        }

        public void Update(int userId, User user)
        {
            string query = $"UPDATE User SET Money={user.Money}, StockCapacity={user.StockCapacity} WHERE UserId={userId}";

            if (context.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = context.GetConnection();

                cmd.ExecuteNonQuery();

                context.CloseConnection();
            }
        }
    }
}
