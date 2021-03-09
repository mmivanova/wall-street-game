using System.Collections.Generic;
using System.Windows.Forms;
using WallStreet.Models;
using WallStreet.Repositories.TransactionRepositories;
using WallStreet.Services.UserServices;

namespace WallStreet.Services.TransactionServices
{
    internal class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository transactionRepository = new TransactionRepository();
        private readonly IUserService userService = new UserService();
        public Transaction Get(int transactionId)
        {
            return transactionRepository.Get(transactionId);
        }

        public List<Transaction> GetAll()
        {
            return transactionRepository.GetAll();
        }

        public List<Transaction> GetTransactionsByUser(int userId)
        {
            return transactionRepository.GetTransactionsByUser(userId);
        }

        public Transaction GetByUser(int userId)
        {
            return transactionRepository.GetByUser(userId);
        }

        public void BuyStocks(int quantity, Stock stock, int userId)
        {
            try
            {
                transactionRepository.BuyStocks(quantity, stock, userId); 
                MessageBox.Show("You have successfully bought your stocks!");
            }
            catch
            {
                MessageBox.Show("A problem occurred. Please contact administrator!");
            }
        }

        public void SellStocks(int quantity, Stock stock, int userId)
        {
            User user = userService.GetByUserId(userId);
            Dictionary<string, int> stockAndQuantity =
                userService.GetStocksAndQuantityFromTransactions(GetTransactionsByUser(userId));
            try
            {
                if (!stockAndQuantity.ContainsKey(stock.Ticker) || stockAndQuantity[stock.Ticker] < quantity)
                {
                    MessageBox.Show("You can't sell stocks that you do not possess. ");
                }
                else
                {
                    transactionRepository.SellStocks(quantity, stock, userId);
                    MessageBox.Show("You have successfully sold your stocks!");
                }
            }
            catch
            {
                MessageBox.Show("A problem occurred. Please contact administrator!");
            }
        }
    }
}
