using System.Collections.Generic;
using WallStreet.Models;

namespace WallStreet.Repositories.TransactionRepositories
{
    internal interface ITransactionRepository
    {
        Transaction Get(int transactionId);
        List<Transaction> GetAll();
        List<Transaction> GetTransactionsByUser(int userId);
        Transaction GetByUser(int userId);
        void Create(int stockId, int usesrId, int quantity, decimal price, bool isBought);
        bool BuyStocks(int quantity, Stock stock, int userId);
        void SellStocks(int quantity, Stock stock, int userId);
    }
}
