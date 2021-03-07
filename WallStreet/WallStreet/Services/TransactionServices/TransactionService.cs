using System.Collections.Generic;
using System.Windows.Forms;
using WallStreet.Models;
using WallStreet.Repositories.TransactionRepositories;

namespace WallStreet.Services.TransactionServices
{
    internal class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository transactionRepository = new TransactionRepository();
        public Transaction Get(int transactionId)
        {
            return transactionRepository.Get(transactionId);
        }

        public List<Transaction> GetAll()
        {
            return transactionRepository.GetAll();
        }

        public void BuyStocks(int quantity, Stock stock, int userId)
        {
            try
            {
                transactionRepository.BuyStocks(quantity, stock, userId);
            }
            catch
            {
                MessageBox.Show("A problem occurred. Please contact administrator!");
            }
        }

        public void SellStocks(int quantity, Stock stock, int userId)
        {
            try
            {
                transactionRepository.SellStocks(quantity, stock, userId);
            }
            catch
            {
                MessageBox.Show("A problem occurred. Please contact administrator!");
            }
        }
    }
}
